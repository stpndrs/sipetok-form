using ClosedXML.Excel;
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

namespace sipetok_form.Views.Tenant
{
    public partial class TenantPage : Form
    {
        // Mengubah tipe data dari User menjadi Tenant
        private sipetok_api.Models.Tenant? _selectedTenant = null;
        private string _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public TenantPage()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
            this.tenantsList.CellFormatting += tenantsList_CellFormatting; 
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
                // Memanggil endpoint Tenant dari ApiService
                List<sipetok_api.Models.Tenant>? data = await _apiService.Tenant.GetTenantsAsync();

                if (data != null)
                {
                    tenantsList.DataSource = null;
                    tenantsList.DataSource = data;

                    // Mengatur Susunan Header Utama GUI sesuai properti Tenant
                    tenantsList.Columns["Id"].HeaderText = "Id Tenant";
                    tenantsList.Columns["Name"].HeaderText = "Nama Tenant";
                    tenantsList.Columns["Address"].HeaderText = "Alamat";
                    tenantsList.Columns["PhoneNumber"].HeaderText = "No. Telepon";

                    // Trik utama: Ganti kolom CheckBox otomatis menjadi kolom teks biasa
                    if (tenantsList.Columns.Contains("IsValid"))
                    {
                        // Simpan posisi urutan kolomnya biar tidak lompat ke paling kanan
                        int displayIndex = tenantsList.Columns["IsValid"].DisplayIndex;

                        // Hapus kolom bawaan yang berbentuk CheckBox
                        tenantsList.Columns.Remove("IsValid");

                        // Buat kolom teks baru untuk menggantikannya
                        DataGridViewTextBoxColumn txtColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "IsValid",
                            DataPropertyName = "IsValid", 
                            HeaderText = "Status Validasi"
                        };

                        tenantsList.Columns.Add(txtColumn);
                        txtColumn.DisplayIndex = displayIndex;
                    }

                    // Menyembunyikan kolom relasi agar tidak muncul mentah-mentah di grid
                    if (tenantsList.Columns.Contains("UserId")) tenantsList.Columns["UserId"].Visible = false;
                    if (tenantsList.Columns.Contains("User")) tenantsList.Columns["User"].Visible = false;

                    SetupActionButtons();

                    tenantsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Gagal memuat data tenant dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tenantsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Memastikan baris data valid dan nilainya tidak null
            if (e.RowIndex < 0 || e.Value == null) return;

            // Menargetkan kolom IsValid untuk diubah format tampilannya
            if (tenantsList.Columns[e.ColumnIndex].Name == "IsValid")
            {
                if (e.Value is bool isValid)
                {
                    // Jika true menjadi "Active", jika false menjadi "Inactive"
                    e.Value = isValid ? "Valid" : "Invalid";

                    // Memberitahu DataGridView bahwa kita sudah memformat nilainya
                    e.FormattingApplied = true;
                }
            }
        }

        private void SetupActionButtons()
        {
            if (tenantsList.Columns.Contains("BtnEdit")) tenantsList.Columns.Remove("BtnEdit");
            if (tenantsList.Columns.Contains("BtnHapus")) tenantsList.Columns.Remove("BtnHapus");

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            tenantsList.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn
            {
                Name = "BtnHapus",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            tenantsList.Columns.Add(btnHapus);
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

                tenantsList.Width = 1300;

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

                tenantsList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = tenantsList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in tenantsList.Rows)
            {
                totalHeight += row.Height;
            }
            tenantsList.Height = totalHeight + 4;
        }

        public async void AttemptFormFields(bool clear)
        {

            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedTenant = null;
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                chkIsValid.Checked = false;
            }
            else
            {
                txtName.Text = _selectedTenant?.Name;
                txtAddress.Text = _selectedTenant?.Address;
                txtPhoneNumber.Text = _selectedTenant?.PhoneNumber;
                chkIsValid.Checked = _selectedTenant?.IsValid ?? false;
            }
        }

        private async void tenantsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (sipetok_api.Models.Tenant)tenantsList.Rows[e.RowIndex].DataBoundItem;

            // Aksi Edit
            if (tenantsList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedTenant = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            // Aksi Hapus
            if (tenantsList.Columns[e.ColumnIndex].Name == "BtnHapus")
            {
                ToggleForm(false);
                DialogResult dialog = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus tenant {dataSelected.Name} dari server?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    // Memanggil endpoint delete tenant
                    ActionResponse<sipetok_api.Models.Tenant> response = await _apiService.Tenant.DeleteTenantAsync(dataSelected.Id);

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
                ActionResponse<sipetok_api.Models.Tenant> response = new ActionResponse<sipetok_api.Models.Tenant>();

                if (_saveDataType == "update")
                {
                    _selectedTenant.Name = txtName.Text;
                    _selectedTenant.Address = txtAddress.Text;
                    _selectedTenant.PhoneNumber = txtPhoneNumber.Text;
                    _selectedTenant.IsValid = chkIsValid.Checked;

                    Debug.Write(chkIsValid.Checked);

                    response = await _apiService.Tenant.UpdateTenantAsync(_selectedTenant.Id, _selectedTenant);
                }
                else if (_saveDataType == "create")
                {
                    sipetok_api.Models.Tenant tenantBaru = new sipetok_api.Models.Tenant
                    {
                        Name = txtName.Text,
                        Address = txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        IsValid = chkIsValid.Checked,
                    };

                    response = await _apiService.Tenant.CreateTenantAsync(tenantBaru);
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