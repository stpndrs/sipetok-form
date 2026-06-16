namespace sipetok_form.Views.Users
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PageContainer = new TableLayoutPanel();
            MenuContainer = new MenuStrip();
            DashboardMenu = new ToolStripMenuItem();
            UserMenu = new ToolStripMenuItem();
            TenantMenu = new ToolStripMenuItem();
            EggCategoryMenu = new ToolStripMenuItem();
            StockMenu = new ToolStripMenuItem();
            TransactionMenu = new ToolStripMenuItem();
            OperationalMenu = new ToolStripMenuItem();
            ReportMenu = new ToolStripMenuItem();
            LogoutMenu = new ToolStripMenuItem();
            PageBodyContainer = new TableLayoutPanel();
            ListContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            AddBtn = new Button();
            UsersList = new DataGridView();
            FormContainer = new FlowLayoutPanel();
            FormLabel = new Label();
            ValidationErrorMsgLabel = new Label();
            UsernameInputGroup = new FlowLayoutPanel();
            UsernameLabel = new Label();
            UsernameTextField = new TextBox();
            PasswordInputGroup = new FlowLayoutPanel();
            PasswordLabel = new Label();
            PasswordTextField = new TextBox();
            EmailInputGroup = new FlowLayoutPanel();
            EmailLabel = new Label();
            EmailTextField = new TextBox();
            RoleInputGroup = new FlowLayoutPanel();
            RoleLabel = new Label();
            RoleComboBox = new ComboBox();
            SaveButton = new Button();
            CancelButton = new Button();
            PageContainer.SuspendLayout();
            MenuContainer.SuspendLayout();
            PageBodyContainer.SuspendLayout();
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersList).BeginInit();
            FormContainer.SuspendLayout();
            UsernameInputGroup.SuspendLayout();
            PasswordInputGroup.SuspendLayout();
            EmailInputGroup.SuspendLayout();
            RoleInputGroup.SuspendLayout();
            SuspendLayout();
            // 
            // PageContainer
            // 
            PageContainer.ColumnCount = 1;
            PageContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PageContainer.Controls.Add(MenuContainer, 0, 0);
            PageContainer.Controls.Add(PageBodyContainer, 0, 1);
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Location = new Point(0, 0);
            PageContainer.Name = "PageContainer";
            PageContainer.RowCount = 2;
            PageContainer.RowStyles.Add(new RowStyle());
            PageContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PageContainer.Size = new Size(1902, 1033);
            PageContainer.TabIndex = 0;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ControlLight;
            MenuContainer.Dock = DockStyle.Fill;
            MenuContainer.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuContainer.ImageScalingSize = new Size(20, 20);
            MenuContainer.Items.AddRange(new ToolStripItem[] { DashboardMenu, UserMenu, TenantMenu, EggCategoryMenu, StockMenu, TransactionMenu, OperationalMenu, ReportMenu, LogoutMenu });
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(6, 3, 0, 3);
            MenuContainer.Size = new Size(1902, 32);
            MenuContainer.TabIndex = 6;
            MenuContainer.Text = "menuStrip1";
            // 
            // DashboardMenu
            // 
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(111, 26);
            DashboardMenu.Text = "Dashboard";
            DashboardMenu.Click += HandleClickMenu;
            // 
            // UserMenu
            // 
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(104, 26);
            UserMenu.Text = "Pengguna";
            UserMenu.Click += HandleClickMenu;
            // 
            // TenantMenu
            // 
            TenantMenu.Name = "TenantMenu";
            TenantMenu.Size = new Size(80, 26);
            TenantMenu.Text = "Tenant";
            TenantMenu.Click += HandleClickMenu;
            // 
            // EggCategoryMenu
            // 
            EggCategoryMenu.Name = "EggCategoryMenu";
            EggCategoryMenu.Size = new Size(136, 26);
            EggCategoryMenu.Text = "Kategori Telur";
            EggCategoryMenu.Click += HandleClickMenu;
            // 
            // StockMenu
            // 
            StockMenu.Name = "StockMenu";
            StockMenu.Size = new Size(138, 26);
            StockMenu.Text = "Stok & Inventori";
            StockMenu.Click += HandleClickMenu;
            // 
            // TransactionMenu
            // 
            TransactionMenu.Name = "TransactionMenu";
            TransactionMenu.Size = new Size(103, 26);
            TransactionMenu.Text = "Transaksi";
            TransactionMenu.Click += HandleClickMenu;
            // 
            // OperationalMenu
            // 
            OperationalMenu.Name = "OperationalMenu";
            OperationalMenu.Size = new Size(120, 26);
            OperationalMenu.Text = "Operasional";
            OperationalMenu.Click += HandleClickMenu;
            // 
            // ReportMenu
            // 
            ReportMenu.Name = "ReportMenu";
            ReportMenu.Size = new Size(90, 26);
            ReportMenu.Text = "Laporan";
            ReportMenu.Click += HandleClickMenu;
            // 
            // LogoutMenu
            // 
            LogoutMenu.Name = "LogoutMenu";
            LogoutMenu.Size = new Size(80, 26);
            LogoutMenu.Text = "Logout";
            LogoutMenu.Click += HandleClickMenu;
            // 
            // PageBodyContainer
            // 
            PageBodyContainer.AutoSize = true;
            PageBodyContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PageBodyContainer.ColumnCount = 2;
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle());
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle());
            PageBodyContainer.Controls.Add(ListContainer, 0, 0);
            PageBodyContainer.Controls.Add(FormContainer, 1, 0);
            PageBodyContainer.Location = new Point(3, 35);
            PageBodyContainer.Name = "PageBodyContainer";
            PageBodyContainer.RowCount = 1;
            PageBodyContainer.RowStyles.Add(new RowStyle());
            PageBodyContainer.Size = new Size(1859, 930);
            PageBodyContainer.TabIndex = 7;
            // 
            // ListContainer
            // 
            ListContainer.AutoSize = true;
            ListContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListContainer.Controls.Add(PageLabel);
            ListContainer.Controls.Add(AddBtn);
            ListContainer.Controls.Add(UsersList);
            ListContainer.FlowDirection = FlowDirection.TopDown;
            ListContainer.Location = new Point(3, 3);
            ListContainer.Name = "ListContainer";
            ListContainer.Size = new Size(1362, 924);
            ListContainer.TabIndex = 6;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ControlText;
            PageLabel.Location = new Point(3, 0);
            PageLabel.Margin = new Padding(3, 0, 3, 15);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(239, 36);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Daftar Pengguna";
            // 
            // AddBtn
            // 
            AddBtn.AutoSize = true;
            AddBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(3, 54);
            AddBtn.Margin = new Padding(3, 3, 3, 29);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(181, 48);
            AddBtn.TabIndex = 17;
            AddBtn.Text = "Tambah Data";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddButton_Click;
            // 
            // UsersList
            // 
            UsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersList.Location = new Point(3, 134);
            UsersList.Margin = new Padding(3, 3, 50, 3);
            UsersList.MaximumSize = new Size(1793, 787);
            UsersList.Name = "UsersList";
            UsersList.RowHeadersWidth = 51;
            UsersList.Size = new Size(1309, 787);
            UsersList.TabIndex = 3;
            UsersList.CellContentClick += UsersList_CellContentClick;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(FormLabel);
            FormContainer.Controls.Add(ValidationErrorMsgLabel);
            FormContainer.Controls.Add(UsernameInputGroup);
            FormContainer.Controls.Add(PasswordInputGroup);
            FormContainer.Controls.Add(EmailInputGroup);
            FormContainer.Controls.Add(RoleInputGroup);
            FormContainer.Controls.Add(SaveButton);
            FormContainer.Controls.Add(CancelButton);
            FormContainer.FlowDirection = FlowDirection.TopDown;
            FormContainer.Location = new Point(1371, 3);
            FormContainer.Name = "FormContainer";
            FormContainer.Padding = new Padding(30, 29, 30, 29);
            FormContainer.Size = new Size(485, 912);
            FormContainer.TabIndex = 5;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormLabel.ForeColor = SystemColors.ControlText;
            FormLabel.Location = new Point(33, 29);
            FormLabel.Margin = new Padding(3, 0, 3, 15);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(312, 36);
            FormLabel.TabIndex = 1;
            FormLabel.Text = "Kelola Data Pengguna";
            // 
            // ValidationErrorMsgLabel
            // 
            ValidationErrorMsgLabel.AutoSize = true;
            ValidationErrorMsgLabel.BackColor = SystemColors.Control;
            ValidationErrorMsgLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidationErrorMsgLabel.ForeColor = Color.Red;
            ValidationErrorMsgLabel.Location = new Point(33, 80);
            ValidationErrorMsgLabel.Margin = new Padding(3, 0, 3, 40);
            ValidationErrorMsgLabel.Name = "ValidationErrorMsgLabel";
            ValidationErrorMsgLabel.Size = new Size(0, 20);
            ValidationErrorMsgLabel.TabIndex = 15;
            // 
            // UsernameInputGroup
            // 
            UsernameInputGroup.AutoSize = true;
            UsernameInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsernameInputGroup.BorderStyle = BorderStyle.FixedSingle;
            UsernameInputGroup.Controls.Add(UsernameLabel);
            UsernameInputGroup.Controls.Add(UsernameTextField);
            UsernameInputGroup.Dock = DockStyle.Fill;
            UsernameInputGroup.FlowDirection = FlowDirection.TopDown;
            UsernameInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            UsernameInputGroup.Location = new Point(30, 140);
            UsernameInputGroup.Margin = new Padding(0, 0, 0, 40);
            UsernameInputGroup.Name = "UsernameInputGroup";
            UsernameInputGroup.Padding = new Padding(10, 11, 10, 11);
            UsernameInputGroup.Size = new Size(440, 72);
            UsernameInputGroup.TabIndex = 11;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            UsernameLabel.Location = new Point(13, 11);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(86, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // UsernameTextField
            // 
            UsernameTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            UsernameTextField.Location = new Point(13, 34);
            UsernameTextField.Name = "UsernameTextField";
            UsernameTextField.Size = new Size(406, 22);
            UsernameTextField.TabIndex = 2;
            // 
            // PasswordInputGroup
            // 
            PasswordInputGroup.AutoSize = true;
            PasswordInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PasswordInputGroup.BorderStyle = BorderStyle.FixedSingle;
            PasswordInputGroup.Controls.Add(PasswordLabel);
            PasswordInputGroup.Controls.Add(PasswordTextField);
            PasswordInputGroup.Dock = DockStyle.Fill;
            PasswordInputGroup.FlowDirection = FlowDirection.TopDown;
            PasswordInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            PasswordInputGroup.Location = new Point(30, 252);
            PasswordInputGroup.Margin = new Padding(0, 0, 0, 40);
            PasswordInputGroup.Name = "PasswordInputGroup";
            PasswordInputGroup.Padding = new Padding(10, 11, 10, 11);
            PasswordInputGroup.Size = new Size(440, 72);
            PasswordInputGroup.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            PasswordLabel.Location = new Point(13, 11);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(83, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextField
            // 
            PasswordTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            PasswordTextField.Location = new Point(13, 34);
            PasswordTextField.Name = "PasswordTextField";
            PasswordTextField.Size = new Size(406, 22);
            PasswordTextField.TabIndex = 3;
            // 
            // EmailInputGroup
            // 
            EmailInputGroup.AutoSize = true;
            EmailInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EmailInputGroup.BorderStyle = BorderStyle.FixedSingle;
            EmailInputGroup.Controls.Add(EmailLabel);
            EmailInputGroup.Controls.Add(EmailTextField);
            EmailInputGroup.Dock = DockStyle.Fill;
            EmailInputGroup.FlowDirection = FlowDirection.TopDown;
            EmailInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            EmailInputGroup.Location = new Point(30, 364);
            EmailInputGroup.Margin = new Padding(0, 0, 0, 40);
            EmailInputGroup.Name = "EmailInputGroup";
            EmailInputGroup.Padding = new Padding(10, 11, 10, 11);
            EmailInputGroup.Size = new Size(440, 72);
            EmailInputGroup.TabIndex = 12;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            EmailLabel.Location = new Point(13, 11);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(51, 20);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "Email";
            // 
            // EmailTextField
            // 
            EmailTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            EmailTextField.Location = new Point(13, 34);
            EmailTextField.Name = "EmailTextField";
            EmailTextField.Size = new Size(406, 22);
            EmailTextField.TabIndex = 2;
            // 
            // RoleInputGroup
            // 
            RoleInputGroup.AutoSize = true;
            RoleInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RoleInputGroup.BorderStyle = BorderStyle.FixedSingle;
            RoleInputGroup.Controls.Add(RoleLabel);
            RoleInputGroup.Controls.Add(RoleComboBox);
            RoleInputGroup.Dock = DockStyle.Fill;
            RoleInputGroup.FlowDirection = FlowDirection.TopDown;
            RoleInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            RoleInputGroup.Location = new Point(30, 476);
            RoleInputGroup.Margin = new Padding(0, 0, 0, 40);
            RoleInputGroup.Name = "RoleInputGroup";
            RoleInputGroup.Padding = new Padding(10, 11, 10, 11);
            RoleInputGroup.Size = new Size(440, 74);
            RoleInputGroup.TabIndex = 13;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            RoleLabel.Location = new Point(13, 11);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(122, 20);
            RoleLabel.TabIndex = 1;
            RoleLabel.Text = "Role Pengguna";
            // 
            // RoleComboBox
            // 
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "Admin", "Tenant" });
            RoleComboBox.Location = new Point(13, 34);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(406, 24);
            RoleComboBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(33, 593);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(434, 48);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Simpan";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(33, 647);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(434, 48);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Batalkan";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(PageContainer);
            Name = "UserPage";
            Text = "UserPage";
            WindowState = FormWindowState.Maximized;
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            PageBodyContainer.ResumeLayout(false);
            PageBodyContainer.PerformLayout();
            ListContainer.ResumeLayout(false);
            ListContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersList).EndInit();
            FormContainer.ResumeLayout(false);
            FormContainer.PerformLayout();
            UsernameInputGroup.ResumeLayout(false);
            UsernameInputGroup.PerformLayout();
            PasswordInputGroup.ResumeLayout(false);
            PasswordInputGroup.PerformLayout();
            EmailInputGroup.ResumeLayout(false);
            EmailInputGroup.PerformLayout();
            RoleInputGroup.ResumeLayout(false);
            RoleInputGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PageContainer;
        private MenuStrip MenuContainer;
        private ToolStripMenuItem DashboardMenu;
        private ToolStripMenuItem EggCategoryMenu;
        private ToolStripMenuItem StockMenu;
        private ToolStripMenuItem TransactionMenu;
        private ToolStripMenuItem OperationalMenu;
        private ToolStripMenuItem ReportMenu;
        private ToolStripMenuItem LogoutMenu;
        private TableLayoutPanel PageBodyContainer;
        private FlowLayoutPanel FormContainer;
        private Label FormLabel;
        private Label ValidationErrorMsgLabel;
        private FlowLayoutPanel UsernameInputGroup;
        private Label UsernameLabel;
        private TextBox UsernameTextField;
        private FlowLayoutPanel PasswordInputGroup;
        private Label PasswordLabel;
        private TextBox PasswordTextField;
        private FlowLayoutPanel EmailInputGroup;
        private Label EmailLabel;
        private TextBox EmailTextField;
        private FlowLayoutPanel RoleInputGroup;
        private Label RoleLabel;
        private ComboBox RoleComboBox;
        private Button SaveButton;
        private FlowLayoutPanel ListContainer;
        private Label PageLabel;
        private DataGridView UsersList;
        private Button CancelButton;
        private Button AddBtn;
        private ToolStripMenuItem UserMenu;
        private ToolStripMenuItem TenantMenu;
    }
}