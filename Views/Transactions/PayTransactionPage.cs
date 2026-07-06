using sipetok_form.Dto.response;
using sipetok_form.Helpers;
using sipetok_form.Models;
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
        private readonly TransactionPage _transactionPage;
        private int _transactionId;
        public PayTransactionPage(int transactionId, TransactionPage transactionPage)
        {
            _transactionId = transactionId;
            _transactionPage = transactionPage;
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
                var response = await _apiService.Transaction.GetTransactionByIdAsync(_transactionId);

                if (response != null)
                {
                    var transaction = response;

                    // 1. Set informasi header data utama ke Label GUI
                    DateValueLabel.Text = transaction.Date.ToString("dd MMMM yyyy");
                    CustomerNameLabelValue.Text = transaction.CustomerName;
                    CustomerPhoneLabelValue.Text = transaction.CustomerPhoneNumber;

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
                        CustomerPriceLabelValue.Text = totalPrice.ToString("N2");

                        TransactionDetailList.DataSource = null;
                        TransactionDetailList.DataSource = displayList;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Gagal memuat detail transaksi dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                PayButton.Enabled = false;
                ActionResponse<Transaction> response = new ActionResponse<Transaction>();

                Transaction transaction = new Transaction
                {
                    PaymentAmount = decimal.Parse(PaymentAmountTextField.Text)
                };

                // Kirim ke API menggunakan service kasir SIPETOK
                response = await _apiService.Transaction.PayTransactionAsync(_transactionId, transaction);

                if (response.Success)
                {
                    this.Close();
                    TransactionPage transactionPage = new TransactionPage();
                    await transactionPage.RefreshGrid();
                    MessageBox.Show("Transaksi SIPETOK berhasil dibayar!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ValidationHelper.ShowValidation(response, ValidationErrorMessageLabel);
                    MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                PayButton.Enabled = true;
                await _transactionPage.RefreshGrid();
            }

        }

        private async void CancelButton_Click(object sender, EventArgs e)
        {
            await _transactionPage.RefreshGrid();
            this.Close();
        }
    }
}
