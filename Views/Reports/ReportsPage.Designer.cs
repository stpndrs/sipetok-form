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
            FormLabel = new Label();
            validationErrorMsg = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            DateStartInputGroup = new FlowLayoutPanel();
            DateStartLabel = new Label();
            StartDateTimePicker = new DateTimePicker();
            DateEndInputGroup = new FlowLayoutPanel();
            DateEndLabel = new Label();
            EndDateTimePicker = new DateTimePicker();
            TypeInputGroup = new FlowLayoutPanel();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            ExportBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TransaksiBtn = new Button();
            OperationalBtn = new Button();
            DataList = new DataGridView();
            MenuContainer.SuspendLayout();
            body.SuspendLayout();
            formPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            DateStartInputGroup.SuspendLayout();
            DateEndInputGroup.SuspendLayout();
            TypeInputGroup.SuspendLayout();
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
            formPanel.Controls.Add(FormLabel);
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
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormLabel.ForeColor = SystemColors.ControlText;
            FormLabel.Location = new Point(29, 22);
            FormLabel.Margin = new Padding(3, 0, 3, 11);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(287, 29);
            FormLabel.TabIndex = 1;
            FormLabel.Text = "Kelola Laporan Transaksi";
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
            flowLayoutPanel3.Controls.Add(DateStartInputGroup);
            flowLayoutPanel3.Controls.Add(DateEndInputGroup);
            flowLayoutPanel3.Controls.Add(TypeInputGroup);
            flowLayoutPanel3.Controls.Add(ExportBtn);
            flowLayoutPanel3.Location = new Point(29, 111);
            flowLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(26, 22, 26, 22);
            flowLayoutPanel3.Size = new Size(356, 461);
            flowLayoutPanel3.TabIndex = 17;
            // 
            // DateStartInputGroup
            // 
            DateStartInputGroup.Controls.Add(DateStartLabel);
            DateStartInputGroup.Controls.Add(StartDateTimePicker);
            DateStartInputGroup.Location = new Point(26, 22);
            DateStartInputGroup.Margin = new Padding(0, 0, 0, 30);
            DateStartInputGroup.Name = "DateStartInputGroup";
            DateStartInputGroup.Padding = new Padding(9, 8, 9, 8);
            DateStartInputGroup.Size = new Size(284, 76);
            DateStartInputGroup.TabIndex = 3;
            // 
            // DateStartLabel
            // 
            DateStartLabel.AutoSize = true;
            DateStartLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DateStartLabel.Location = new Point(12, 8);
            DateStartLabel.Name = "DateStartLabel";
            DateStartLabel.Size = new Size(107, 20);
            DateStartLabel.TabIndex = 0;
            DateStartLabel.Text = "Tanggal Mulai";
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Location = new Point(12, 31);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(249, 23);
            StartDateTimePicker.TabIndex = 1;
            // 
            // DateEndInputGroup
            // 
            DateEndInputGroup.Controls.Add(DateEndLabel);
            DateEndInputGroup.Controls.Add(EndDateTimePicker);
            DateEndInputGroup.Location = new Point(26, 128);
            DateEndInputGroup.Margin = new Padding(0, 0, 0, 30);
            DateEndInputGroup.Name = "DateEndInputGroup";
            DateEndInputGroup.Padding = new Padding(9, 8, 9, 8);
            DateEndInputGroup.Size = new Size(284, 76);
            DateEndInputGroup.TabIndex = 4;
            // 
            // DateEndLabel
            // 
            DateEndLabel.AutoSize = true;
            DateEndLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DateEndLabel.Location = new Point(12, 8);
            DateEndLabel.Name = "DateEndLabel";
            DateEndLabel.Size = new Size(122, 20);
            DateEndLabel.TabIndex = 0;
            DateEndLabel.Text = "Tanggal Selesai";
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Location = new Point(12, 31);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(249, 23);
            EndDateTimePicker.TabIndex = 1;
            // 
            // TypeInputGroup
            // 
            TypeInputGroup.Controls.Add(TypeLabel);
            TypeInputGroup.Controls.Add(TypeComboBox);
            TypeInputGroup.Location = new Point(26, 234);
            TypeInputGroup.Margin = new Padding(0, 0, 0, 30);
            TypeInputGroup.Name = "TypeInputGroup";
            TypeInputGroup.Padding = new Padding(9, 8, 9, 8);
            TypeInputGroup.Size = new Size(284, 71);
            TypeInputGroup.TabIndex = 5;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Microsoft Sans Serif", 12F);
            TypeLabel.Location = new Point(12, 8);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(46, 20);
            TypeLabel.TabIndex = 0;
            TypeLabel.Text = "Jenis";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Excel", "Pdf" });
            TypeComboBox.Location = new Point(12, 31);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(249, 23);
            TypeComboBox.TabIndex = 1;
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
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 796);
            Controls.Add(body);
            Controls.Add(MenuContainer);
            MainMenuStrip = MenuContainer;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsPage";
            Text = "LaporanPage";
            WindowState = FormWindowState.Maximized;
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            body.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            DateStartInputGroup.ResumeLayout(false);
            DateStartInputGroup.PerformLayout();
            DateEndInputGroup.ResumeLayout(false);
            DateEndInputGroup.PerformLayout();
            TypeInputGroup.ResumeLayout(false);
            TypeInputGroup.PerformLayout();
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
        private Label FormLabel;
        private Label validationErrorMsg;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel DateStartInputGroup;
        private Label DateStartLabel;
        private DateTimePicker StartDateTimePicker;
        private FlowLayoutPanel DateEndInputGroup;
        private Label DateEndLabel;
        private DateTimePicker EndDateTimePicker;
        private FlowLayoutPanel TypeInputGroup;
        private Label TypeLabel;
        private ComboBox TypeComboBox;
        private Button ExportBtn;
        private ToolStripMenuItem tenantMenu;
    }
}