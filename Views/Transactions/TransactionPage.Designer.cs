namespace sipetok_form.Views.Transactions
{
    partial class TransactionPage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            addBtn = new Button();
            usersList = new DataGridView();
            body = new TableLayoutPanel();
            menuLogout = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            stokMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            penggunaMenu = new ToolStripMenuItem();
            dashboardMenu = new ToolStripMenuItem();
            topMenu = new MenuStrip();
            container = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersList).BeginInit();
            body.SuspendLayout();
            topMenu.SuspendLayout();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Controls.Add(usersList);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1846, 942);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(264, 53);
            label1.TabIndex = 2;
            label1.Text = "Daftar Transaksi";
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(3, 71);
            addBtn.Margin = new Padding(3, 3, 3, 30);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(180, 48);
            addBtn.TabIndex = 17;
            addBtn.Text = "Tambah Data";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // usersList
            // 
            usersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersList.Location = new Point(3, 152);
            usersList.Margin = new Padding(3, 3, 50, 3);
            usersList.MaximumSize = new Size(1793, 787);
            usersList.Name = "usersList";
            usersList.RowHeadersWidth = 51;
            usersList.Size = new Size(1793, 787);
            usersList.TabIndex = 3;
            // 
            // body
            // 
            body.AutoSize = true;
            body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            body.ColumnCount = 1;
            body.ColumnStyles.Add(new ColumnStyle());
            body.ColumnStyles.Add(new ColumnStyle());
            body.Controls.Add(flowLayoutPanel1, 0, 0);
            body.Location = new Point(3, 33);
            body.Name = "body";
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle());
            body.Size = new Size(1852, 948);
            body.TabIndex = 7;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(80, 26);
            menuLogout.Text = "Logout";
            menuLogout.Click += handleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(90, 26);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += handleClickMenu;
            // 
            // operationalMenu
            // 
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(120, 26);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += handleClickMenu;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(103, 26);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += handleClickMenu;
            // 
            // stokMenu
            // 
            stokMenu.Name = "stokMenu";
            stokMenu.Size = new Size(138, 26);
            stokMenu.Text = "Stok & Inventori";
            stokMenu.Click += handleClickMenu;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(136, 26);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += handleClickMenu;
            // 
            // penggunaMenu
            // 
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(104, 26);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += handleClickMenu;
            // 
            // dashboardMenu
            // 
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(111, 26);
            dashboardMenu.Text = "Dashboard";
            dashboardMenu.Click += handleClickMenu;
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
            topMenu.Size = new Size(1902, 30);
            topMenu.TabIndex = 6;
            topMenu.Text = "menuStrip1";
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
            container.TabIndex = 1;
            // 
            // TransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(container);
            Name = "TransactionPage";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersList).EndInit();
            body.ResumeLayout(false);
            body.PerformLayout();
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button addBtn;
        private DataGridView usersList;
        private TableLayoutPanel body;
        private ToolStripMenuItem menuLogout;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem operationalMenu;
        private ToolStripMenuItem transaksiMenu;
        private ToolStripMenuItem stokMenu;
        private ToolStripMenuItem kategoriMenu;
        private ToolStripMenuItem penggunaMenu;
        private ToolStripMenuItem dashboardMenu;
        private MenuStrip topMenu;
        private TableLayoutPanel container;
    }
}