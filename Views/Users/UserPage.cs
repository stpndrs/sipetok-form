using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.response;
using sipetok_form.Services;
using sipetok_form.Views.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sipetok_form.Views.Users
{
    public partial class UserPage : Form
    {
        private User? _selectedUser = null;
        private string _saveDataType = null;
        private readonly ApiService _apiService = new ApiService();

        public UserPage()
        {
            InitializeComponent();
            this.Load += FormMain_Load;
            this.usersList.CellFormatting += usersList_CellFormatting;
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
                List<User>? data = await _apiService.User.GetUsersAsync();

                if (data != null)
                {
                    usersList.DataSource = null;
                    usersList.DataSource = data;

                    // Atur Susunan Header Utama GUI
                    usersList.Columns["Id"].HeaderText = "Id";
                    usersList.Columns["Username"].HeaderText = "Username";
                    usersList.Columns["Email"].HeaderText = "Email";
                    usersList.Columns["Role"].HeaderText = "Role";
                    usersList.Columns["IsActive"].HeaderText = "IsActive";

                    SetupActionButtons();

                    usersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Gagal memuat data dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (usersList.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                if (e.Value is Role roleObj)
                {
                    Debug.WriteLine(roleObj);
                    e.Value = roleObj.Label;
                    e.FormattingApplied = true;
                }
            }

            if (usersList.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
            {
                if (e.Value is IsActive IsActiveObj)
                {
                    e.Value = IsActiveObj.Label;
                    e.FormattingApplied = true;
                }
            }
        }

        private void SetupActionButtons()
        {
            if (usersList.Columns.Contains("BtnEdit")) usersList.Columns.Remove("BtnEdit");
            if (usersList.Columns.Contains("BtnHapus")) usersList.Columns.Remove("BtnHapus");

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "BtnEdit",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn
            {
                Name = "BtnHapus",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            usersList.Columns.Add(btnHapus);
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

                usersList.Width = 1300;

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

                usersList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = usersList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in usersList.Rows)
            {
                totalHeight += row.Height;
            }
            usersList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            List<ItemMenu> listRole = new List<ItemMenu>
            {
                new ItemMenu(1, "Admin"),
                new ItemMenu(2, "Tenant")
            };
            cbbRole.DataSource = listRole;
            cbbRole.DisplayMember = "Label";
            cbbRole.ValueMember = "Value";

            validationErrorMsg.Text = "";

            if (clear)
            {
                _selectedUser = null;
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                cbbRole.SelectedIndex = -1;
            }
            else
            {
                Debug.WriteLine(_selectedUser?.Username);
                txtUsername.Text = _selectedUser?.Username;
                txtEmail.Text = _selectedUser?.Email;
                cbbRole.Text = _selectedUser?.Role.Label;
            }
        }

        private async void usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (User)usersList.Rows[e.RowIndex].DataBoundItem;

            // Aksi Edit
            if (usersList.Columns[e.ColumnIndex].Name == "BtnEdit")
            {
                _selectedUser = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            // Aksi Hapus
            if (usersList.Columns[e.ColumnIndex].Name == "BtnHapus")
            {
                ToggleForm(false);
                DialogResult dialog = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus {dataSelected.Username} dari server?",
                    "Konfirmasi Hapus Endpoint",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    ActionResponse<User> response = await _apiService.User.DeleteUserAsync(dataSelected.Id);

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
                ActionResponse<User> response = new ActionResponse<User>();
                if (_saveDataType == "update")
                {
                    if (txtPassword.Text != "")
                    {
                        _selectedUser.Password = txtPassword.Text;
                    }
                    response = await _apiService.User.UpdateUserAsync(_selectedUser.Id, _selectedUser);
                }
                else if (_saveDataType == "create")
                {
                    User userBaru = new User
                    {
                        Username = txtUsername.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Role = new Role { Key = (int)cbbRole?.SelectedValue, Label = cbbRole.Text },
                        IsActive = new IsActive { Key = 1, Label = "ACTIVE" }
                    };

                    response = await _apiService.User.CreateUserAsync(userBaru);
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
