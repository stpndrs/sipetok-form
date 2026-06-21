namespace sipetok_form.Views.Eggs
{
    partial class EggStockPage
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
            CancelButton = new Button();
            ProductionDateLabel = new Label();
            ProductionDateTimePicker = new DateTimePicker();
            ProductionDateInputGroup = new FlowLayoutPanel();
            StockLabel = new Label();
            StockTextField = new TextBox();
            StockInputGroup = new FlowLayoutPanel();
            EggCategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            CategoryInputGroup = new FlowLayoutPanel();
            ListContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            AddButton = new Button();
            EggsList = new DataGridView();
            FormLabel = new Label();
            ValidatonErrorMassage = new Label();
            FormContainer = new FlowLayoutPanel();
            SaveButton = new Button();
            PageBodyContainer = new TableLayoutPanel();
            LogoutMenu = new ToolStripMenuItem();
            ReportMenu = new ToolStripMenuItem();
            OperationalMenu = new ToolStripMenuItem();
            TransactionMenu = new ToolStripMenuItem();
            StockMenu = new ToolStripMenuItem();
            EggCategoryMenu = new ToolStripMenuItem();
            UserMenu = new ToolStripMenuItem();
            DashboardMenu = new ToolStripMenuItem();
            MenuContainer = new MenuStrip();
            PageContainer = new TableLayoutPanel();
            TenantMenu = new ToolStripMenuItem();
            ProductionDateInputGroup.SuspendLayout();
            StockInputGroup.SuspendLayout();
            CategoryInputGroup.SuspendLayout();
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EggsList).BeginInit();
            FormContainer.SuspendLayout();
            PageBodyContainer.SuspendLayout();
            MenuContainer.SuspendLayout();
            PageContainer.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(29, 417);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(380, 36);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Batalkan";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ProductionDateLabel
            // 
            ProductionDateLabel.AutoSize = true;
            ProductionDateLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            ProductionDateLabel.Location = new Point(12, 8);
            ProductionDateLabel.Name = "ProductionDateLabel";
            ProductionDateLabel.Size = new Size(119, 17);
            ProductionDateLabel.TabIndex = 1;
            ProductionDateLabel.Text = "Tanggal Produksi";
            // 
            // ProductionDateTimePicker
            // 
            ProductionDateTimePicker.Font = new Font("Microsoft Sans Serif", 7.8F);
            ProductionDateTimePicker.Location = new Point(12, 27);
            ProductionDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            ProductionDateTimePicker.Name = "ProductionDateTimePicker";
            ProductionDateTimePicker.Size = new Size(356, 19);
            ProductionDateTimePicker.TabIndex = 2;
            // 
            // ProductionDateInputGroup
            // 
            ProductionDateInputGroup.AutoSize = true;
            ProductionDateInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductionDateInputGroup.BorderStyle = BorderStyle.FixedSingle;
            ProductionDateInputGroup.Controls.Add(ProductionDateLabel);
            ProductionDateInputGroup.Controls.Add(ProductionDateTimePicker);
            ProductionDateInputGroup.Dock = DockStyle.Fill;
            ProductionDateInputGroup.FlowDirection = FlowDirection.TopDown;
            ProductionDateInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            ProductionDateInputGroup.Location = new Point(26, 109);
            ProductionDateInputGroup.Margin = new Padding(0, 0, 0, 30);
            ProductionDateInputGroup.Name = "ProductionDateInputGroup";
            ProductionDateInputGroup.Padding = new Padding(9, 8, 9, 8);
            ProductionDateInputGroup.Size = new Size(386, 58);
            ProductionDateInputGroup.TabIndex = 11;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            StockLabel.Location = new Point(12, 8);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(36, 17);
            StockLabel.TabIndex = 4;
            StockLabel.Text = "Stok";
            // 
            // StockTextField
            // 
            StockTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            StockTextField.Location = new Point(12, 27);
            StockTextField.Margin = new Padding(3, 2, 3, 2);
            StockTextField.Name = "StockTextField";
            StockTextField.Size = new Size(356, 19);
            StockTextField.TabIndex = 3;
            // 
            // StockInputGroup
            // 
            StockInputGroup.AutoSize = true;
            StockInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StockInputGroup.BorderStyle = BorderStyle.FixedSingle;
            StockInputGroup.Controls.Add(StockLabel);
            StockInputGroup.Controls.Add(StockTextField);
            StockInputGroup.Dock = DockStyle.Fill;
            StockInputGroup.FlowDirection = FlowDirection.TopDown;
            StockInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            StockInputGroup.Location = new Point(26, 197);
            StockInputGroup.Margin = new Padding(0, 0, 0, 30);
            StockInputGroup.Name = "StockInputGroup";
            StockInputGroup.Padding = new Padding(9, 8, 9, 8);
            StockInputGroup.Size = new Size(386, 58);
            StockInputGroup.TabIndex = 10;
            // 
            // EggCategoryLabel
            // 
            EggCategoryLabel.AutoSize = true;
            EggCategoryLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            EggCategoryLabel.Location = new Point(12, 8);
            EggCategoryLabel.Name = "EggCategoryLabel";
            EggCategoryLabel.Size = new Size(98, 17);
            EggCategoryLabel.TabIndex = 1;
            EggCategoryLabel.Text = "Kategori Telur";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.Font = new Font("Microsoft Sans Serif", 7.8F);
            CategoryComboBox.Location = new Point(12, 27);
            CategoryComboBox.Margin = new Padding(3, 2, 3, 2);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(356, 21);
            CategoryComboBox.TabIndex = 2;
            // 
            // CategoryInputGroup
            // 
            CategoryInputGroup.AutoSize = true;
            CategoryInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CategoryInputGroup.BorderStyle = BorderStyle.FixedSingle;
            CategoryInputGroup.Controls.Add(EggCategoryLabel);
            CategoryInputGroup.Controls.Add(CategoryComboBox);
            CategoryInputGroup.Dock = DockStyle.Fill;
            CategoryInputGroup.FlowDirection = FlowDirection.TopDown;
            CategoryInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            CategoryInputGroup.Location = new Point(26, 285);
            CategoryInputGroup.Margin = new Padding(0, 0, 0, 30);
            CategoryInputGroup.Name = "CategoryInputGroup";
            CategoryInputGroup.Padding = new Padding(9, 8, 9, 8);
            CategoryInputGroup.Size = new Size(386, 60);
            CategoryInputGroup.TabIndex = 12;
            // 
            // ListContainer
            // 
            ListContainer.AutoSize = true;
            ListContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListContainer.Controls.Add(PageLabel);
            ListContainer.Controls.Add(AddButton);
            ListContainer.Controls.Add(EggsList);
            ListContainer.FlowDirection = FlowDirection.TopDown;
            ListContainer.Location = new Point(3, 2);
            ListContainer.Margin = new Padding(3, 2, 3, 2);
            ListContainer.Name = "ListContainer";
            ListContainer.Size = new Size(1192, 694);
            ListContainer.TabIndex = 6;
            ListContainer.Paint += flowLayoutPanel1_Paint;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ControlText;
            PageLabel.Location = new Point(3, 0);
            PageLabel.Margin = new Padding(3, 0, 3, 11);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(164, 29);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Stok & Inventori";
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(3, 42);
            AddButton.Margin = new Padding(3, 2, 3, 22);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(158, 36);
            AddButton.TabIndex = 17;
            AddButton.Text = "Tambah Data";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EggsList
            // 
            EggsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EggsList.Location = new Point(3, 102);
            EggsList.Margin = new Padding(3, 2, 44, 2);
            EggsList.MaximumSize = new Size(1569, 590);
            EggsList.Name = "EggsList";
            EggsList.RowHeadersWidth = 51;
            EggsList.Size = new Size(1145, 590);
            EggsList.TabIndex = 3;
            EggsList.CellContentClick += EggList_CellContentClick;
            EggsList.CellFormatting += EggsList_CellFormatting;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormLabel.ForeColor = SystemColors.ControlText;
            FormLabel.Location = new Point(29, 22);
            FormLabel.Margin = new Padding(3, 0, 3, 11);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(199, 29);
            FormLabel.TabIndex = 1;
            FormLabel.Text = "Kelola Stok Telur";
            // 
            // ValidatonErrorMassage
            // 
            ValidatonErrorMassage.AutoSize = true;
            ValidatonErrorMassage.BackColor = SystemColors.Control;
            ValidatonErrorMassage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidatonErrorMassage.ForeColor = Color.Red;
            ValidatonErrorMassage.Location = new Point(29, 62);
            ValidatonErrorMassage.Margin = new Padding(3, 0, 3, 30);
            ValidatonErrorMassage.Name = "ValidatonErrorMassage";
            ValidatonErrorMassage.Size = new Size(0, 17);
            ValidatonErrorMassage.TabIndex = 15;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(FormLabel);
            FormContainer.Controls.Add(ValidatonErrorMassage);
            FormContainer.Controls.Add(ProductionDateInputGroup);
            FormContainer.Controls.Add(StockInputGroup);
            FormContainer.Controls.Add(CategoryInputGroup);
            FormContainer.Controls.Add(SaveButton);
            FormContainer.Controls.Add(CancelButton);
            FormContainer.FlowDirection = FlowDirection.TopDown;
            FormContainer.Location = new Point(1201, 2);
            FormContainer.Margin = new Padding(3, 2, 3, 2);
            FormContainer.Name = "FormContainer";
            FormContainer.Padding = new Padding(26, 22, 26, 22);
            FormContainer.Size = new Size(424, 684);
            FormContainer.TabIndex = 5;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(29, 377);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(380, 36);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Simpan";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
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
            PageBodyContainer.Location = new Point(3, 28);
            PageBodyContainer.Margin = new Padding(3, 2, 3, 2);
            PageBodyContainer.Name = "PageBodyContainer";
            PageBodyContainer.RowCount = 1;
            PageBodyContainer.RowStyles.Add(new RowStyle());
            PageBodyContainer.Size = new Size(1628, 698);
            PageBodyContainer.TabIndex = 7;
            // 
            // LogoutMenu
            // 
            LogoutMenu.Name = "LogoutMenu";
            LogoutMenu.Size = new Size(66, 22);
            LogoutMenu.Text = "Logout";
            LogoutMenu.Click += HandleClickMenu;
            // 
            // ReportMenu
            // 
            ReportMenu.Name = "ReportMenu";
            ReportMenu.Size = new Size(74, 22);
            ReportMenu.Text = "Laporan";
            ReportMenu.Click += HandleClickMenu;
            // 
            // OperationalMenu
            // 
            OperationalMenu.Name = "OperationalMenu";
            OperationalMenu.Size = new Size(100, 22);
            OperationalMenu.Text = "Operasional";
            OperationalMenu.Click += HandleClickMenu;
            // 
            // TransactionMenu
            // 
            TransactionMenu.Name = "TransactionMenu";
            TransactionMenu.Size = new Size(85, 22);
            TransactionMenu.Text = "Transaksi";
            TransactionMenu.Click += HandleClickMenu;
            // 
            // StockMenu
            // 
            StockMenu.Name = "StockMenu";
            StockMenu.Size = new Size(114, 22);
            StockMenu.Text = "Stok & Inventori";
            StockMenu.Click += HandleClickMenu;
            // 
            // EggCategoryMenu
            // 
            EggCategoryMenu.Name = "EggCategoryMenu";
            EggCategoryMenu.Size = new Size(112, 22);
            EggCategoryMenu.Text = "Kategori Telur";
            EggCategoryMenu.Click += HandleClickMenu;
            // 
            // UserMenu
            // 
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(86, 22);
            UserMenu.Text = "Pengguna";
            UserMenu.Click += HandleClickMenu;
            // 
            // DashboardMenu
            // 
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(93, 22);
            DashboardMenu.Text = "Dashboard";
            DashboardMenu.Click += HandleClickMenu;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ControlLight;
            MenuContainer.Dock = DockStyle.Fill;
            MenuContainer.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuContainer.ImageScalingSize = new Size(20, 20);
            MenuContainer.Items.AddRange(new ToolStripItem[] { DashboardMenu, UserMenu, TenantMenu, EggCategoryMenu, StockMenu, TransactionMenu, OperationalMenu, ReportMenu, LogoutMenu });
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(5, 2, 0, 2);
            MenuContainer.Size = new Size(1664, 26);
            MenuContainer.TabIndex = 6;
            MenuContainer.Text = "menuStrip1";
            // 
            // PageContainer
            // 
            PageContainer.ColumnCount = 1;
            PageContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PageContainer.Controls.Add(MenuContainer, 0, 0);
            PageContainer.Controls.Add(PageBodyContainer, 0, 1);
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Location = new Point(0, 0);
            PageContainer.Margin = new Padding(3, 2, 3, 2);
            PageContainer.Name = "PageContainer";
            PageContainer.RowCount = 2;
            PageContainer.RowStyles.Add(new RowStyle());
            PageContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PageContainer.Size = new Size(1664, 775);
            PageContainer.TabIndex = 1;
            // 
            // TenantMenu
            // 
            TenantMenu.Name = "TenantMenu";
            TenantMenu.Size = new Size(65, 22);
            TenantMenu.Text = "Tenant";
            // 
            // EggStockPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(PageContainer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EggStockPage";
            Text = "Stok & Inventori";
            WindowState = FormWindowState.Maximized;
            Load += EggStockPage_Load;
            ProductionDateInputGroup.ResumeLayout(false);
            ProductionDateInputGroup.PerformLayout();
            StockInputGroup.ResumeLayout(false);
            StockInputGroup.PerformLayout();
            CategoryInputGroup.ResumeLayout(false);
            CategoryInputGroup.PerformLayout();
            ListContainer.ResumeLayout(false);
            ListContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EggsList).EndInit();
            FormContainer.ResumeLayout(false);
            FormContainer.PerformLayout();
            PageBodyContainer.ResumeLayout(false);
            PageBodyContainer.PerformLayout();
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button CancelButton;
        private Label ProductionDateLabel;
        private DateTimePicker ProductionDateTimePicker;
        private FlowLayoutPanel ProductionDateInputGroup;
        private Label StockLabel;
        private TextBox StockTextField;
        private FlowLayoutPanel StockInputGroup;
        private Label EggCategoryLabel;
        private ComboBox CategoryComboBox;
        private FlowLayoutPanel CategoryInputGroup;
        private FlowLayoutPanel ListContainer;
        private Label PageLabel;
        private Button AddButton;
        private DataGridView EggsList;
        private Label FormLabel;
        private Label ValidatonErrorMassage;
        private FlowLayoutPanel FormContainer;
        private Button SaveButton;
        private TableLayoutPanel PageBodyContainer;
        private ToolStripMenuItem LogoutMenu;
        private ToolStripMenuItem ReportMenu;
        private ToolStripMenuItem OperationalMenu;
        private ToolStripMenuItem TransactionMenu;
        private ToolStripMenuItem StockMenu;
        private ToolStripMenuItem EggCategoryMenu;
        private ToolStripMenuItem UserMenu;
        private ToolStripMenuItem DashboardMenu;
        private MenuStrip MenuContainer;
        private TableLayoutPanel PageContainer;
        private ToolStripMenuItem TenantMenu;
    }
}