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
            DashboardMenu = new ToolStripMenuItem();
            PenggunaMenu = new ToolStripMenuItem();
            TenantMenu = new ToolStripMenuItem();
            KategoriMenu = new ToolStripMenuItem();
            TransaksiMenu = new ToolStripMenuItem();
            OperationalMenu = new ToolStripMenuItem();
            LaporanMenu = new ToolStripMenuItem();
            LogoutMenu = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PageBodyContainer = new TableLayoutPanel();
            FormContainer = new FlowLayoutPanel();
            FormLabel = new Label();
            validationErrorMsg = new Label();
            InputContainer = new FlowLayoutPanel();
            DateStartInputGroup = new FlowLayoutPanel();
            DateStartLabel = new Label();
            StartDateTimePicker = new DateTimePicker();
            DateEndInputGroup = new FlowLayoutPanel();
            DateEndLabel = new Label();
            EndDateTimePicker = new DateTimePicker();
            TypeInputGroup = new FlowLayoutPanel();
            TypeLabel = new Label();
            FormatTypeComboBox = new ComboBox();
            ExportButton = new Button();
            ListContainer = new FlowLayoutPanel();
            TransactionButton = new Button();
            OperationalButton = new Button();
            DataList = new DataGridView();
            MenuContainer.SuspendLayout();
            PageBodyContainer.SuspendLayout();
            FormContainer.SuspendLayout();
            InputContainer.SuspendLayout();
            DateStartInputGroup.SuspendLayout();
            DateEndInputGroup.SuspendLayout();
            TypeInputGroup.SuspendLayout();
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ControlLight;
            MenuContainer.ImageScalingSize = new Size(20, 20);
            MenuContainer.Items.AddRange(new ToolStripItem[] { DashboardMenu, PenggunaMenu, TenantMenu, KategoriMenu, TransaksiMenu, OperationalMenu, LaporanMenu, LogoutMenu });
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(5, 2, 0, 2);
            MenuContainer.Size = new Size(1904, 26);
            MenuContainer.TabIndex = 0;
            MenuContainer.Text = "menuStrip1";
            // 
            // DashboardMenu
            // 
            DashboardMenu.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(84, 22);
            DashboardMenu.Text = "Dahboard";
            DashboardMenu.Click += HandleMenuClick;
            // 
            // PenggunaMenu
            // 
            PenggunaMenu.Font = new Font("Roboto", 10.8F);
            PenggunaMenu.Name = "PenggunaMenu";
            PenggunaMenu.Size = new Size(85, 22);
            PenggunaMenu.Text = "Pengguna";
            PenggunaMenu.Click += HandleMenuClick;
            // 
            // TenantMenu
            // 
            TenantMenu.Font = new Font("Roboto", 10.8F);
            TenantMenu.Name = "TenantMenu";
            TenantMenu.Size = new Size(65, 22);
            TenantMenu.Text = "Tenant";
            TenantMenu.Click += HandleMenuClick;
            // 
            // KategoriMenu
            // 
            KategoriMenu.Font = new Font("Roboto", 10.8F);
            KategoriMenu.Name = "KategoriMenu";
            KategoriMenu.Size = new Size(113, 22);
            KategoriMenu.Text = "Kategori Telur";
            KategoriMenu.Click += HandleMenuClick;
            // 
            // TransaksiMenu
            // 
            TransaksiMenu.Font = new Font("Roboto", 10.8F);
            TransaksiMenu.Name = "TransaksiMenu";
            TransaksiMenu.Size = new Size(85, 22);
            TransaksiMenu.Text = "Transaksi";
            TransaksiMenu.Click += HandleMenuClick;
            // 
            // OperationalMenu
            // 
            OperationalMenu.Font = new Font("Roboto", 10.8F);
            OperationalMenu.Name = "OperationalMenu";
            OperationalMenu.Size = new Size(100, 22);
            OperationalMenu.Text = "Operasional";
            OperationalMenu.Click += HandleMenuClick;
            // 
            // LaporanMenu
            // 
            LaporanMenu.Font = new Font("Roboto", 10.8F);
            LaporanMenu.Name = "LaporanMenu";
            LaporanMenu.Size = new Size(74, 22);
            LaporanMenu.Text = "Laporan";
            LaporanMenu.Click += HandleMenuClick;
            // 
            // LogoutMenu
            // 
            LogoutMenu.Font = new Font("Roboto", 10.8F);
            LogoutMenu.Name = "LogoutMenu";
            LogoutMenu.Size = new Size(67, 22);
            LogoutMenu.Text = "Logout";
            LogoutMenu.Click += HandleMenuClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PageBodyContainer
            // 
            PageBodyContainer.ColumnCount = 2;
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            PageBodyContainer.Controls.Add(FormContainer, 1, 0);
            PageBodyContainer.Controls.Add(ListContainer, 0, 0);
            PageBodyContainer.Dock = DockStyle.Fill;
            PageBodyContainer.Location = new Point(0, 26);
            PageBodyContainer.Name = "PageBodyContainer";
            PageBodyContainer.RowCount = 1;
            PageBodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PageBodyContainer.Size = new Size(1904, 770);
            PageBodyContainer.TabIndex = 1;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(FormLabel);
            FormContainer.Controls.Add(validationErrorMsg);
            FormContainer.Controls.Add(InputContainer);
            FormContainer.FlowDirection = FlowDirection.TopDown;
            FormContainer.Location = new Point(1335, 2);
            FormContainer.Margin = new Padding(3, 2, 3, 2);
            FormContainer.Name = "FormContainer";
            FormContainer.Padding = new Padding(26, 22, 26, 22);
            FormContainer.Size = new Size(424, 766);
            FormContainer.TabIndex = 6;
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
            // InputContainer
            // 
            InputContainer.Controls.Add(DateStartInputGroup);
            InputContainer.Controls.Add(DateEndInputGroup);
            InputContainer.Controls.Add(TypeInputGroup);
            InputContainer.Controls.Add(ExportButton);
            InputContainer.Location = new Point(29, 111);
            InputContainer.Margin = new Padding(3, 2, 3, 2);
            InputContainer.Name = "InputContainer";
            InputContainer.Padding = new Padding(26, 22, 26, 22);
            InputContainer.Size = new Size(356, 461);
            InputContainer.TabIndex = 17;
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
            TypeInputGroup.Controls.Add(FormatTypeComboBox);
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
            // FormatTypeComboBox
            // 
            FormatTypeComboBox.FormattingEnabled = true;
            FormatTypeComboBox.Items.AddRange(new object[] { "Excel", "Pdf" });
            FormatTypeComboBox.Location = new Point(12, 31);
            FormatTypeComboBox.Name = "FormatTypeComboBox";
            FormatTypeComboBox.Size = new Size(249, 23);
            FormatTypeComboBox.TabIndex = 1;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(29, 338);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(281, 29);
            ExportButton.TabIndex = 6;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportBtn_Click;
            // 
            // ListContainer
            // 
            ListContainer.Controls.Add(TransactionButton);
            ListContainer.Controls.Add(OperationalButton);
            ListContainer.Controls.Add(DataList);
            ListContainer.Location = new Point(3, 3);
            ListContainer.Name = "ListContainer";
            ListContainer.Size = new Size(1326, 764);
            ListContainer.TabIndex = 0;
            // 
            // TransactionButton
            // 
            TransactionButton.Location = new Point(3, 3);
            TransactionButton.Name = "TransactionButton";
            TransactionButton.Size = new Size(110, 23);
            TransactionButton.TabIndex = 0;
            TransactionButton.Text = "Transaksi";
            TransactionButton.UseVisualStyleBackColor = true;
            TransactionButton.Click += TransaksiBtn_Click;
            // 
            // OperationalButton
            // 
            OperationalButton.Location = new Point(119, 3);
            OperationalButton.Name = "OperationalButton";
            OperationalButton.Size = new Size(110, 23);
            OperationalButton.TabIndex = 1;
            OperationalButton.Text = "Operational";
            OperationalButton.UseVisualStyleBackColor = true;
            OperationalButton.Click += OperationalBtn_Click;
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
            Controls.Add(PageBodyContainer);
            Controls.Add(MenuContainer);
            MainMenuStrip = MenuContainer;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsPage";
            Text = "LaporanPage";
            WindowState = FormWindowState.Maximized;
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            PageBodyContainer.ResumeLayout(false);
            FormContainer.ResumeLayout(false);
            FormContainer.PerformLayout();
            InputContainer.ResumeLayout(false);
            DateStartInputGroup.ResumeLayout(false);
            DateStartInputGroup.PerformLayout();
            DateEndInputGroup.ResumeLayout(false);
            DateEndInputGroup.PerformLayout();
            TypeInputGroup.ResumeLayout(false);
            TypeInputGroup.PerformLayout();
            ListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuContainer;
        private ToolStripMenuItem DashboardMenu;
        private ToolStripMenuItem PenggunaMenu;
        private ToolStripMenuItem KategoriMenu;
        private ToolStripMenuItem TransaksiMenu;
        private ToolStripMenuItem OperationalMenu;
        private ToolStripMenuItem LaporanMenu;
        private ToolStripMenuItem LogoutMenu;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel PageBodyContainer;
        private FlowLayoutPanel ListContainer;
        private Button TransactionButton;
        private DataGridView DataList;
        private Button OperationalButton;
        private FlowLayoutPanel FormContainer;
        private Label FormLabel;
        private Label validationErrorMsg;
        private FlowLayoutPanel InputContainer;
        private FlowLayoutPanel DateStartInputGroup;
        private Label DateStartLabel;
        private DateTimePicker StartDateTimePicker;
        private FlowLayoutPanel DateEndInputGroup;
        private Label DateEndLabel;
        private DateTimePicker EndDateTimePicker;
        private FlowLayoutPanel TypeInputGroup;
        private Label TypeLabel;
        private ComboBox FormatTypeComboBox;
        private Button ExportButton;
        private ToolStripMenuItem TenantMenu;
    }
}