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
            penggunaMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            formPanel = new FlowLayoutPanel();
            label2 = new Label();
            validationErrorMsg = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            dateTimePickerMulai = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            dateTimePickerSelesai = new DateTimePicker();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnExport = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTransaksi = new Button();
            btnOperational = new Button();
            dataGridView1 = new DataGridView();
            tenantMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            formPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dahboardToolStripMenuItem, penggunaMenu, tenantMenu, kategoriMenu, transaksiMenu, operationalMenu, laporanMenu, menuLogout });
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
            // penggunaMenu
            // 
            penggunaMenu.Font = new Font("Roboto", 10.8F);
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(85, 22);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += handleClickMenu;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Font = new Font("Roboto", 10.8F);
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(113, 22);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += handleClickMenu;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Font = new Font("Roboto", 10.8F);
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(85, 22);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += handleClickMenu;
            // 
            // operationalMenu
            // 
            operationalMenu.Font = new Font("Roboto", 10.8F);
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(100, 22);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += handleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Font = new Font("Roboto", 10.8F);
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(74, 22);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += handleClickMenu;
            // 
            // menuLogout
            // 
            menuLogout.Font = new Font("Roboto", 10.8F);
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(67, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += handleClickMenu;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.8382339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1617641F));
            tableLayoutPanel1.Controls.Add(formPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1904, 936);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(flowLayoutPanel3);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(1466, 2);
            formPanel.Margin = new Padding(3, 2, 3, 2);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(26, 22, 26, 22);
            formPanel.Size = new Size(424, 932);
            formPanel.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(29, 22);
            label2.Margin = new Padding(3, 0, 3, 11);
            label2.Name = "label2";
            label2.Size = new Size(287, 29);
            label2.TabIndex = 1;
            label2.Text = "Kelola Laporan Transaksi";
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Controls.Add(btnExport);
            flowLayoutPanel3.Location = new Point(29, 111);
            flowLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(26, 22, 26, 22);
            flowLayoutPanel3.Size = new Size(356, 461);
            flowLayoutPanel3.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(dateTimePickerMulai);
            flowLayoutPanel2.Location = new Point(26, 22);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel2.Size = new Size(284, 76);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tanggal Mulai";
            // 
            // dateTimePickerMulai
            // 
            dateTimePickerMulai.Location = new Point(12, 31);
            dateTimePickerMulai.Name = "dateTimePickerMulai";
            dateTimePickerMulai.Size = new Size(249, 23);
            dateTimePickerMulai.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(dateTimePickerSelesai);
            flowLayoutPanel4.Location = new Point(26, 128);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel4.Size = new Size(284, 76);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(12, 8);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 0;
            label4.Text = "Tanggal Selesai";
            // 
            // dateTimePickerSelesai
            // 
            dateTimePickerSelesai.Location = new Point(12, 31);
            dateTimePickerSelesai.Name = "dateTimePickerSelesai";
            dateTimePickerSelesai.Size = new Size(249, 23);
            dateTimePickerSelesai.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(comboBox1);
            flowLayoutPanel5.Location = new Point(26, 234);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 30);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(9, 8, 9, 8);
            flowLayoutPanel5.Size = new Size(284, 71);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 0;
            label5.Text = "Jenis";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Excel", "Pdf" });
            comboBox1.Location = new Point(12, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 23);
            comboBox1.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(29, 338);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(281, 29);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTransaksi);
            flowLayoutPanel1.Controls.Add(btnOperational);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1457, 930);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(3, 3);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(110, 23);
            btnTransaksi.TabIndex = 0;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // btnOperational
            // 
            btnOperational.Location = new Point(119, 3);
            btnOperational.Name = "btnOperational";
            btnOperational.Size = new Size(110, 23);
            btnOperational.TabIndex = 1;
            btnOperational.Text = "Operational";
            btnOperational.UseVisualStyleBackColor = true;
            btnOperational.Click += btnOperational_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1397, 890);
            dataGridView1.TabIndex = 2;
            // 
            // tenantMenu
            // 
            tenantMenu.Font = new Font("Roboto", 10.8F);
            tenantMenu.Name = "tenantMenu";
            tenantMenu.Size = new Size(65, 22);
            tenantMenu.Text = "Tenant";
            tenantMenu.Click += handleClickMenu;
            // 
            // LaporanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LaporanPage";
            Text = "LaporanPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dahboardToolStripMenuItem;
        private ToolStripMenuItem penggunaMenu;
        private ToolStripMenuItem kategoriMenu;
        private ToolStripMenuItem transaksiMenu;
        private ToolStripMenuItem operationalMenu;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem menuLogout;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTransaksi;
        private DataGridView dataGridView1;
        private Button btnOperational;
        private FlowLayoutPanel formPanel;
        private Label label2;
        private Label validationErrorMsg;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private DateTimePicker dateTimePickerMulai;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private DateTimePicker dateTimePickerSelesai;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private ComboBox comboBox1;
        private Button btnExport;
        private ToolStripMenuItem tenantMenu;
    }
}