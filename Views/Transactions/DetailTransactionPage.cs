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
        private int _transactionId;
        public DetailTransactionPage(int transactionId)
        {
            _transactionId = transactionId;
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
                var response = await _apiService.Transaction.GetTransactionByIdAsync(_transactionId);

                if (response != null)
                {
                    var transaction = response;

                    // 1. Set informasi header data utama ke Label GUI
                    OrderStatusLabelValue.Text = transaction?.OrderStatus;
                    PaymentStatusLabelValue.Text = transaction?.PaymentStatus;
                    DateLabelValue.Text = transaction?.Date.ToString("dd MMMM yyyy");
                    CustomerNameLabelValue.Text = transaction?.CustomerName;
                    CustomerPhoneLabelValue.Text = transaction?.CustomerPhoneNumber;
                    PaymentAmountLabelValue.Text = transaction?.PaymentAmount.ToString("N2");

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
                        TotalPriceLabelValue.Text = totalPrice.ToString("N2");

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
    }
}
