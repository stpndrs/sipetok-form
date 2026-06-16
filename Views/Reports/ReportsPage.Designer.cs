namespace sipetok_form.Views.Laporan
{
    partial class ReportsPage
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
            MenuContainer = new MenuStrip();
            dahboardToolStripMenuItem = new ToolStripMenuItem();
            penggunaMenu = new ToolStripMenuItem();
            tenantMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            body = new TableLayoutPanel();
            formPanel = new FlowLayoutPanel();
            label2 = new Label();
            validationErrorMsg = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            MulaiDateTimePicker = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            SelesaiDateTimePicker = new DateTimePicker();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label5 = new Label();
            JenisCb = new ComboBox();
            ExportBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TransaksiBtn = new Button();
            OperationalBtn = new Button();
            DataList = new DataGridView();
            MenuContainer.SuspendLayout();
            body.SuspendLayout();
            formPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ControlLight;
            MenuContainer.ImageScalingSize = new Size(20, 20);
            MenuContainer.Items.AddRange(new ToolStripItem[] { dahboardToolStripMenuItem, penggunaMenu, tenantMenu, kategoriMenu, transaksiMenu, operationalMenu, laporanMenu, menuLogout });
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(5, 2, 0, 2);
            MenuContainer.Size = new Size(1904, 26);
            MenuContainer.TabIndex = 0;
            MenuContainer.Text = "menuStrip1";
            // 
            // dahboardToolStripMenuItem
            // 
            dahboardToolStripMenuItem.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dahboardToolStripMenuItem.Name = "dahboardToolStripMenuItem";
            dahboardToolStripMenuItem.Size = new Size(84, 22);
            dahboardToolStripMenuItem.Text = "Dahboard";
            dahboardToolStripMenuItem.Click += HandleMenuClick;
            // 
            // penggunaMenu
            // 
            penggunaMenu.Font = new Font("Roboto", 10.8F);
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(85, 22);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += HandleMenuClick;
            // 
            // tenantMenu
            // 
            tenantMenu.Font = new Font("Roboto", 10.8F);
            tenantMenu.Name = "tenantMenu";
            tenantMenu.Size = new Size(65, 22);
            tenantMenu.Text = "Tenant";
            tenantMenu.Click += HandleMenuClick;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Font = new Font("Roboto", 10.8F);
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(113, 22);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += HandleMenuClick;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Font = new Font("Roboto", 10.8F);
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(85, 22);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += HandleMenuClick;
            // 
            // operationalMenu
            // 
            operationalMenu.Font = new Font("Roboto", 10.8F);
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(100, 22);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += HandleMenuClick;
            // 
            // laporanMenu
            // 
            laporanMenu.Font = new Font("Roboto", 10.8F);
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(74, 22);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += HandleMenuClick;
            // 
            // menuLogout
            // 
            menuLogout.Font = new Font("Roboto", 10.8F);
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(67, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += HandleMenuClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // body
            // 
            body.ColumnCount = 2;
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            body.Controls.Add(formPanel, 1, 0);
            body.Controls.Add(flowLayoutPanel1, 0, 0);
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 26);
            body.Name = "body";
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            body.Size = new Size(1904, 770);
            body.TabIndex = 1;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(flowLayoutPanel3);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(1335, 2);
            formPanel.Margin = new Padding(3, 2, 3, 2);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(26, 22, 26, 22);
            formPanel.Size = new Size(424, 766);
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
            flowLayoutPanel3.Controls.Add(ExportBtn);
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
            flowLayoutPanel2.Controls.Add(MulaiDateTimePicker);
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
            // MulaiDateTimePicker
            // 
            MulaiDateTimePicker.Location = new Point(12, 31);
            MulaiDateTimePicker.Name = "MulaiDateTimePicker";
            MulaiDateTimePicker.Size = new Size(249, 23);
            MulaiDateTimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(SelesaiDateTimePicker);
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
            // SelesaiDateTimePicker
            // 
            SelesaiDateTimePicker.Location = new Point(12, 31);
            SelesaiDateTimePicker.Name = "SelesaiDateTimePicker";
            SelesaiDateTimePicker.Size = new Size(249, 23);
            SelesaiDateTimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(JenisCb);
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
            // JenisCb
            // 
            JenisCb.FormattingEnabled = true;
            JenisCb.Items.AddRange(new object[] { "Excel", "Pdf" });
            JenisCb.Location = new Point(12, 31);
            JenisCb.Name = "JenisCb";
            JenisCb.Size = new Size(249, 23);
            JenisCb.TabIndex = 1;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(29, 338);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(281, 29);
            ExportBtn.TabIndex = 6;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(TransaksiBtn);
            flowLayoutPanel1.Controls.Add(OperationalBtn);
            flowLayoutPanel1.Controls.Add(DataList);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1326, 764);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // TransaksiBtn
            // 
            TransaksiBtn.Location = new Point(3, 3);
            TransaksiBtn.Name = "TransaksiBtn";
            TransaksiBtn.Size = new Size(110, 23);
            TransaksiBtn.TabIndex = 0;
            TransaksiBtn.Text = "Transaksi";
            TransaksiBtn.UseVisualStyleBackColor = true;
            TransaksiBtn.Click += TransaksiBtn_Click;
            // 
            // OperationalBtn
            // 
            OperationalBtn.Location = new Point(119, 3);
            OperationalBtn.Name = "OperationalBtn";
            OperationalBtn.Size = new Size(110, 23);
            OperationalBtn.TabIndex = 1;
            OperationalBtn.Text = "Operational";
            OperationalBtn.UseVisualStyleBackColor = true;
            OperationalBtn.Click += OperationalBtn_Click;
            // 
            // DataList
            // 
            DataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataList.Location = new Point(3, 32);
            DataList.Name = "DataList";
            DataList.RowHeadersWidth = 51;
            DataList.ScrollBars = ScrollBars.Vertical;
            DataList.Size = new Size(1281, 898);
            DataList.TabIndex = 2;
            // 
            // LaporanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 796);
            Controls.Add(body);
            Controls.Add(MenuContainer);
            MainMenuStrip = MenuContainer;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LaporanPage";
            Text = "LaporanPage";
            WindowState = FormWindowState.Maximized;
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            body.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuContainer;
        private ToolStripMenuItem dahboardToolStripMenuItem;
        private ToolStripMenuItem penggunaMenu;
        private ToolStripMenuItem kategoriMenu;
        private ToolStripMenuItem transaksiMenu;
        private ToolStripMenuItem operationalMenu;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem menuLogout;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel body;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button TransaksiBtn;
        private DataGridView DataList;
        private Button OperationalBtn;
        private FlowLayoutPanel formPanel;
        private Label label2;
        private Label validationErrorMsg;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private DateTimePicker MulaiDateTimePicker;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private DateTimePicker SelesaiDateTimePicker;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private ComboBox JenisCb;
        private Button ExportBtn;
        private ToolStripMenuItem tenantMenu;
    }
}