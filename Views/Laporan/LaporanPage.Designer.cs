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
            laporanToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dahboardToolStripMenuItem, penggunaToolStripMenuItem, kategoriTelurToolStripMenuItem, transaksiToolStripMenuItem, operasionalToolStripMenuItem, laporanToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dahboardToolStripMenuItem
            // 
            dahboardToolStripMenuItem.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dahboardToolStripMenuItem.Name = "dahboardToolStripMenuItem";
            dahboardToolStripMenuItem.Size = new Size(102, 26);
            dahboardToolStripMenuItem.Text = "Dahboard";
            // 
            // penggunaToolStripMenuItem
            // 
            penggunaToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            penggunaToolStripMenuItem.Size = new Size(105, 26);
            penggunaToolStripMenuItem.Text = "Pengguna";
            // 
            // kategoriTelurToolStripMenuItem
            // 
            kategoriTelurToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            kategoriTelurToolStripMenuItem.Name = "kategoriTelurToolStripMenuItem";
            kategoriTelurToolStripMenuItem.Size = new Size(135, 26);
            kategoriTelurToolStripMenuItem.Text = "Kategori Telur";
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(101, 26);
            transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // operasionalToolStripMenuItem
            // 
            operasionalToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            operasionalToolStripMenuItem.Name = "operasionalToolStripMenuItem";
            operasionalToolStripMenuItem.Size = new Size(119, 26);
            operasionalToolStripMenuItem.Text = "Operasional";
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(90, 26);
            laporanToolStripMenuItem.Text = "Laporan";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Roboto", 10.8F);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(80, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LaporanPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem laporanToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}