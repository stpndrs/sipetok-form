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
            this.Load += FormMain_Load;
            usersList.CellContentClick += usersList_CellContentClick;
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
                    usersList.DataSource = null;
                    usersList.DataSource = data;

                    // Atur Susunan Header Utama GUI (Id, CustomerName, dll...)
                    usersList.Columns["Id"].HeaderText = "Id";
                    usersList.Columns["CustomerName"].HeaderText = "Customer Name";
                    usersList.Columns["CustomerPhoneNumber"].HeaderText = "Customer Phone Number";
                    usersList.Columns["TotalPrice"].HeaderText = "Total Price";
                    usersList.Columns["PaymentAmount"].HeaderText = "PaymentAmount";
                    usersList.Columns["PaymentStatus"].HeaderText = "Payment Status";
                    usersList.Columns["OrderStatus"].HeaderText = "Order Status";
                    usersList.Columns["Details"].Visible = false;

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
                    usersList.Columns["BtnPay"].Visible = adaWaitingPayment;
                    usersList.Columns["BtnCancel"].Visible = adaWaitingPayment;

                    // Jika tidak ada satu pun transaksi yang berstatus ReadyForPickup, HIDE kolom complete
                    usersList.Columns["BtnComplete"].Visible = adaReadyForPickup;


                    // 4. KONTROL RENDERING CELL PER BARIS (Trik gabungan agar baris yang tidak memenuhi syarat tetap bersih)
                    foreach (DataGridViewRow row in usersList.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var transaction = (Transaction)row.DataBoundItem;

                        // Jika kolomnya terlihat, tapi baris ini tidak memenuhi syarat status, hapus button di baris ini saja
                        if (usersList.Columns["BtnPay"].Visible && !(transaction.PaymentStatus == "WaitingForPayment" && transaction.OrderStatus == "OrderComeIn"))
                        {
                            row.Cells["BtnPay"] = new DataGridViewTextBoxCell { Value = "" };
                            row.Cells["BtnCancel"] = new DataGridViewTextBoxCell { Value = "" };
                        }

                        if (usersList.Columns["BtnComplete"].Visible && !(transaction.PaymentStatus == "Success" && transaction.OrderStatus == "ReadyForPickup"))
                        {
                            row.Cells["BtnComplete"] = new DataGridViewTextBoxCell { Value = "" };
                        }
                    }

                    usersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (usersList.Columns.Contains("BtnDetail")) usersList.Columns.Remove("BtnDetail");
            if (usersList.Columns.Contains("BtnPay")) usersList.Columns.Remove("BtnPay");
            if (usersList.Columns.Contains("BtnComplete")) usersList.Columns.Remove("BtnComplete");
            if (usersList.Columns.Contains("BtnCancel")) usersList.Columns.Remove("BtnCancel");

            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "BtnDetail",
                HeaderText = "Aksi Detail",
                Text = "Detail Transaksi",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnDetail);

            DataGridViewButtonColumn btnPay = new DataGridViewButtonColumn
            {
                Name = "BtnPay",
                HeaderText = "Aksi Bayar",
                Text = "Bayar Transaksi",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnPay);

            DataGridViewButtonColumn btnComplete = new DataGridViewButtonColumn
            {
                Name = "BtnComplete",
                HeaderText = "Aksi Complete",
                Text = "Complete Transaksi",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnComplete);

            DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn
            {
                Name = "BtnCancel",
                HeaderText = "Aksi Cancel",
                Text = "Cancel Transaksi",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnCancel);
        }

        private void AdjustGridHeight()
        {
            int totalHeight = usersList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in usersList.Rows)
            {
                totalHeight += row.Height;
            }
            usersList.Height = totalHeight + 4;
        }

        private async void usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Validasi: Cegah error crash jika user mengklik sel yang tombolnya sudah diubah jadi TextBoxCell
            if (usersList.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell) return;

            var dataSelected = (Transaction)usersList.Rows[e.RowIndex].DataBoundItem;
            Debug.WriteLine("id dari list" + dataSelected.Id);

            if (usersList.Columns[e.ColumnIndex].Name == "BtnDetail")
            {
                // buka window detail
                DetailTransactionPage detailPage = new DetailTransactionPage(dataSelected.Id);
                detailPage.Show();
            }

            if (usersList.Columns[e.ColumnIndex].Name == "BtnPay")
            {
                // buka window pay
                PayTransactionPage payPage = new PayTransactionPage(dataSelected.Id);
                payPage.Show();
            }

            if (usersList.Columns[e.ColumnIndex].Name == "BtnComplete")
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

            if (usersList.Columns[e.ColumnIndex].Name == "BtnCancel")
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

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddTransactionPage addPage = new AddTransactionPage(this);
            addPage.Show();
        }
    }
}