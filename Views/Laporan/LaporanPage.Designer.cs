namespace sipetok_form.Views.Laporan
{
    partial class LaporanPage
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            dahboardToolStripMenuItem = new ToolStripMenuItem();
            penggunaToolStripMenuItem = new ToolStripMenuItem();
            kategoriTelurToolStripMenuItem = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            operasionalToolStripMenuItem = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dahboardToolStripMenuItem, penggunaToolStripMenuItem, kategoriTelurToolStripMenuItem, transaksiToolStripMenuItem, operasionalToolStripMenuItem, laporanMenu, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1904, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dahboardToolStripMenuItem
            // 
            dahboardToolStripMenuItem.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dahboardToolStripMenuItem.Name = "dahboardToolStripMenuItem";
            dahboardToolStripMenuItem.Size = new Size(84, 22);
            dahboardToolStripMenuItem.Text = "Dahboard";
            dahboardToolStripMenuItem.Click += handleClickMenu;
            // 
            // penggunaToolStripMenuItem
            // 
            penggunaToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            penggunaToolStripMenuItem.Size = new Size(85, 22);
            penggunaToolStripMenuItem.Text = "Pengguna";
            penggunaToolStripMenuItem.Click += handleClickMenu;
            // 
            // kategoriTelurToolStripMenuItem
            // 
            kategoriTelurToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            kategoriTelurToolStripMenuItem.Name = "kategoriTelurToolStripMenuItem";
            kategoriTelurToolStripMenuItem.Size = new Size(113, 22);
            kategoriTelurToolStripMenuItem.Text = "Kategori Telur";
            kategoriTelurToolStripMenuItem.Click += handleClickMenu;
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(85, 22);
            transaksiToolStripMenuItem.Text = "Transaksi";
            transaksiToolStripMenuItem.Click += handleClickMenu;
            // 
            // operasionalToolStripMenuItem
            // 
            operasionalToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            operasionalToolStripMenuItem.Name = "operasionalToolStripMenuItem";
            operasionalToolStripMenuItem.Size = new Size(100, 22);
            operasionalToolStripMenuItem.Text = "Operasional";
            operasionalToolStripMenuItem.Click += handleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Font = new Font("Roboto", 10.8F);
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(74, 22);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += handleClickMenu;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(67, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += handleClickMenu;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(12, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 651);
            panel1.TabIndex = 2;
            // 
            // LaporanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LaporanPage";
            Text = "LaporanPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dahboardToolStripMenuItem;
        private ToolStripMenuItem penggunaToolStripMenuItem;
        private ToolStripMenuItem kategoriTelurToolStripMenuItem;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem operasionalToolStripMenuItem;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Panel panel1;
    }
}