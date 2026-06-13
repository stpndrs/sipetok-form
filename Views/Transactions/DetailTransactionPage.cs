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
    public partial class DetailTransactionPage : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private int transactionId;
        public TransactionPage trsPage = new TransactionPage();
        public DetailTransactionPage(int transactionId)
        {
            this.transactionId = transactionId;
            FormMain_Load();
            InitializeComponent();
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

                if (response != null)
                {
                    var transaction = response;

                    // 1. Set informasi header data utama ke Label GUI
                    lblOrderStatus.Text = transaction?.OrderStatus;
                    lblPaymentStatus.Text = transaction?.PaymentStatus;
                    lblDate.Text = transaction?.Date.ToString("dd MMMM yyyy");
                    lblCustomerName.Text = transaction?.CustomerName;
                    lblCustomerPhone.Text = transaction?.CustomerPhoneNumber;
                    lblPaymentAmount.Text = transaction?.PaymentAmount.ToString("N2");

                    if (transaction?.Details != null)
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
    }
}
