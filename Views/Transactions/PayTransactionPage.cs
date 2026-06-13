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
using System.Windows.Forms;

namespace sipetok_form.Views.Transactions
{
    public partial class PayTransactionPage : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private int transactionId;
        public TransactionPage trsPage = new TransactionPage();
        public PayTransactionPage(int transactionId)
        {
            this.transactionId = transactionId;
            Debug.WriteLine("id dari pay " + this.transactionId);
            InitializeComponent();
            FormMain_Load();
        }

        private async void FormMain_Load()
        {
            await RefreshGrid();
        }

        public async Task RefreshGrid()
        {
            try
            {
                var response = await _apiService.Transaction.GetTransactionByIdAsync(transactionId);
                Debug.WriteLine("data" + response);

                if (response != null)
                {
                    var transaction = response;

                    // 1. Set informasi header data utama ke Label GUI
                    lblDate.Text = transaction.Date.ToString("dd MMMM yyyy");
                    lblCustomerName.Text = transaction.CustomerName;
                    lblCustomerPhone.Text = transaction.CustomerPhoneNumber;

                    if (transaction.Details != null)
                    {
                        var index = 1;
                        var displayList = transaction.Details.Select(d =>
                        {
                            decimal hargaSatuan = d.Category != null ? d.Category.Price : 0;

                            decimal kalkulasiSubtotal = (decimal)d.Quantity * hargaSatuan;

                            return new
                            {
                                No = index++,
                                CategoryName = d.Category != null ? d.Category.Name : "-",
                                Qty = d.Quantity,
                                PriceAtPurchase = hargaSatuan,
                                Subtotal = kalkulasiSubtotal
                            };
                        }).ToList();

                        decimal totalPrice = displayList.Sum(item => item.Subtotal);
                        lblTotalPrice.Text = totalPrice.ToString("N2");

                        dgvItems.DataSource = null;
                        dgvItems.DataSource = displayList;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show($"Gagal memuat detail transaksi dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                btnPay.Enabled = false;
                ActionResponse<Transaction> response = new ActionResponse<Transaction>();

                Transaction transaction = new Transaction
                {
                    PaymentAmount = decimal.Parse(txtPaymentAmount.Text)
                };

                // Kirim ke API menggunakan service kasir SIPETOK
                response = await _apiService.Transaction.PayTransactionAsync(this.transactionId, transaction);

                if (response.Success)
                {
                    this.Close();
                    await trsPage.RefreshGrid();
                    MessageBox.Show("Transaksi SIPETOK berhasil dibayar!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ValidationHelper.ShowValidation(response, validationErrorMsg);
                    MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPay.Enabled = true;
            }

        }

        private async void cancelBtn_Click(object sender, EventArgs e)
        {
            await trsPage.RefreshGrid();
            this.Close();
        }
    }
}
