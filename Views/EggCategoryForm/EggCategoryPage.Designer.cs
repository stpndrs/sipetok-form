namespace sipetok_form.Views.EggCategoryForm
{
    partial class EggCategoryPage
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
            CancelBtn = new Button();
            PriceLabel = new Label();
            PriceInputGroup = new FlowLayoutPanel();
            PriceTextField = new TextBox();
            DescriptionLabel = new Label();
            DescriptionTextFiled = new TextBox();
            DescriptionInputGroup = new FlowLayoutPanel();
            NameLabel = new Label();
            NameTextField = new TextBox();
            NameInputGroup = new FlowLayoutPanel();
            ListContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            AddBtn = new Button();
            EggCategoryList = new DataGridView();
            FormLabel = new Label();
            ValidationErrorMsg = new Label();
            FormContainer = new FlowLayoutPanel();
            SaveBtn = new Button();
            Body = new TableLayoutPanel();
            LogoutMenu = new ToolStripMenuItem();
            ReportMenu = new ToolStripMenuItem();
            OperationalMenu = new ToolStripMenuItem();
            TransactionMenu = new ToolStripMenuItem();
            StockMenu = new ToolStripMenuItem();
            EggCategoryMenu = new ToolStripMenuItem();
            UserMenu = new ToolStripMenuItem();
            DashboardMenu = new ToolStripMenuItem();
            TopMenu = new MenuStrip();
            Container = new TableLayoutPanel();
            PriceInputGroup.SuspendLayout();
            DescriptionInputGroup.SuspendLayout();
            NameInputGroup.SuspendLayout();
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EggCategoryList).BeginInit();
            FormContainer.SuspendLayout();
            Body.SuspendLayout();
            TopMenu.SuspendLayout();
            Container.SuspendLayout();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBtn.Location = new Point(33, 533);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(434, 48);
            CancelBtn.TabIndex = 16;
            CancelBtn.Text = "Batalkan";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            PriceLabel.Location = new Point(13, 11);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(48, 20);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "Price";
            // 
            // PriceInputGroup
            // 
            PriceInputGroup.AutoSize = true;
            PriceInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PriceInputGroup.BorderStyle = BorderStyle.FixedSingle;
            PriceInputGroup.Controls.Add(PriceLabel);
            PriceInputGroup.Controls.Add(PriceTextField);
            PriceInputGroup.Dock = DockStyle.Fill;
            PriceInputGroup.FlowDirection = FlowDirection.TopDown;
            PriceInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            PriceInputGroup.Location = new Point(30, 364);
            PriceInputGroup.Margin = new Padding(0, 0, 0, 40);
            PriceInputGroup.Name = "PriceInputGroup";
            PriceInputGroup.Padding = new Padding(10, 11, 10, 11);
            PriceInputGroup.Size = new Size(440, 72);
            PriceInputGroup.TabIndex = 13;
            // 
            // PriceTextField
            // 
            PriceTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            PriceTextField.Location = new Point(13, 34);
            PriceTextField.Name = "PriceTextField";
            PriceTextField.Size = new Size(406, 22);
            PriceTextField.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            DescriptionLabel.Location = new Point(13, 11);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(80, 20);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Deskripsi";
            // 
            // DescriptionTextFiled
            // 
            DescriptionTextFiled.Font = new Font("Microsoft Sans Serif", 7.8F);
            DescriptionTextFiled.Location = new Point(13, 34);
            DescriptionTextFiled.Name = "DescriptionTextFiled";
            DescriptionTextFiled.Size = new Size(406, 22);
            DescriptionTextFiled.TabIndex = 2;
            // 
            // DescriptionInputGroup
            // 
            DescriptionInputGroup.AutoSize = true;
            DescriptionInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DescriptionInputGroup.BorderStyle = BorderStyle.FixedSingle;
            DescriptionInputGroup.Controls.Add(DescriptionLabel);
            DescriptionInputGroup.Controls.Add(DescriptionTextFiled);
            DescriptionInputGroup.Dock = DockStyle.Fill;
            DescriptionInputGroup.FlowDirection = FlowDirection.TopDown;
            DescriptionInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            DescriptionInputGroup.Location = new Point(30, 252);
            DescriptionInputGroup.Margin = new Padding(0, 0, 0, 40);
            DescriptionInputGroup.Name = "DescriptionInputGroup";
            DescriptionInputGroup.Padding = new Padding(10, 11, 10, 11);
            DescriptionInputGroup.Size = new Size(440, 72);
            DescriptionInputGroup.TabIndex = 12;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            NameLabel.Location = new Point(13, 11);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(53, 20);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Nama";
            // 
            // NameTextField
            // 
            NameTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            NameTextField.Location = new Point(13, 34);
            NameTextField.Name = "NameTextField";
            NameTextField.Size = new Size(406, 22);
            NameTextField.TabIndex = 3;
            // 
            // NameInputGroup
            // 
            NameInputGroup.AutoSize = true;
            NameInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NameInputGroup.BorderStyle = BorderStyle.FixedSingle;
            NameInputGroup.Controls.Add(NameLabel);
            NameInputGroup.Controls.Add(NameTextField);
            NameInputGroup.Dock = DockStyle.Fill;
            NameInputGroup.FlowDirection = FlowDirection.TopDown;
            NameInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            NameInputGroup.Location = new Point(30, 140);
            NameInputGroup.Margin = new Padding(0, 0, 0, 40);
            NameInputGroup.Name = "NameInputGroup";
            NameInputGroup.Padding = new Padding(10, 11, 10, 11);
            NameInputGroup.Size = new Size(440, 72);
            NameInputGroup.TabIndex = 10;
            // 
            // ListContainer
            // 
            ListContainer.AutoSize = true;
            ListContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListContainer.Controls.Add(PageLabel);
            ListContainer.Controls.Add(AddBtn);
            ListContainer.Controls.Add(EggCategoryList);
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
            PageLabel.Size = new Size(192, 36);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Kategori telur";
            // 
            // AddBtn
            // 
            AddBtn.AutoSize = true;
            AddBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(3, 54);
            AddBtn.Margin = new Padding(3, 3, 3, 29);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(181, 48);
            AddBtn.TabIndex = 17;
            AddBtn.Text = "Tambah Telur";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += addBtn_Click;
            // 
            // EggCategoryList
            // 
            EggCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EggCategoryList.Location = new Point(3, 134);
            EggCategoryList.Margin = new Padding(3, 3, 50, 3);
            EggCategoryList.MaximumSize = new Size(1793, 787);
            EggCategoryList.Name = "EggCategoryList";
            EggCategoryList.RowHeadersWidth = 51;
            EggCategoryList.Size = new Size(1309, 787);
            EggCategoryList.TabIndex = 3;
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormLabel.ForeColor = SystemColors.ControlText;
            FormLabel.Location = new Point(33, 29);
            FormLabel.Margin = new Padding(3, 0, 3, 15);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(312, 36);
            FormLabel.TabIndex = 1;
            FormLabel.Text = "Kelola Data Pengguna";
            // 
            // ValidationErrorMsg
            // 
            ValidationErrorMsg.AutoSize = true;
            ValidationErrorMsg.BackColor = SystemColors.Control;
            ValidationErrorMsg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidationErrorMsg.ForeColor = Color.Red;
            ValidationErrorMsg.Location = new Point(33, 80);
            ValidationErrorMsg.Margin = new Padding(3, 0, 3, 40);
            ValidationErrorMsg.Name = "ValidationErrorMsg";
            ValidationErrorMsg.Size = new Size(0, 20);
            ValidationErrorMsg.TabIndex = 15;
            // 
            // FormContainer
            // 
            FormContainer.Controls.Add(FormLabel);
            FormContainer.Controls.Add(ValidationErrorMsg);
            FormContainer.Controls.Add(NameInputGroup);
            FormContainer.Controls.Add(DescriptionInputGroup);
            FormContainer.Controls.Add(PriceInputGroup);
            FormContainer.Controls.Add(SaveBtn);
            FormContainer.Controls.Add(CancelBtn);
            FormContainer.FlowDirection = FlowDirection.TopDown;
            FormContainer.Location = new Point(1371, 3);
            FormContainer.Name = "FormContainer";
            FormContainer.Padding = new Padding(30, 29, 30, 29);
            FormContainer.Size = new Size(485, 912);
            FormContainer.TabIndex = 5;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(33, 479);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(434, 48);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Simpan";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Body
            // 
            Body.AutoSize = true;
            Body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Body.ColumnCount = 2;
            Body.ColumnStyles.Add(new ColumnStyle());
            Body.ColumnStyles.Add(new ColumnStyle());
            Body.Controls.Add(ListContainer, 0, 0);
            Body.Controls.Add(FormContainer, 1, 0);
            Body.Location = new Point(3, 35);
            Body.Name = "Body";
            Body.RowCount = 1;
            Body.RowStyles.Add(new RowStyle());
            Body.Size = new Size(1859, 930);
            Body.TabIndex = 7;
            // 
            // LogoutMenu
            // 
            LogoutMenu.Name = "LogoutMenu";
            LogoutMenu.Size = new Size(79, 26);
            LogoutMenu.Text = "Logout";
            // 
            // ReportMenu
            // 
            ReportMenu.Name = "ReportMenu";
            ReportMenu.Size = new Size(90, 26);
            ReportMenu.Text = "Laporan";
            // 
            // OperationalMenu
            // 
            OperationalMenu.Name = "OperationalMenu";
            OperationalMenu.Size = new Size(121, 26);
            OperationalMenu.Text = "Operasional";
            // 
            // TransactionMenu
            // 
            TransactionMenu.Name = "TransactionMenu";
            TransactionMenu.Size = new Size(103, 26);
            TransactionMenu.Text = "Transaksi";
            // 
            // StockMenu
            // 
            StockMenu.Name = "StockMenu";
            StockMenu.Size = new Size(138, 26);
            StockMenu.Text = "Stok & Inventori";
            StockMenu.Click += stokMenu_Click;
            // 
            // EggCategoryMenu
            // 
            EggCategoryMenu.Name = "EggCategoryMenu";
            EggCategoryMenu.Size = new Size(138, 26);
            EggCategoryMenu.Text = "Kategori Telur";
            // 
            // UserMenu
            // 
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(106, 26);
            UserMenu.Text = "Pengguna";
            UserMenu.Click += penggunaMenu_Click;
            // 
            // DashboardMenu
            // 
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(112, 26);
            DashboardMenu.Text = "Dashboard";
            // 
            // TopMenu
            // 
            TopMenu.BackColor = SystemColors.ControlLight;
            TopMenu.Dock = DockStyle.Fill;
            TopMenu.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TopMenu.ImageScalingSize = new Size(20, 20);
            TopMenu.Items.AddRange(new ToolStripItem[] { DashboardMenu, UserMenu, EggCategoryMenu, StockMenu, TransactionMenu, OperationalMenu, ReportMenu, LogoutMenu });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Padding = new Padding(6, 3, 0, 3);
            TopMenu.Size = new Size(1902, 32);
            TopMenu.TabIndex = 6;
            TopMenu.Text = "menuStrip1";
            // 
            // Container
            // 
            Container.ColumnCount = 1;
            Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Container.Controls.Add(TopMenu, 0, 0);
            Container.Controls.Add(Body, 0, 1);
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            Container.RowCount = 2;
            Container.RowStyles.Add(new RowStyle());
            Container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Container.Size = new Size(1902, 1033);
            Container.TabIndex = 1;
            // 
            // EggCategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(Container);
            Name = "EggCategoryPage";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "EggCategoryPage";
            WindowState = FormWindowState.Maximized;
            PriceInputGroup.ResumeLayout(false);
            PriceInputGroup.PerformLayout();
            DescriptionInputGroup.ResumeLayout(false);
            DescriptionInputGroup.PerformLayout();
            NameInputGroup.ResumeLayout(false);
            NameInputGroup.PerformLayout();
            ListContainer.ResumeLayout(false);
            ListContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EggCategoryList).EndInit();
            FormContainer.ResumeLayout(false);
            FormContainer.PerformLayout();
            Body.ResumeLayout(false);
            Body.PerformLayout();
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            Container.ResumeLayout(false);
            Container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelBtn;
        private Label PriceLabel;
        private FlowLayoutPanel PriceInputGroup;
        private Label DescriptionLabel;
        private TextBox DescriptionTextFiled;
        private FlowLayoutPanel DescriptionInputGroup;
        private Label NameLabel;
        private TextBox NameTextField;
        private FlowLayoutPanel NameInputGroup;
        private FlowLayoutPanel ListContainer;
        private Label PageLabel;
        private Button AddBtn;
        private DataGridView EggCategoryList;
        private Label FormLabel;
        private Label ValidationErrorMsg;
        private FlowLayoutPanel FormContainer;
        private Button SaveBtn;
        private TableLayoutPanel Body;
        private ToolStripMenuItem LogoutMenu;
        private ToolStripMenuItem ReportMenu;
        private ToolStripMenuItem OperationalMenu;
        private ToolStripMenuItem TransactionMenu;
        private ToolStripMenuItem StockMenu;
        private ToolStripMenuItem EggCategoryMenu;
        private ToolStripMenuItem UserMenu;
        private ToolStripMenuItem DashboardMenu;
        private MenuStrip TopMenu;
        private TableLayoutPanel Container;
        private TextBox PriceTextField;
    }
}