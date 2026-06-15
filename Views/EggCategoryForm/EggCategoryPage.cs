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

namespace sipetok_form.Views.EggCategoryForm
{


    public partial class EggCategoryPage : Form
    {

        private EggCategory? _selectedEggCategory = null;
        private string _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public EggCategoryPage()
        {
            InitializeComponent();
            this.EggCategoryList.CellContentClick += EggCategoryList_CellContentClick;
            this.Load += FormMain_Load;

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
                List<EggCategory>? data = await _apiService.EggCategory.GetEggCategorysAsync();

                if (data != null)
                {
                    EggCategoryList.DataSource = null;
                    EggCategoryList.DataSource = data;

                    // Atur Susunan Header Utama GUI
                    EggCategoryList.Columns["Id"].HeaderText = "Id";
                    EggCategoryList.Columns["Name"].HeaderText = "Name";
                    EggCategoryList.Columns["Description"].HeaderText = "Description";
                    EggCategoryList.Columns["Price"].HeaderText = "Price";
                    EggCategoryList.Columns["TenantId"].Visible = false;

                    SetupActionButtons();

                    EggCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (EggCategoryList.Columns.Contains("BtnEdit")) EggCategoryList.Columns.Remove("BtnEdit");
            if (EggCategoryList.Columns.Contains("BtnHapus")) EggCategoryList.Columns.Remove("BtnHapus");

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            EggCategoryList.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn
            {
                Name = "BtnHapus",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            EggCategoryList.Columns.Add(btnHapus);
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
            formPanel.Visible = show;

            var columnStyles = body.ColumnStyles;

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
            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedEggCategory = null;
                txtName.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                //txtTenantId.Text = "";
            }
            else
            {
                Debug.WriteLine(_selectedEggCategory?.Id);
                txtName.Text = _selectedEggCategory?.Name;
                txtDescription.Text = _selectedEggCategory?.Description;
                txtPrice.Text = _selectedEggCategory?.Price.ToString();
                //txtTenantId.Text = _selectedEggCategory?.ToString();
            }
        }
        private async void EggCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (EggCategory)EggCategoryList.Rows[e.RowIndex].DataBoundItem;

            if (EggCategoryList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedEggCategory = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            if (EggCategoryList.Columns[e.ColumnIndex].Name == "BtnHapus")
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


        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void penggunaMenu_Click(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void stokMenu_Click(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ToggleForm(false);
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                ActionResponse<EggCategory> response = new ActionResponse<EggCategory>();

                // 1. Validasi & Parsing Harga (Mengubah string input ke desimal)
                if (!decimal.TryParse(txtPrice.Text, out decimal parsedPrice))
                {
                    MessageBox.Show("Harga harus berupa angka yang valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Parsing Tenant ID (Mengubah string ke integer)
                //if (!int.TryParse(txtTenantId.Text, out int parsedTenantId))
                //{
                //    parsedTenantId = 1; // Default jika kosong atau tidak valid
                //}

                // Proses UPDATE data
                if (_saveDataType == "update")
                {
                    if (_selectedEggCategory != null)
                    {
                        _selectedEggCategory.Name = txtName.Text;
                        _selectedEggCategory.Description = txtDescription.Text;
                        _selectedEggCategory.Price = parsedPrice;
                        //_selectedEggCategory.TenantId = parsedTenantId;

                        response = await _apiService.EggCategory.UpdateEggCategoryAsync(_selectedEggCategory.Id, _selectedEggCategory);
                    }
                }
                // Proses CREATE data baru
                else if (_saveDataType == "create")
                {
                    EggCategory kategoriBaru = new EggCategory
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = parsedPrice
                        //TenantId = parsedTenantId
                    };

                    response = await _apiService.EggCategory.CreateEggCategoryAsync(kategoriBaru);
                }

                // 3. Handle Response dari API
                if (response.Success)
                {
                    await RefreshGrid();
                    ToggleForm(false);
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ValidationHelper.ShowValidation(response, validationErrorMsg);
                    MessageBox.Show(response.Message, "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
    }
}
