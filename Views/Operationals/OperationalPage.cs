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
                    operationalList.DataSource = null;
                    operationalList.DataSource = data;

                    operationalList.Columns["Id"].HeaderText = "Id";
                    operationalList.Columns["Name"].HeaderText = "Nama Operasional";
                    operationalList.Columns["OperationalCost"].HeaderText = "Biaya Operasional";
                    operationalList.Columns["OperationalDate"].HeaderText = "Tanggal";

                    if (operationalList.Columns.Contains("TenantId"))
                        operationalList.Columns["TenantId"].Visible = false;
                    if (operationalList.Columns.Contains("Tenant"))
                        operationalList.Columns["Tenant"].Visible = false;

                    SetupActionButtons();
                    operationalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (operationalList.Columns.Contains("BtnEdit")) operationalList.Columns.Remove("BtnEdit");
            if (operationalList.Columns.Contains("BtnHapus")) operationalList.Columns.Remove("BtnHapus");

            operationalList.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            });

            operationalList.Columns.Add(new DataGridViewButtonColumn
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
                operationalList.Width = 1300;

                if (_saveDataType == "update")
                    AttemptFormFields(false);
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;
                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;
                operationalList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = operationalList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in operationalList.Rows)
                totalHeight += row.Height;
            operationalList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedOperational = null;
                dtpOperationalDate.Value = DateTime.Today;
                txtName.Text = "";
                txtCost.Text = "";
            }
            else
            {
                dtpOperationalDate.Value = _selectedOperational?.OperationalDate ?? DateTime.Today;
                txtName.Text = _selectedOperational?.Name ?? "";
                txtCost.Text = _selectedOperational?.OperationalCost ?? "";
            }
        }

        private async void operationalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (Operational)operationalList.Rows[e.RowIndex].DataBoundItem;

            if (operationalList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedOperational = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            if (operationalList.Columns[e.ColumnIndex].Name == "BtnHapus")
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
                btnSave.Enabled = false;

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    validationErrorMsg.Text = "Nama operasional tidak boleh kosong!";
                    return;
                }

                if (string.IsNullOrEmpty(txtCost.Text))
                {
                    validationErrorMsg.Text = "Biaya operasional tidak boleh kosong!";
                    return;
                }

                ActionResponse<Operational> response;

                if (_saveDataType == "update" && _selectedOperational != null)
                {
                    _selectedOperational.OperationalDate = dtpOperationalDate.Value;
                    _selectedOperational.Name = txtName.Text;
                    _selectedOperational.OperationalCost = txtCost.Text;
                    response = await _apiService.Operational.UpdateOperationalAsync(_selectedOperational.Id, _selectedOperational);
                }
                else
                {
                    Operational operationalBaru = new Operational
                    {
                        OperationalDate = dtpOperationalDate.Value,
                        Name = txtName.Text,
                        OperationalCost = txtCost.Text
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