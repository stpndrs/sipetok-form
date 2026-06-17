using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.response;
using sipetok_form.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipetok_form.Views.Operationals
{
    public partial class OperationalPage : Form
    {
        private Operational? _selectedOperational = null;
        private string _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public OperationalPage()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            ToggleForm(false);
            await RefreshGrid();
        }

        private async Task RefreshGrid()
        {
            try
            {
                List<Operational>? data = await _apiService.Operational.GetOperationalsAsync();

                if (data != null)
                {
                    OperationalList.DataSource = null;
                    OperationalList.DataSource = data;

                    OperationalList.Columns["Id"].HeaderText = "Id";
                    OperationalList.Columns["Name"].HeaderText = "Nama Operasional";
                    OperationalList.Columns["OperationalCost"].HeaderText = "Biaya Operasional";
                    OperationalList.Columns["OperationalDate"].HeaderText = "Tanggal";

                    if (OperationalList.Columns.Contains("TenantId"))
                        OperationalList.Columns["TenantId"].Visible = false;
                    if (OperationalList.Columns.Contains("Tenant"))
                        OperationalList.Columns["Tenant"].Visible = false;

                    SetupActionButtons();
                    OperationalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (OperationalList.Columns.Contains("BtnEdit")) OperationalList.Columns.Remove("BtnEdit");
            if (OperationalList.Columns.Contains("BtnHapus")) OperationalList.Columns.Remove("BtnHapus");

            OperationalList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            });

            OperationalList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "BtnHapus",
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
                OperationalList.Width = 1300;

                if (_saveDataType == "update")
                    AttemptFormFields(false);
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;
                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;
                OperationalList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = OperationalList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in OperationalList.Rows)
                totalHeight += row.Height;
            OperationalList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedOperational = null;
                OperationalDateTimePicker.Value = DateTime.Today;
                OperationalNameTextField.Text = "";
                OperationalCostTextField.Text = "";
            }
            else
            {
                OperationalDateTimePicker.Value = _selectedOperational?.OperationalDate ?? DateTime.Today;
                OperationalNameTextField.Text = _selectedOperational?.Name ?? "";
                OperationalCostTextField.Text = _selectedOperational?.OperationalCost ?? "";
            }
        }

        private async void operationalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (Operational)OperationalList.Rows[e.RowIndex].DataBoundItem;

            if (OperationalList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedOperational = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            if (OperationalList.Columns[e.ColumnIndex].Name == "BtnHapus")
            {
                ToggleForm(false);
                DialogResult dialog = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus data operasional {dataSelected.Name}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    ActionResponse<Operational> response = await _apiService.Operational.DeleteOperationalAsync(dataSelected.Id);
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
                SaveButton.Enabled = false;

                if (string.IsNullOrEmpty(OperationalNameTextField.Text))
                {
                    validationErrorMsg.Text = "Nama operasional tidak boleh kosong!";
                    return;
                }

                if (string.IsNullOrEmpty(OperationalCostTextField.Text))
                {
                    validationErrorMsg.Text = "Biaya operasional tidak boleh kosong!";
                    return;
                }

                ActionResponse<Operational> response;

                if (_saveDataType == "update" && _selectedOperational != null)
                {
                    _selectedOperational.OperationalDate = OperationalDateTimePicker.Value;
                    _selectedOperational.Name = OperationalNameTextField.Text;
                    _selectedOperational.OperationalCost = OperationalCostTextField.Text;
                    response = await _apiService.Operational.UpdateOperationalAsync(_selectedOperational.Id, _selectedOperational);
                }
                else
                {
                    Operational operationalBaru = new Operational
                    {
                        OperationalDate = OperationalDateTimePicker.Value,
                        Name = OperationalNameTextField.Text,
                        OperationalCost = OperationalCostTextField.Text
                    };
                    response = await _apiService.Operational.CreateOperationalAsync(operationalBaru);
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
                SaveButton.Enabled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _saveDataType = "create";
            ToggleForm(true);
        }
    }
}