using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.response;
using sipetok_form.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipetok_form.Views.Transactions
{
    public partial class TransactionPage : Form
    {
        private Transaction? _selectedTransaction = null;
        private readonly ApiService _apiService = new ApiService();

        public TransactionPage()
        {
            InitializeComponent();
            SetupRoleBasedUI();
            this.Load += FormMain_Load;
            TransactionsList.CellContentClick += TransactionsList_CellContentClick;
        }

        private void SetupRoleBasedUI()
        {
            if (UserSession.Role == 1)
            {
                UserMenu.Visible = true;
                TenantMenu.Visible = true;
                TransactionMenu.Visible = false;
                OperationalMenu.Visible = false;
                ReportMenu.Visible = false;
                StockMenu.Visible = false;
                EggCategoryMenu.Visible = false;
            }
            else if (UserSession.Role == 2)
            {
                UserMenu.Visible = false;
                TenantMenu.Visible = false;
                TransactionMenu.Visible = true;
                OperationalMenu.Visible = true;
                ReportMenu.Visible = true;
                StockMenu.Visible = true;
                EggCategoryMenu.Visible = true;
            }
            else
            {
                UserMenu.Visible = false;
                TenantMenu.Visible = false;
                TransactionMenu.Visible = false;
                OperationalMenu.Visible = false;
                ReportMenu.Visible = false;
                StockMenu.Visible = false;
                EggCategoryMenu.Visible = false;
            }
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await RefreshGrid();
        }

        public async Task RefreshGrid()
        {
            try
            {
                List<Transaction>? data = await _apiService.Transaction.GetTransactionsAsync();

                if (data != null)
                {
                    TransactionsList.DataSource = null;
                    TransactionsList.DataSource = data;

                    // Atur Susunan Header Utama GUI (Id, CustomerName, dll...)
                    TransactionsList.Columns["Id"].HeaderText = "Id";
                    TransactionsList.Columns["CustomerName"].HeaderText = "Customer Name";
                    TransactionsList.Columns["CustomerPhoneNumber"].HeaderText = "Customer Phone Number";
                    TransactionsList.Columns["TotalPrice"].HeaderText = "Total Price";
                    TransactionsList.Columns["PaymentAmount"].HeaderText = "PaymentAmount";
                    TransactionsList.Columns["PaymentStatus"].HeaderText = "Payment Status";
                    TransactionsList.Columns["OrderStatus"].HeaderText = "Order Status";
                    TransactionsList.Columns["Details"].Visible = false;

                    // 1. Buat dulu semua kolom buttonnya
                    SetupActionButtons();

                    // 2. Buat variabel tracker untuk mengecek apakah ada status tertentu di dalam list data
                    bool adaWaitingPayment = false;
                    bool adaReadyForPickup = false;

                    foreach (var transaction in data)
                    {
                        if (transaction.PaymentStatus == "WaitingForPayment" && transaction.OrderStatus == "OrderComeIn")
                        {
                            adaWaitingPayment = true;
                        }
                        if (transaction.PaymentStatus == "Success" && transaction.OrderStatus == "ReadyForPickup")
                        {
                            adaReadyForPickup = true;
                        }
                    }

                    // 3. KONTROL VISIBILITAS KOLOM SECARA GLOBAL
                    // Jika tidak ada satu pun transaksi yang berstatus WaitingForPayment, HIDE kolom bayar & cancel
                    TransactionsList.Columns["PayButton"].Visible = adaWaitingPayment;
                    TransactionsList.Columns["CancelButton"].Visible = adaWaitingPayment;

                    // Jika tidak ada satu pun transaksi yang berstatus ReadyForPickup, HIDE kolom complete
                    TransactionsList.Columns["CompleteButton"].Visible = adaReadyForPickup;


                    // 4. KONTROL RENDERING CELL PER BARIS (Trik gabungan agar baris yang tidak memenuhi syarat tetap bersih)
                    foreach (DataGridViewRow row in TransactionsList.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var transaction = (Transaction)row.DataBoundItem;

                        // Jika kolomnya terlihat, tapi baris ini tidak memenuhi syarat status, hapus button di baris ini saja
                        if (TransactionsList.Columns["PayButton"].Visible && !(transaction.PaymentStatus == "WaitingForPayment" && transaction.OrderStatus == "OrderComeIn"))
                        {
                            row.Cells["PayButton"] = new DataGridViewTextBoxCell { Value = "" };
                            row.Cells["CancelButton"] = new DataGridViewTextBoxCell { Value = "" };
                        }

                        if (TransactionsList.Columns["CompleteButton"].Visible && !(transaction.PaymentStatus == "Success" && transaction.OrderStatus == "ReadyForPickup"))
                        {
                            row.Cells["CompleteButton"] = new DataGridViewTextBoxCell { Value = "" };
                        }
                    }

                    TransactionsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Gagal memuat data dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupActionButtons()
        {
            if (TransactionsList.Columns.Contains("DetailButton")) TransactionsList.Columns.Remove("DetailButton");
            if (TransactionsList.Columns.Contains("PayButton")) TransactionsList.Columns.Remove("PayButton");
            if (TransactionsList.Columns.Contains("CompleteButton")) TransactionsList.Columns.Remove("CompleteButton");
            if (TransactionsList.Columns.Contains("CancelButton")) TransactionsList.Columns.Remove("CancelButton");

            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "DetailButton",
                HeaderText = "Aksi Detail",
                Text = "Detail Transaksi",
                UseColumnTextForButtonValue = true
            };
            TransactionsList.Columns.Add(btnDetail);

            DataGridViewButtonColumn btnPay = new DataGridViewButtonColumn
            {
                Name = "PayButton",
                HeaderText = "Aksi Bayar",
                Text = "Bayar Transaksi",
                UseColumnTextForButtonValue = true
            };
            TransactionsList.Columns.Add(btnPay);

            DataGridViewButtonColumn btnComplete = new DataGridViewButtonColumn
            {
                Name = "CompleteButton",
                HeaderText = "Aksi Complete",
                Text = "Complete Transaksi",
                UseColumnTextForButtonValue = true
            };
            TransactionsList.Columns.Add(btnComplete);

            DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn
            {
                Name = "CancelButton",
                HeaderText = "Aksi Cancel",
                Text = "Cancel Transaksi",
                UseColumnTextForButtonValue = true
            };
            TransactionsList.Columns.Add(btnCancel);
        }

        private void AdjustGridHeight()
        {
            int totalHeight = TransactionsList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in TransactionsList.Rows)
            {
                totalHeight += row.Height;
            }
            TransactionsList.Height = totalHeight + 4;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTransactionPage addPage = new AddTransactionPage(this);
            addPage.Show();
        }

        private async void TransactionsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Validasi: Cegah error crash jika user mengklik sel yang tombolnya sudah diubah jadi TextBoxCell
            if (TransactionsList.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell) return;

            var dataSelected = (Transaction)TransactionsList.Rows[e.RowIndex].DataBoundItem;
            Debug.WriteLine("id dari list" + dataSelected.Id);

            if (TransactionsList.Columns[e.ColumnIndex].Name == "DetailButton")
            {
                // buka window detail
                DetailTransactionPage detailPage = new DetailTransactionPage(dataSelected.Id);
                detailPage.Show();
            }

            if (TransactionsList.Columns[e.ColumnIndex].Name == "PayButton")
            {
                // buka window pay
                PayTransactionPage payPage = new PayTransactionPage(dataSelected.Id);
                payPage.Show();
            }

            if (TransactionsList.Columns[e.ColumnIndex].Name == "CompleteButton")
            {
                DialogResult result = MessageBox.Show(
                    "Anda ingin menyelesaikan pesanan?",
                    "Confirm Complete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2 // Default to "No"
                );

                if (result == DialogResult.Yes)
                {
                    ActionResponse<Transaction> response = new ActionResponse<Transaction>();
                    response = await _apiService.Transaction.CompleteTransactionAsync(dataSelected.Id);

                    if (response.Success)
                    {
                        await RefreshGrid();
                        MessageBox.Show("Transaksi SIPETOK berhasil diselesaikan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (TransactionsList.Columns[e.ColumnIndex].Name == "CancelButton")
            {
                DialogResult result = MessageBox.Show(
                    "Anda ingin membatalkan pesanan?",
                    "Confirm Cancel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2 // Default to "No"
                );

                if (result == DialogResult.Yes)
                {
                    ActionResponse<Transaction> response = new ActionResponse<Transaction>();
                    response = await _apiService.Transaction.CancelTransactionAsync(dataSelected.Id);

                    if (response.Success)
                    {
                        await RefreshGrid();
                        MessageBox.Show("Transaksi SIPETOK berhasil batalkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HandleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }
    }
}