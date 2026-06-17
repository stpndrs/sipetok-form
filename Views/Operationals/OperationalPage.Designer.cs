namespace sipetok_form.Views.Operationals
{
    partial class OperationalPage
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
            OperationalDateLabel = new Label();
            OperationalDateTimePicker = new DateTimePicker();
            ProductionDateInputGroup = new FlowLayoutPanel();
            OperationalNameLabel = new Label();
            OperationalNameTextField = new TextBox();
            OperationalNameInputGroup = new FlowLayoutPanel();
            OperationalCostLabel = new Label();
            OperationalCostTextField = new TextBox();
            OperationalCostInputGroup = new FlowLayoutPanel();
            ListContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            AddButton = new Button();
            OperationalList = new DataGridView();
            FormLabel = new Label();
            ValidationErrorMessage = new Label();
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
            ProductionDateInputGroup.SuspendLayout();
            OperationalNameInputGroup.SuspendLayout();
            OperationalCostInputGroup.SuspendLayout();
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OperationalList).BeginInit();
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
            CancelButton.Location = new Point(33, 533);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(434, 48);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Batalkan";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OperationalDateLabel
            // 
            OperationalDateLabel.AutoSize = true;
            OperationalDateLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            OperationalDateLabel.Location = new Point(13, 11);
            OperationalDateLabel.Name = "OperationalDateLabel";
            OperationalDateLabel.Size = new Size(163, 20);
            OperationalDateLabel.TabIndex = 1;
            OperationalDateLabel.Text = "Tanggal Operasional";
            // 
            // OperationalDateTimePicker
            // 
            OperationalDateTimePicker.Font = new Font("Microsoft Sans Serif", 7.8F);
            OperationalDateTimePicker.Location = new Point(13, 34);
            OperationalDateTimePicker.Name = "OperationalDateTimePicker";
            OperationalDateTimePicker.Size = new Size(406, 22);
            OperationalDateTimePicker.TabIndex = 2;
            // 
            // ProductionDateInputGroup
            // 
            ProductionDateInputGroup.AutoSize = true;
            ProductionDateInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductionDateInputGroup.BorderStyle = BorderStyle.FixedSingle;
            ProductionDateInputGroup.Controls.Add(OperationalDateLabel);
            ProductionDateInputGroup.Controls.Add(OperationalDateTimePicker);
            ProductionDateInputGroup.Dock = DockStyle.Fill;
            ProductionDateInputGroup.FlowDirection = FlowDirection.TopDown;
            ProductionDateInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            ProductionDateInputGroup.Location = new Point(30, 140);
            ProductionDateInputGroup.Margin = new Padding(0, 0, 0, 40);
            ProductionDateInputGroup.Name = "ProductionDateInputGroup";
            ProductionDateInputGroup.Padding = new Padding(10, 11, 10, 11);
            ProductionDateInputGroup.Size = new Size(440, 72);
            ProductionDateInputGroup.TabIndex = 11;
            // 
            // OperationalNameLabel
            // 
            OperationalNameLabel.AutoSize = true;
            OperationalNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            OperationalNameLabel.Location = new Point(13, 11);
            OperationalNameLabel.Name = "OperationalNameLabel";
            OperationalNameLabel.Size = new Size(148, 20);
            OperationalNameLabel.TabIndex = 4;
            OperationalNameLabel.Text = "Nama Operasional";
            // 
            // OperationalNameTextField
            // 
            OperationalNameTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            OperationalNameTextField.Location = new Point(13, 34);
            OperationalNameTextField.Name = "OperationalNameTextField";
            OperationalNameTextField.Size = new Size(406, 22);
            OperationalNameTextField.TabIndex = 3;
            // 
            // OperationalNameInputGroup
            // 
            OperationalNameInputGroup.AutoSize = true;
            OperationalNameInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OperationalNameInputGroup.BorderStyle = BorderStyle.FixedSingle;
            OperationalNameInputGroup.Controls.Add(OperationalNameLabel);
            OperationalNameInputGroup.Controls.Add(OperationalNameTextField);
            OperationalNameInputGroup.Dock = DockStyle.Fill;
            OperationalNameInputGroup.FlowDirection = FlowDirection.TopDown;
            OperationalNameInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            OperationalNameInputGroup.Location = new Point(30, 252);
            OperationalNameInputGroup.Margin = new Padding(0, 0, 0, 40);
            OperationalNameInputGroup.Name = "OperationalNameInputGroup";
            OperationalNameInputGroup.Padding = new Padding(10, 11, 10, 11);
            OperationalNameInputGroup.Size = new Size(440, 72);
            OperationalNameInputGroup.TabIndex = 10;
            // 
            // OperationalCostLabel
            // 
            OperationalCostLabel.AutoSize = true;
            OperationalCostLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            OperationalCostLabel.Location = new Point(13, 11);
            OperationalCostLabel.Name = "OperationalCostLabel";
            OperationalCostLabel.Size = new Size(146, 20);
            OperationalCostLabel.TabIndex = 1;
            OperationalCostLabel.Text = "Biaya Operasional";
            // 
            // OperationalCostTextField
            // 
            OperationalCostTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            OperationalCostTextField.Location = new Point(13, 34);
            OperationalCostTextField.Name = "OperationalCostTextField";
            OperationalCostTextField.Size = new Size(406, 22);
            OperationalCostTextField.TabIndex = 2;
            // 
            // OperationalCostInputGroup
            // 
            OperationalCostInputGroup.AutoSize = true;
            OperationalCostInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OperationalCostInputGroup.BorderStyle = BorderStyle.FixedSingle;
            OperationalCostInputGroup.Controls.Add(OperationalCostLabel);
            OperationalCostInputGroup.Controls.Add(OperationalCostTextField);
            OperationalCostInputGroup.Dock = DockStyle.Fill;
            OperationalCostInputGroup.FlowDirection = FlowDirection.TopDown;
            OperationalCostInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            OperationalCostInputGroup.Location = new Point(30, 364);
            OperationalCostInputGroup.Margin = new Padding(0, 0, 0, 40);
            OperationalCostInputGroup.Name = "OperationalCostInputGroup";
            OperationalCostInputGroup.Padding = new Padding(10, 11, 10, 11);
            OperationalCostInputGroup.Size = new Size(440, 72);
            OperationalCostInputGroup.TabIndex = 12;
            // 
            // ListContainer
            // 
            ListContainer.AutoSize = true;
            ListContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListContainer.Controls.Add(PageLabel);
            ListContainer.Controls.Add(AddButton);
            ListContainer.Controls.Add(OperationalList);
            ListContainer.FlowDirection = FlowDirection.TopDown;
            ListContainer.Location = new Point(3, 3);
            ListContainer.Name = "ListContainer";
            ListContainer.Size = new Size(1362, 924);
            ListContainer.TabIndex = 6;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ControlText;
            PageLabel.Location = new Point(3, 0);
            PageLabel.Margin = new Padding(3, 0, 3, 15);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(175, 36);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Operasional";
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(3, 54);
            AddButton.Margin = new Padding(3, 3, 3, 29);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(181, 48);
            AddButton.TabIndex = 17;
            AddButton.Text = "Tambah Data";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // OperationalList
            // 
            OperationalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OperationalList.Location = new Point(3, 134);
            OperationalList.Margin = new Padding(3, 3, 50, 3);
            OperationalList.MaximumSize = new Size(1793, 787);
            OperationalList.Name = "OperationalList";
            OperationalList.RowHeadersWidth = 51;
            OperationalList.Size = new Size(1309, 787);
            OperationalList.TabIndex = 3;
            OperationalList.CellContentClick += OperationalList_CellContentClick;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormLabel.ForeColor = SystemColors.ControlText;
            FormLabel.Location = new Point(33, 29);
            FormLabel.Margin = new Padding(3, 0, 3, 15);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(266, 36);
            FormLabel.TabIndex = 1;
            FormLabel.Text = "Kelola Operasional";
            // 
            // validationErrorMsg
            // 
            ValidationErrorMessage.AutoSize = true;
            ValidationErrorMessage.BackColor = SystemColors.Control;
            ValidationErrorMessage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidationErrorMessage.ForeColor = Color.Red;
            ValidationErrorMessage.Location = new Point(33, 80);
            ValidationErrorMessage.Margin = new Padding(3, 0, 3, 40);
            ValidationErrorMessage.Name = "validationErrorMsg";
            ValidationErrorMessage.Size = new Size(0, 20);
            ValidationErrorMessage.TabIndex = 15;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(FormLabel);
            FormContainer.Controls.Add(ValidationErrorMessage);
            FormContainer.Controls.Add(ProductionDateInputGroup);
            FormContainer.Controls.Add(OperationalNameInputGroup);
            FormContainer.Controls.Add(OperationalCostInputGroup);
            FormContainer.Controls.Add(SaveButton);
            FormContainer.Controls.Add(CancelButton);
            FormContainer.FlowDirection = FlowDirection.TopDown;
            FormContainer.Location = new Point(1371, 3);
            FormContainer.Name = "FormContainer";
            FormContainer.Padding = new Padding(30, 29, 30, 29);
            FormContainer.Size = new Size(485, 912);
            FormContainer.TabIndex = 5;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(33, 479);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(434, 48);
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
            PageBodyContainer.Location = new Point(3, 35);
            PageBodyContainer.Name = "PageBodyContainer";
            PageBodyContainer.RowCount = 1;
            PageBodyContainer.RowStyles.Add(new RowStyle());
            PageBodyContainer.Size = new Size(1859, 930);
            PageBodyContainer.TabIndex = 7;
            // 
            // LogoutMenu
            // 
            LogoutMenu.Name = "LogoutMenu";
            LogoutMenu.Size = new Size(79, 26);
            LogoutMenu.Text = "Logout";
            LogoutMenu.Click += HandleClickMenu;
            // 
            // ReportMenu
            // 
            ReportMenu.Name = "ReportMenu";
            ReportMenu.Size = new Size(90, 26);
            ReportMenu.Text = "Laporan";
            ReportMenu.Click += HandleClickMenu;
            // 
            // OperationalMenu
            // 
            OperationalMenu.Name = "OperationalMenu";
            OperationalMenu.Size = new Size(121, 26);
            OperationalMenu.Text = "Operasional";
            OperationalMenu.Click += HandleClickMenu;
            // 
            // TransactionMenu
            // 
            TransactionMenu.Name = "TransactionMenu";
            TransactionMenu.Size = new Size(103, 26);
            TransactionMenu.Text = "Transaksi";
            TransactionMenu.Click += HandleClickMenu;
            // 
            // StockMenu
            // 
            StockMenu.Name = "StockMenu";
            StockMenu.Size = new Size(138, 26);
            StockMenu.Text = "Stok & Inventori";
            StockMenu.Click += HandleClickMenu;
            // 
            // EggCategoryMenu
            // 
            EggCategoryMenu.Name = "EggCategoryMenu";
            EggCategoryMenu.Size = new Size(138, 26);
            EggCategoryMenu.Text = "Kategori Telur";
            EggCategoryMenu.Click += HandleClickMenu;
            // 
            // UserMenu
            // 
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(106, 26);
            UserMenu.Text = "Pengguna";
            UserMenu.Click += HandleClickMenu;
            // 
            // DashboardMenu
            // 
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(112, 26);
            DashboardMenu.Text = "Dashboard";
            DashboardMenu.Click += HandleClickMenu;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ControlLight;
            MenuContainer.Dock = DockStyle.Fill;
            MenuContainer.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuContainer.ImageScalingSize = new Size(20, 20);
            MenuContainer.Items.AddRange(new ToolStripItem[] { DashboardMenu, UserMenu, EggCategoryMenu, StockMenu, TransactionMenu, OperationalMenu, ReportMenu, LogoutMenu });
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(6, 3, 0, 3);
            MenuContainer.Size = new Size(1902, 32);
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
            PageContainer.Name = "PageContainer";
            PageContainer.RowCount = 2;
            PageContainer.RowStyles.Add(new RowStyle());
            PageContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PageContainer.Size = new Size(1902, 1033);
            PageContainer.TabIndex = 1;
            // 
            // OperationalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(PageContainer);
            Name = "OperationalPage";
            Text = "Operasional Tenant";
            WindowState = FormWindowState.Maximized;
            ProductionDateInputGroup.ResumeLayout(false);
            ProductionDateInputGroup.PerformLayout();
            OperationalNameInputGroup.ResumeLayout(false);
            OperationalNameInputGroup.PerformLayout();
            OperationalCostInputGroup.ResumeLayout(false);
            OperationalCostInputGroup.PerformLayout();
            ListContainer.ResumeLayout(false);
            ListContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OperationalList).EndInit();
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
        private Label OperationalDateLabel;
        private DateTimePicker OperationalDateTimePicker;
        private FlowLayoutPanel ProductionDateInputGroup;
        private Label OperationalNameLabel;
        private TextBox OperationalNameTextField;
        private FlowLayoutPanel OperationalNameInputGroup;
        private Label OperationalCostLabel;
        private TextBox OperationalCostTextField;
        private FlowLayoutPanel OperationalCostInputGroup;
        private FlowLayoutPanel ListContainer;
        private Label PageLabel;
        private Button AddButton;
        private DataGridView OperationalList;
        private Label FormLabel;
        private Label ValidationErrorMessage;
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
    }
}
 