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

namespace sipetok_form.Views.Tenants
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
            this.TenantList.CellFormatting += TenantList_CellFormatting;
            this.TenantList.CellContentClick += TenantList_CellContentClick;
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
                    TenantList.DataSource = null;
                    TenantList.DataSource = data;

                    // Atur Susunan Header Utama GUI
                    TenantList.Columns["Id"].HeaderText = "Id Tenant";
                    TenantList.Columns["Name"].HeaderText = "Nama Tenant";
                    TenantList.Columns["Address"].HeaderText = "Alamat";
                    TenantList.Columns["PhoneNumber"].HeaderText = "No. Telepon";

                    if (TenantList.Columns.Contains("IsValid"))
                    {
                        int displayIndex = TenantList.Columns["IsValid"].DisplayIndex;
                        TenantList.Columns.Remove("IsValid");

                        DataGridViewTextBoxColumn txtColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "IsValid",
                            DataPropertyName = "IsValid",
                            HeaderText = "Status Validasi"
                        };

                        TenantList.Columns.Add(txtColumn);
                        txtColumn.DisplayIndex = displayIndex;
                    }

                    if (TenantList.Columns.Contains("UserId")) TenantList.Columns["UserId"].Visible = false;
                    if (TenantList.Columns.Contains("User")) TenantList.Columns["User"].Visible = false;

                    SetupActionButtons();

                    TenantList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Gagal memuat data tenant dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TenantList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (TenantList.Columns[e.ColumnIndex].Name == "IsValid")
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
            if (TenantList.Columns.Contains("EditBtn")) TenantList.Columns.Remove("EditBtn");
            if (TenantList.Columns.Contains("DeleteBtn")) TenantList.Columns.Remove("DeleteBtn");

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "EditBtn",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            TenantList.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn
            {
                Name = "DeleteBtn",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            TenantList.Columns.Add(btnHapus);
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

                TenantList.Width = 1300;

                if (_saveDataType == "update")
                {
                    UsernameInputGroup.Visible = false;
                    PasswordInputGroup.Visible = false;
                    EmailInputGroup.Visible = false;
                    ValidationInputGroup.Visible = true;
                    AttemptFormFields(false);
                }
                else if (_saveDataType == "create")
                {
                    UsernameInputGroup.Visible = true;
                    PasswordInputGroup.Visible = true;
                    EmailInputGroup.Visible = true;
                    ValidationInputGroup.Visible = false;
                    AttemptFormFields(true);
                }
            }
            else
            {
                columnStyles[0].SizeType = SizeType.Percent;
                columnStyles[0].Width = 100;

                columnStyles[1].SizeType = SizeType.Percent;
                columnStyles[1].Width = 0;

                TenantList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = TenantList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in TenantList.Rows)
            {
                totalHeight += row.Height;
            }
            TenantList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            ValidationErrorMsg.Text = "";

            if (clear)
            {
                _selectedTenant = null;
                NamaTextField.Text = "";
                AddressTextField.Text = "";
                PhoneNumberTextField.Text = "";
                UsernameTextField.Text = "";
                PasswordTextField.Text = "";
                EmailTextField.Text = "";
                IsValidCheckBox.Checked = false;
            }
            else
            {
                NamaTextField.Text = _selectedTenant?.Name;
                AddressTextField.Text = _selectedTenant?.Address;
                PhoneNumberTextField.Text = _selectedTenant?.PhoneNumber;
                IsValidCheckBox.Checked = _selectedTenant?.IsValid ?? false;
            }
        }

        private async void TenantList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (sipetok_api.Models.Tenant)TenantList.Rows[e.RowIndex].DataBoundItem;

            if (TenantList.Columns[e.ColumnIndex].Name == "EditBtn")
            {
                _selectedTenant = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            if (TenantList.Columns[e.ColumnIndex].Name == "DeleteBtn")
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

        private void HandleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ToggleForm(false);
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveButton.Enabled = false;
                ActionResponse<sipetok_api.Models.Tenant> response = new ActionResponse<sipetok_api.Models.Tenant>();

                if (_saveDataType == "update")
                {
                    _selectedTenant.Name = NamaTextField.Text;
                    _selectedTenant.Address = AddressTextField.Text;
                    _selectedTenant.PhoneNumber = PhoneNumberTextField.Text;
                    _selectedTenant.IsValid = IsValidCheckBox.Checked;

                    response = await _apiService.Tenant.UpdateTenantAsync(_selectedTenant.Id, _selectedTenant);
                }
                else if (_saveDataType == "create")
                {
                    var newTenant = new sipetok_api.Models.Tenant
                    {
                        Name = NamaTextField.Text,
                        PhoneNumber = PhoneNumberTextField.Text,
                        Address = AddressTextField.Text,
                        User = new User
                        {
                            Username = UsernameTextField.Text,
                            Password = PasswordTextField.Text,
                            Email = EmailTextField.Text,
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
                    ValidationHelper.ShowValidation(response, ValidationErrorMsg);
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
    }
}