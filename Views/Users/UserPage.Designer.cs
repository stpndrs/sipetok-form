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
            penggunaMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            stokMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            body = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            addBtn = new Button();
            usersList = new DataGridView();
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
            btnSave = new Button();
            cancelBtn = new Button();
            container.SuspendLayout();
            topMenu.SuspendLayout();
            body.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersList).BeginInit();
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
            container.Margin = new Padding(3, 2, 3, 2);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(1664, 775);
            container.TabIndex = 0;
            // 
            // topMenu
            // 
            topMenu.BackColor = SystemColors.ControlLight;
            topMenu.Dock = DockStyle.Fill;
            topMenu.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topMenu.ImageScalingSize = new Size(20, 20);
            topMenu.Items.AddRange(new ToolStripItem[] { dashboardMenu, penggunaMenu, kategoriMenu, stokMenu, transaksiMenu, operationalMenu, laporanMenu, menuLogout });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.Padding = new Padding(5, 2, 0, 2);
            topMenu.Size = new Size(1664, 26);
            topMenu.TabIndex = 6;
            topMenu.Text = "menuStrip1";
            // 
            // dashboardMenu
            // 
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(92, 22);
            dashboardMenu.Text = "Dashboard";
            dashboardMenu.Click += handleClickMenu;
            // 
            // penggunaMenu
            // 
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(85, 22);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += handleClickMenu;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(113, 22);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += handleClickMenu;
            // 
            // stokMenu
            // 
            stokMenu.Name = "stokMenu";
            stokMenu.Size = new Size(117, 22);
            stokMenu.Text = "Stok & Inventori";
            stokMenu.Click += handleClickMenu;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(85, 22);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += handleClickMenu;
            // 
            // operationalMenu
            // 
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(100, 22);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += handleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(74, 22);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += handleClickMenu;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(67, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += handleClickMenu;
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
            body.Location = new Point(3, 28);
            body.Margin = new Padding(3, 2, 3, 2);
            body.Name = "body";
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle());
            body.Size = new Size(1628, 698);
            body.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Controls.Add(usersList);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 2);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1192, 694);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 11);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 2;
            label1.Text = "Daftar Pengguna";
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(3, 42);
            addBtn.Margin = new Padding(3, 2, 3, 22);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(158, 36);
            addBtn.TabIndex = 17;
            addBtn.Text = "Tambah Data";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // usersList
            // 
            usersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersList.Location = new Point(3, 102);
            usersList.Margin = new Padding(3, 2, 44, 2);
            usersList.MaximumSize = new Size(1569, 590);
            usersList.Name = "usersList";
            usersList.RowHeadersWidth = 51;
            usersList.Size = new Size(1145, 590);
            usersList.TabIndex = 3;
            usersList.CellContentClick += usersList_CellContentClick;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(flowLayoutPanel4);
            formPanel.Controls.Add(flowLayoutPanel5);
            formPanel.Controls.Add(flowLayoutPanel6);
            formPanel.Controls.Add(flowLayoutPanel7);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(cancelBtn);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(1201, 2);
            formPanel.Margin = new Padding(3, 2, 3, 2);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(26, 22, 26, 22);
            formPanel.Size = new Size(424, 684);
            formPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(29, 22);
            label2.Margin = new Padding(3, 0, 3, 11);
            label2.Name = "label2";
            label2.Size = new Size(253, 29);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Pengguna";
            // 
            // validationErrorMsg
            // 
            validationErrorMsg.AutoSize = true;
            validationErrorMsg.BackColor = SystemColors.Control;
            validationErrorMsg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationErrorMsg.ForeColor = Color.Red;
            validationErrorMsg.Location = new Point(29, 62);
            validationErrorMsg.Margin = new Padding(3, 0, 3, 30);
            validationErrorMsg.Name = "validationErrorMsg";
            validationErrorMsg.Size = new Size(0, 17);
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
            flowLayoutPanel4.Location = new Point(26, 109);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel4.Size = new Size(386, 58);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtUsername.Location = new Point(12, 27);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(356, 19);
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
            flowLayoutPanel5.Location = new Point(26, 197);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel5.Size = new Size(386, 58);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(12, 8);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtPassword.Location = new Point(12, 27);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(356, 19);
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
            flowLayoutPanel6.Location = new Point(26, 285);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel6.Size = new Size(386, 58);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 10.2F);
            Email.Location = new Point(12, 8);
            Email.Name = "Email";
            Email.Size = new Size(42, 17);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtEmail.Location = new Point(12, 27);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 19);
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
            flowLayoutPanel7.Location = new Point(26, 373);
            flowLayoutPanel7.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel7.Size = new Size(386, 60);
            flowLayoutPanel7.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 1;
            label5.Text = "Role Pengguna";
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Items.AddRange(new object[] { "Admin", "Tenant" });
            cbbRole.Location = new Point(12, 27);
            cbbRole.Margin = new Padding(3, 2, 3, 2);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(356, 21);
            cbbRole.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(29, 465);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(380, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(29, 505);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(380, 36);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Batalkan";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(container);
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)usersList).EndInit();
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
        private ToolStripMenuItem penggunaMenu;
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
        private Button btnSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private DataGridView usersList;
        private Button cancelBtn;
        private Button addBtn;
    }
}