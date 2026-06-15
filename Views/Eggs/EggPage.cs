using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.response;
using sipetok_form.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sipetok_form.Views.Eggs
{
    public partial class EggStockPage : Form
    {
        private Egg? _selectedEgg = null;
        private string _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public EggStockPage()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            ToggleForm(false);
            await LoadCategories();
            await RefreshGrid();
        }

        private async Task LoadCategories()
        {
            try
            {
                List<EggCategory>? categories = await _apiService.EggCategory.GetEggCategorysAsync();
                if (categories != null)
                {
                    cbbCategory.DataSource = categories;
                    cbbCategory.DisplayMember = "Name";
                    cbbCategory.ValueMember = "Id";
                    cbbCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshGrid()
        {
            try
            {
                List<Egg>? data = await _apiService.Egg.GetEggsAsync();

                if (data != null)
                {
                    eggList.DataSource = null;
                    eggList.DataSource = data;

                    eggList.Columns["Id"].HeaderText = "Id";
                    eggList.Columns["ProductionDate"].HeaderText = "Tanggal Produksi";
                    eggList.Columns["Stock"].HeaderText = "Stok";
                    eggList.Columns["CategoryId"].HeaderText = "Kategori ID";

                    SetupActionButtons();
                    eggList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupActionButtons()
        {
            if (eggList.Columns.Contains("BtnEdit")) eggList.Columns.Remove("BtnEdit");
            if (eggList.Columns.Contains("BtnHapus")) eggList.Columns.Remove("BtnHapus");

            eggList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            });

            eggList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "BtnHapus",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            });
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
                eggList.Width = 1300;

                if (_saveDataType == "update")
                    AttemptFormFields(false);
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;
                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;
                eggList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = eggList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in eggList.Rows)
                totalHeight += row.Height;
            eggList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedEgg = null;
                dtpProductionDate.Value = DateTime.Today;
                txtStock.Text = "";
                cbbCategory.SelectedIndex = -1;
            }
            else
            {
                dtpProductionDate.Value = _selectedEgg?.ProductionDate ?? DateTime.Today;
                txtStock.Text = _selectedEgg?.Stock.ToString();
                if (_selectedEgg != null)
                    cbbCategory.SelectedValue = _selectedEgg.CategoryId;
            }
        }

        private async void usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (Egg)eggList.Rows[e.RowIndex].DataBoundItem;

            if (eggList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedEgg = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            if (eggList.Columns[e.ColumnIndex].Name == "BtnHapus")
            {
                ToggleForm(false);
                DialogResult dialog = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus data stok tanggal {dataSelected.ProductionDate:dd/MM/yyyy}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    ActionResponse<Egg> response = await _apiService.Egg.DeleteEggAsync(dataSelected.Id);
                    if (response.Success)
                        await RefreshGrid();
                    else
                        MessageBox.Show(response.Message, "Gagal Menghapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void handleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
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

                if (string.IsNullOrEmpty(txtStock.Text))
                {
                    validationErrorMsg.Text = "Stok tidak boleh kosong!";
                    return;
                }

                if (!double.TryParse(txtStock.Text, out double stock))
                {
                    validationErrorMsg.Text = "Stok harus berupa angka!";
                    return;
                }

                if (cbbCategory.SelectedValue == null)
                {
                    validationErrorMsg.Text = "Kategori harus dipilih!";
                    return;
                }

                ActionResponse<Egg> response;

                if (_saveDataType == "update" && _selectedEgg != null)
                {
                    _selectedEgg.ProductionDate = dtpProductionDate.Value;
                    _selectedEgg.Stock = stock;
                    _selectedEgg.CategoryId = (int)cbbCategory.SelectedValue;
                    response = await _apiService.Egg.UpdateEggAsync(_selectedEgg.Id, _selectedEgg);
                }
                else
                {
                    Egg eggBaru = new Egg
                    {
                        ProductionDate = dtpProductionDate.Value,
                        Stock = stock,
                        CategoryId = (int)cbbCategory.SelectedValue
                    };
                    response = await _apiService.Egg.CreateEggAsync(eggBaru);
                }

                if (response.Success)
                {
                    await RefreshGrid();
                    ToggleForm(false);
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
                btnSave.Enabled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _saveDataType = "create";
            ToggleForm(true);
        }
    }
}