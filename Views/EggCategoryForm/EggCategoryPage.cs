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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipetok_form.Views.EggCategoryForm
{
    public partial class EggCategoryPage : Form
    {
        private EggCategory? _selectedEggCategory = null;
        private string? _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public EggCategoryPage()
        {
            InitializeComponent();
            SetupRoleBasedUI();
            this.EggCategoryList.CellContentClick += EggCategoryList_CellContentClick;
            this.Load += FormMain_Load;

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
            ToggleForm(false);
            await RefreshGrid();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _saveDataType = "create";
            ToggleForm(true);

        }
        private async Task RefreshGrid()
        {
            try
            {
                List<EggCategory>? data = await _apiService.EggCategory.GetEggCategoriesAsync();

                if (data != null)
                {
                    EggCategoryList.DataSource = null;
                    EggCategoryList.DataSource = data;

                    // Atur Susunan Header Utama GUI
                    EggCategoryList.Columns["Id"].HeaderText = "Id";
                    EggCategoryList.Columns["Name"].HeaderText = "Name";
                    EggCategoryList.Columns["Description"].HeaderText = "Description";
                    EggCategoryList.Columns["Price"].HeaderText = "Price";
                    EggCategoryList.Columns["TotalEgg"].HeaderText = "Egg Total";
                    EggCategoryList.Columns["TenantId"].Visible = false;

                    SetupActionButtons();

                    EggCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"Gagal memuat data dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupActionButtons()
        {
            if (EggCategoryList.Columns.Contains("editBtn")) EggCategoryList.Columns.Remove("editBtn");

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
            {
                Name = "editBtn",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            EggCategoryList.Columns.Add(editBtn);

        }
        private void AdjustGridHeight()
        {
            int totalHeight = EggCategoryList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in EggCategoryList.Rows)
            {
                totalHeight += row.Height;
            }
            EggCategoryList.Height = totalHeight + 4;
        }

        private void ToggleForm(bool show)
        {
            FormContainer.Visible = show;

            var columnStyles = Body.ColumnStyles;

            if (show)
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 70;

                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 30;

                EggCategoryList.Width = 1300;

                if (_saveDataType == "update")
                {
                    AttemptFormFields(false);
                }
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;

                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;

                EggCategoryList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        public void AttemptFormFields(bool clear)
        {
            ValidationErrorMsg.Text = "";

            if (clear)
            {
                _selectedEggCategory = null;
                NameTextField.Text = "";
                DescriptionTextFiled.Text = "";
                PriceTextField.Text = "";
            }
            else
            {
                NameTextField.Text = _selectedEggCategory?.Name;
                DescriptionTextFiled.Text = _selectedEggCategory?.Description;
                PriceTextField.Text = _selectedEggCategory?.Price.ToString();
            }
        }

        //function SRP baru untuk handle aksi edit dan delete agar lebih clean
        private void HandleEditAction(EggCategory dataSelected)
        {
            _selectedEggCategory = dataSelected;
            _saveDataType = "update";
            ToggleForm(true);
        }

        private async Task HandleDeleteActionAsync(EggCategory dataSelected)
        {
            ToggleForm(false);
            DialogResult dialog = MessageBox.Show($"Apakah Anda yakin...", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                var response = await _apiService.EggCategory.DeleteEggCategoryAsync(dataSelected.Id);
                if (response.Success) await RefreshGrid();
                else MessageBox.Show(response.Message, "Gagal Menghapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void EggCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (EggCategory)EggCategoryList.Rows[e.RowIndex].DataBoundItem;

            if (EggCategoryList.Columns[e.ColumnIndex].Name == "editBtn") HandleEditAction(dataSelected);
            if (EggCategoryList.Columns[e.ColumnIndex].Name == "deleteBtn") await HandleDeleteActionAsync(dataSelected);

            if (EggCategoryList.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                ToggleForm(false);
                DialogResult dialog = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus kategori {dataSelected.Name}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    ActionResponse<EggCategory> response = await _apiService.EggCategory.DeleteEggCategoryAsync(dataSelected.Id);

                    if (response.Success)
                    {
                        await RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Gagal Menghapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void HandleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ToggleForm(false);
        }


        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            // 1. Delegasi Validasi
            if (!ValidateInput(out decimal parsedPrice)) return;

            try
            {
                SaveBtn.Enabled = false;
                // 2. Delegasi Hit API
                ActionResponse<EggCategory> response = await ExecuteSaveRequestAsync(parsedPrice);
                // 3. Delegasi Output UI
                await HandleSaveResponseAsync(response);
            }
            catch (Exception ex) { MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { SaveBtn.Enabled = true; }
        }

        // FUNGSI-FUNGSI BARU SRP baru untuk memisahkan tanggung jawab validasi, eksekusi request, dan output UI agar lebih clean dan maintainable
        private bool ValidateInput(out decimal price)
        {
            if (!decimal.TryParse(PriceTextField.Text, out price))
            {
                MessageBox.Show("Harga harus berupa angka yang valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(NameTextField.Text))
            {
                MessageBox.Show("Nama kategori tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private async Task<ActionResponse<EggCategory>> ExecuteSaveRequestAsync(decimal parsedPrice)
        {
            if (_saveDataType == "update" && _selectedEggCategory != null)
            {
                _selectedEggCategory.Name = NameTextField.Text;
                _selectedEggCategory.Description = DescriptionTextFiled.Text;
                _selectedEggCategory.Price = parsedPrice;
                return await _apiService.EggCategory.UpdateEggCategoryAsync(_selectedEggCategory.Id, _selectedEggCategory);
            }

            EggCategory newCategory = new EggCategory { Name = NameTextField.Text, Description = DescriptionTextFiled.Text, Price = parsedPrice };
            return await _apiService.EggCategory.CreateEggCategoryAsync(newCategory);
        }

        private async Task HandleSaveResponseAsync(ActionResponse<EggCategory> response)
        {
            if (response.Success)
            {
                await RefreshGrid();
                ToggleForm(false);
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ValidationHelper.ShowValidation(response, ValidationErrorMsg);
                MessageBox.Show(response.Message, "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
