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
    public partial class AddTransactionPage : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private List<EggCategory> _cachedCategories = new List<EggCategory>();
        private TransactionPage TransactionPage;

        public AddTransactionPage(TransactionPage transactionPage)
        {
            this.TransactionPage = transactionPage; 
            InitializeComponent();
            LoadEggCategories();
        }

        private async Task LoadEggCategories()
        {
            try
            {
                var listKategori = await _apiService.EggCategory.GetEggCategoriesAsync();
                if (listKategori != null)
                {
                    _cachedCategories = listKategori;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Gagal memuat master kategori ke cache: {ex.Message}");
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddDynamicInputRow();
        }

        private void AddDynamicInputRow()
        {
            // 1. Buat panel pembungkus horizontal per baris
            Panel rowPanel = new Panel
            {
                Width = TransactionItemsContainer.Width - 25, // Dikurangi sedikit agar scrollbar vertikal aman
                Height = 35
            };

            // 2. Buat ComboBox untuk memilih kategori telur
            ComboBox CategoryComboBox = new ComboBox
            {
                Name = "CategoryComboBoxId",
                Width = 160,
                Location = new Point(5, 5),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // Masukkan data cache kategori ke dalam dropdown
            CategoryComboBox.DataSource = new BindingSource(_cachedCategories, null);
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";

            // 3. Buat TextBox untuk input jumlah (Qty)
            TextBox QtyTextField = new TextBox
            {
                Name = "QtyTextField",
                Width = 60,
                Location = new Point(175, 5),
                Text = "1"
            };

            // 4. Buat Button kecil untuk menghapus baris input ini jika user membatalkannya
            Button btnDeleteRow = new Button
            {
                Text = "X",
                Width = 30,
                Height = 23,
                Location = new Point(240, 4),
                ForeColor = Color.Red,
                FlatStyle = FlatStyle.Flat
            };
            btnDeleteRow.Click += (s, e) => { TransactionItemsContainer.Controls.Remove(rowPanel); };

            // 5. Gabungkan komponen ke dalam panel baris
            rowPanel.Controls.Add(CategoryComboBox);
            rowPanel.Controls.Add(QtyTextField);
            rowPanel.Controls.Add(btnDeleteRow);

            // 6. Masukkan panel baris tersebut ke dalam FlowLayoutPanel utama
            TransactionItemsContainer.Controls.Add(rowPanel);
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddItemButton.Enabled = false;
                ActionResponse<Transaction> response = new ActionResponse<Transaction>();

                    Transaction transaksiBaru = new Transaction
                    {
                        Date = DateTimePicker.Value,
                        CustomerName = CustomerNameTextField.Text,
                        CustomerPhoneNumber = CustomerPhoneNumbeTextField.Text,
                        Details = new List<TransactionDetail>()
                    };

                    // SISI SISIR DYNAMIC CONTROLS: Looping setiap panel yang ada di dalam FlowLayoutPanel
                    foreach (Control control in TransactionItemsContainer.Controls)
                    {
                        if (control is Panel rowPanel)
                        {
                            ComboBox? CategoryComboBox = rowPanel.Controls["CategoryComboBoxId"] as ComboBox;
                            TextBox? QtyTextField = rowPanel.Controls["QtyTextField"] as TextBox;

                            if (CategoryComboBox != null && QtyTextField != null)
                            {
                                // Validasi input Qty per baris harus berupa angka bulat positif
                                if (!int.TryParse(QtyTextField.Text, out int qty) || qty <= 0)
                                {
                                    MessageBox.Show("Ada inputan jumlah item yang tidak valid (harus angka > 0)!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    AddItemButton.Enabled = true;
                                    return;
                                }

                                var detailItem = new TransactionDetail
                                {
                                    CategoryId = Convert.ToInt32(CategoryComboBox.SelectedValue),
                                    Quantity = qty,
                                };

                                transaksiBaru.Details.Add(detailItem);
                            }
                        }
                    }

                    // Kirim ke API menggunakan service kasir SIPETOK
                    response = await _apiService.Transaction.CreateTransactionAsync(transaksiBaru);

                if (response.Success)
                {
                    TransactionPage TransactionPage = new TransactionPage();
                    await TransactionPage.RefreshGrid();
                    MessageBox.Show("Transaksi SIPETOK berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AddItemButton.Enabled = true;
            }
        }
        private async void CancelButton_Click(object sender, EventArgs e)
        {
            await TransactionPage.RefreshGrid();
            this.Close();
        }

    }
}
