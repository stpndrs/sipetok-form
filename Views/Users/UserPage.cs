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
            this.UsersList.CellFormatting += UsersList_CellFormatting;
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
                    UsersList.DataSource = null;
                    UsersList.DataSource = data;

                    // Atur Susunan Header Utama GUI
                    UsersList.Columns["Id"].HeaderText = "Id";
                    UsersList.Columns["Username"].HeaderText = "Username";
                    UsersList.Columns["Email"].HeaderText = "Email";
                    UsersList.Columns["Role"].HeaderText = "Role";
                    UsersList.Columns["IsActive"].HeaderText = "IsActive";

                    SetupActionButtons();

                    UsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    AdjustGridHeight();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Gagal memuat data dari API: {ex.Message}", "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (UsersList.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                if (e.Value is Role roleObj)
                {
                    Debug.WriteLine(roleObj);
                    e.Value = roleObj.Label;
                    e.FormattingApplied = true;
                }
            }

            if (UsersList.Columns[e.ColumnIndex].Name == "IsActive" && e.Value != null)
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
            if (UsersList.Columns.Contains("EditBtn")) UsersList.Columns.Remove("EditBtn");
            if (UsersList.Columns.Contains("DeleteBtn")) UsersList.Columns.Remove("DeleteBtn");

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "EditBtn",
                HeaderText = "Aksi Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            UsersList.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn
            {
                Name = "DeleteBtn",
                HeaderText = "Aksi Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            UsersList.Columns.Add(btnHapus);
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

                UsersList.Width = 1300;

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

                UsersList.Width = 1920;

                AttemptFormFields(true);
                _saveDataType = null;
            }
        }

        private void AdjustGridHeight()
        {
            int totalHeight = UsersList.ColumnHeadersHeight;
            foreach (DataGridViewRow row in UsersList.Rows)
            {
                totalHeight += row.Height;
            }
            UsersList.Height = totalHeight + 4;
        }

        public void AttemptFormFields(bool clear)
        {
            List<ItemMenu> listRole = new List<ItemMenu>
            {
                new ItemMenu(1, "Admin"),
                new ItemMenu(2, "Tenant")
            };
            RoleComboBox.DataSource = listRole;
            RoleComboBox.DisplayMember = "Label";
            RoleComboBox.ValueMember = "Value";

            ValidationErrorMsgLabel.Text = "";

            if (clear)
            {
                _selectedUser = null;
                UsernameTextField.Text = "";
                PasswordTextField.Text = "";
                EmailTextField.Text = "";
                RoleComboBox.SelectedIndex = -1;
            }
            else
            {
                Debug.WriteLine(_selectedUser?.Username);
                UsernameTextField.Text = _selectedUser?.Username;
                EmailTextField.Text = _selectedUser?.Email;
                RoleComboBox.Text = _selectedUser?.Role.Label;
            }
        }

        private async void UsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataSelected = (User)UsersList.Rows[e.RowIndex].DataBoundItem;

            // Aksi Edit
            if (UsersList.Columns[e.ColumnIndex].Name == "EditBtn")
            {
                _selectedUser = dataSelected;
                _saveDataType = "update";
                ToggleForm(true);
            }

            // Aksi Hapus
            if (UsersList.Columns[e.ColumnIndex].Name == "DeleteBtn")
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

        private void HandleClickMenu(object sender, EventArgs e)
        {
            MenuHelper.HandleClick(sender, e, this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ToggleForm(false);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _saveDataType = "create";
            ToggleForm(true);
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveBtn.Enabled = false;
                ActionResponse<User> response = new ActionResponse<User>();
                if (_saveDataType == "update")
                {
                    if (PasswordTextField.Text != "")
                    {
                        _selectedUser.Password = PasswordTextField.Text;
                    }
                    _selectedUser.Username = UsernameTextField.Text;
                    _selectedUser.Email = EmailTextField.Text;
                    _selectedUser.Role = new Role { Key = (int)RoleComboBox?.SelectedValue, Label = RoleComboBox.Text };
                    _selectedUser.IsActive = new IsActive { Key = 1, Label = "ACTIVE" };
                    response = await _apiService.User.UpdateUserAsync(_selectedUser.Id, _selectedUser);
                }
                else if (_saveDataType == "create")
                {
                    User userBaru = new User
                    {
                        Username = UsernameTextField.Text,
                        Email = EmailTextField.Text,
                        Password = PasswordTextField.Text,
                        Role = new Role { Key = (int)RoleComboBox?.SelectedValue, Label = RoleComboBox.Text },
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
                    ValidationHelper.ShowValidation(response, ValidationErrorMsgLabel);
                    MessageBox.Show(response.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SaveBtn.Enabled = true;
            }
        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }
    }
}
