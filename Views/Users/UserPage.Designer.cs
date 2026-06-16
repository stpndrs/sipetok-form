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
            container = new TableLayoutPanel();
            topMenu = new MenuStrip();
            dashboardMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tenantMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            stokMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            body = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            AddBtn = new Button();
            UsersList = new DataGridView();
            formPanel = new FlowLayoutPanel();
            label2 = new Label();
            validationErrorMsg = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            txtUsername = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            txtPassword = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            Email = new Label();
            txtEmail = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label5 = new Label();
            cbbRole = new ComboBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            container.SuspendLayout();
            topMenu.SuspendLayout();
            body.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersList).BeginInit();
            formPanel.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(topMenu, 0, 0);
            container.Controls.Add(body, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(1902, 1033);
            container.TabIndex = 0;
            // 
            // topMenu
            // 
            topMenu.BackColor = SystemColors.ControlLight;
            topMenu.Dock = DockStyle.Fill;
            topMenu.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topMenu.ImageScalingSize = new Size(20, 20);
            topMenu.Items.AddRange(new ToolStripItem[] { dashboardMenu, toolStripMenuItem1, tenantMenu, kategoriMenu, stokMenu, transaksiMenu, operationalMenu, laporanMenu, menuLogout });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.Padding = new Padding(6, 3, 0, 3);
            topMenu.Size = new Size(1902, 32);
            topMenu.TabIndex = 6;
            topMenu.Text = "menuStrip1";
            // 
            // dashboardMenu
            // 
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(111, 26);
            dashboardMenu.Text = "Dashboard";
            dashboardMenu.Click += HandleClickMenu;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(104, 26);
            toolStripMenuItem1.Text = "Pengguna";
            toolStripMenuItem1.Click += HandleClickMenu;
            // 
            // tenantMenu
            // 
            tenantMenu.Name = "tenantMenu";
            tenantMenu.Size = new Size(80, 26);
            tenantMenu.Text = "Tenant";
            tenantMenu.Click += HandleClickMenu;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(136, 26);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += HandleClickMenu;
            // 
            // stokMenu
            // 
            stokMenu.Name = "stokMenu";
            stokMenu.Size = new Size(138, 26);
            stokMenu.Text = "Stok & Inventori";
            stokMenu.Click += HandleClickMenu;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(103, 26);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += HandleClickMenu;
            // 
            // operationalMenu
            // 
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(120, 26);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += HandleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(90, 26);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += HandleClickMenu;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(80, 26);
            menuLogout.Text = "Logout";
            menuLogout.Click += HandleClickMenu;
            // 
            // body
            // 
            body.AutoSize = true;
            body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            body.ColumnCount = 2;
            body.ColumnStyles.Add(new ColumnStyle());
            body.ColumnStyles.Add(new ColumnStyle());
            body.Controls.Add(flowLayoutPanel1, 0, 0);
            body.Controls.Add(formPanel, 1, 0);
            body.Location = new Point(3, 35);
            body.Name = "body";
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle());
            body.Size = new Size(1859, 930);
            body.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(AddBtn);
            flowLayoutPanel1.Controls.Add(UsersList);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1362, 924);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 2;
            label1.Text = "Daftar Pengguna";
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
            AddBtn.Click += AddBtn_Click;
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
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(flowLayoutPanel4);
            formPanel.Controls.Add(flowLayoutPanel5);
            formPanel.Controls.Add(flowLayoutPanel6);
            formPanel.Controls.Add(flowLayoutPanel7);
            formPanel.Controls.Add(SaveBtn);
            formPanel.Controls.Add(CancelBtn);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(1371, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(30, 29, 30, 29);
            formPanel.Size = new Size(485, 912);
            formPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(33, 29);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(312, 36);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Pengguna";
            // 
            // validationErrorMsg
            // 
            validationErrorMsg.AutoSize = true;
            validationErrorMsg.BackColor = SystemColors.Control;
            validationErrorMsg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationErrorMsg.ForeColor = Color.Red;
            validationErrorMsg.Location = new Point(33, 80);
            validationErrorMsg.Margin = new Padding(3, 0, 3, 40);
            validationErrorMsg.Name = "validationErrorMsg";
            validationErrorMsg.Size = new Size(0, 20);
            validationErrorMsg.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(txtUsername);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel4.Location = new Point(30, 140);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel4.Size = new Size(440, 72);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtUsername.Location = new Point(13, 34);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(406, 22);
            txtUsername.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(txtPassword);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel5.Location = new Point(30, 252);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel5.Size = new Size(440, 72);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(13, 11);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtPassword.Location = new Point(13, 34);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(406, 22);
            txtPassword.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(Email);
            flowLayoutPanel6.Controls.Add(txtEmail);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel6.Location = new Point(30, 364);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel6.Size = new Size(440, 72);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 10.2F);
            Email.Location = new Point(13, 11);
            Email.Name = "Email";
            Email.Size = new Size(51, 20);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtEmail.Location = new Point(13, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(406, 22);
            txtEmail.TabIndex = 2;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Controls.Add(label5);
            flowLayoutPanel7.Controls.Add(cbbRole);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel7.Location = new Point(30, 476);
            flowLayoutPanel7.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel7.Size = new Size(440, 74);
            flowLayoutPanel7.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 1;
            label5.Text = "Role Pengguna";
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Items.AddRange(new object[] { "Admin", "Tenant" });
            cbbRole.Location = new Point(13, 34);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(406, 24);
            cbbRole.TabIndex = 2;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(33, 593);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(434, 48);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Simpan";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBtn.Location = new Point(33, 647);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(434, 48);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Batalkan";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(container);
            Name = "UserPage";
            Text = "UserPage";
            WindowState = FormWindowState.Maximized;
            container.ResumeLayout(false);
            container.PerformLayout();
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            body.ResumeLayout(false);
            body.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersList).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel container;
        private MenuStrip topMenu;
        private ToolStripMenuItem dashboardMenu;
        private ToolStripMenuItem kategoriMenu;
        private ToolStripMenuItem stokMenu;
        private ToolStripMenuItem transaksiMenu;
        private ToolStripMenuItem operationalMenu;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem menuLogout;
        private TableLayoutPanel body;
        private FlowLayoutPanel formPanel;
        private Label label2;
        private Label validationErrorMsg;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private TextBox txtUsername;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private TextBox txtPassword;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label Email;
        private TextBox txtEmail;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label5;
        private ComboBox cbbRole;
        private Button SaveBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private DataGridView UsersList;
        private Button CancelBtn;
        private Button AddBtn;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tenantMenu;
    }
}