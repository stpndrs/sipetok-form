using ClosedXML.Excel;
using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.request;
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
                List<sipetok_api.Models.Tenant>? data = await _apiService.Tenant.GetTenantsAsync();

                if (data != null)
                {
                    tenantsList.DataSource = null;
                    tenantsList.DataSource = data;

                    tenantsList.Columns["Id"].HeaderText = "Id Tenant";
                    tenantsList.Columns["Name"].HeaderText = "Nama Tenant";
                    tenantsList.Columns["Address"].HeaderText = "Alamat";
                    tenantsList.Columns["PhoneNumber"].HeaderText = "No. Telepon";

                    if (tenantsList.Columns.Contains("IsValid"))
                    {
                        int displayIndex = tenantsList.Columns["IsValid"].DisplayIndex;
                        tenantsList.Columns.Remove("IsValid");

                        DataGridViewTextBoxColumn txtColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "IsValid",
                            DataPropertyName = "IsValid",
                            HeaderText = "Status Validasi"
                        };

                        tenantsList.Columns.Add(txtColumn);
                        txtColumn.DisplayIndex = displayIndex;
                    }

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
            if (e.RowIndex < 0 || e.Value == null) return;

            if (tenantsList.Columns[e.ColumnIndex].Name == "IsValid")
            {
                if (e.Value is bool isValid)
                {
                    e.Value = isValid ? "Valid" : "Invalid";
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

        // PERBAIKAN 1: Logika penempatan struktur if-else untuk menyembunyikan/menampilkan field
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
                    // Sembunyikan field Akun User saat Edit Tenant
                    flowLayoutPanel3.Visible = false;
                    flowLayoutPanel7.Visible = false;
                    flowLayoutPanel8.Visible = false;
                    flowLayoutPanel2.Visible = true;
                    AttemptFormFields(false);
                }
                else if (_saveDataType == "create")
                {
                    // Pastikan field Akun User selalu muncul saat Tambah Data Baru
                    flowLayoutPanel3.Visible = true;
                    flowLayoutPanel7.Visible = true;
                    flowLayoutPanel8.Visible = true;
                    flowLayoutPanel2.Visible = false;


                    AttemptFormFields(true); // Bersihkan form field agar kosong
                }
            }
            else
            {
                // Bagian ini sekarang akan selalu berjalan saat form ditutup (Batal/Sukses Simpan)
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

        public void AttemptFormFields(bool clear)
        {
            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedTenant = null;
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
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

            if (tenantsList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedTenant = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

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

                    response = await _apiService.Tenant.UpdateTenantAsync(_selectedTenant.Id, _selectedTenant);
                }
                else if (_saveDataType == "create")
                {
                    // PERBAIKAN 2: Menambahkan instansiasi objek 'new User' secara eksplisit
                    var newTenant = new sipetok_api.Models.Tenant
                    {
                        Name = txtName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Address = txtAddress.Text,
                        User = new User
                        {
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            Email = txtEmail.Text,
                        }
                    };

                    response = await _apiService.Tenant.CreateTenantAsync(newTenant);
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