using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.response;
using sipetok_form.Services;

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
                List<EggCategory>? categories = await _apiService.EggCategory.GetEggCategoriesAsync();
                if (categories != null)
                {
                    CategoryComboBox.DataSource = categories;
                    CategoryComboBox.DisplayMember = "Name";
                    CategoryComboBox.ValueMember = "Id";
                    CategoryComboBox.SelectedIndex = -1;
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
                    EggsList.DataSource = null;
                    EggsList.DataSource = data;

                    EggsList.Columns["Id"].HeaderText = "Id";
                    EggsList.Columns["ProductionDate"].HeaderText = "Tanggal Produksi";
                    EggsList.Columns["Stock"].HeaderText = "Stok";
                    EggsList.Columns["CategoryId"].Visible = false;
                    EggsList.Columns["Category"].HeaderText = "Nama Kategori"; 

                    SetupActionButtons();
                    EggsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (EggsList.Columns.Contains("EditBtn")) EggsList.Columns.Remove("EditBtn");
            if (EggsList.Columns.Contains("DeleteBtn")) EggsList.Columns.Remove("DeleteBtn");

            EggsList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditBtn",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            });

            EggsList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteBtn",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            });
        }

        private void ToggleForm(bool show)
        {
            FormContainer.Visible = show;
            var columnStyles = PageBodyContainer.ColumnStyles;

            if (show)
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 70;
                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 30;
                EggsList.Width = 1300;

                if (_saveDataType == "Update")
                    AttemptFormFields(false);
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;
                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;
                EggsList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = EggsList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in EggsList.Rows)
                totalHeight += row.Height;
            EggsList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            ValidatonErrorMassage.Text = "";

            if (clear)
            {
                _selectedEgg = null;
                ProductionDateTimePicker.Value = DateTime.Today;
                StockTextField.Text = "";
                CategoryComboBox.SelectedIndex = -1;
            }
            else
            {
                ProductionDateTimePicker.Value = _selectedEgg?.ProductionDate ?? DateTime.Today;
                StockTextField.Text = _selectedEgg?.Stock.ToString();
                if (_selectedEgg != null)
                    CategoryComboBox.SelectedValue = _selectedEgg.CategoryId;
            }
        }

        private async void EggList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (Egg)EggsList.Rows[e.RowIndex].DataBoundItem;

            if (EggsList.Columns[e.ColumnIndex].Name == "EditBtn")
            {
                _selectedEgg = dataSelected;
                _saveDataType = "Update";
                ToggleForm(true);
            }

            if (EggsList.Columns[e.ColumnIndex].Name == "DeleteBtn")
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

        private void HandleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ToggleForm(false);
        }
        private void EggsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (EggsList.Columns[e.ColumnIndex].Name == "Category" && e.Value != null)
            {
                if (e.Value is EggCategory categoryObj)
                {
                    e.Value = categoryObj.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveButton.Enabled = false;

                if (string.IsNullOrEmpty(StockTextField.Text))
                {
                    ValidatonErrorMassage.Text = "Stok tidak boleh kosong!";
                    return;
                }

                if (!double.TryParse(StockTextField.Text, out double stock))
                {
                    ValidatonErrorMassage.Text = "Stok harus berupa angka!";
                    return;
                }

                if (CategoryComboBox.SelectedValue == null)
                {
                    ValidatonErrorMassage.Text = "Kategori harus dipilih!";
                    return;
                }

                ActionResponse<Egg> response;

                if (_saveDataType == "Update" && _selectedEgg != null)
                {
                    _selectedEgg.ProductionDate = ProductionDateTimePicker.Value;
                    _selectedEgg.Stock = stock;
                    _selectedEgg.CategoryId = (int)CategoryComboBox.SelectedValue;
                    response = await _apiService.Egg.UpdateEggAsync(_selectedEgg.Id, _selectedEgg);
                }
                else
                {
                    Egg eggBaru = new Egg
                    {
                        ProductionDate = ProductionDateTimePicker.Value,
                        Stock = stock,
                        CategoryId = (int)CategoryComboBox.SelectedValue
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
                    ValidationHelper.ShowValidation(response, ValidatonErrorMassage);
                    MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SaveButton.Enabled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _saveDataType = "create";
            ToggleForm(true);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EggStockPage_Load(object sender, EventArgs e)
        {

        }
    }
}