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
            ListContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            AddButton = new Button();
            TransactionsList = new DataGridView();
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
            ListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionsList).BeginInit();
            PageBodyContainer.SuspendLayout();
            MenuContainer.SuspendLayout();
            PageContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ListContainer
            // 
            ListContainer.AutoSize = true;
            ListContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListContainer.Controls.Add(PageLabel);
            ListContainer.Controls.Add(AddButton);
            ListContainer.Controls.Add(TransactionsList);
            ListContainer.FlowDirection = FlowDirection.TopDown;
            ListContainer.Location = new Point(3, 3);
            ListContainer.Name = "ListContainer";
            ListContainer.Size = new Size(1846, 925);
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
            PageLabel.Size = new Size(231, 36);
            PageLabel.TabIndex = 2;
            PageLabel.Text = "Daftar Transaksi";
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(3, 54);
            AddButton.Margin = new Padding(3, 3, 3, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(180, 48);
            AddButton.TabIndex = 17;
            AddButton.Text = "Tambah Data";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TransactionsList
            // 
            TransactionsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsList.Location = new Point(3, 135);
            TransactionsList.Margin = new Padding(3, 3, 50, 3);
            TransactionsList.MaximumSize = new Size(1793, 787);
            TransactionsList.Name = "TransactionsList";
            TransactionsList.RowHeadersWidth = 51;
            TransactionsList.Size = new Size(1793, 787);
            TransactionsList.TabIndex = 3;
            // 
            // PageBodyContainer
            // 
            PageBodyContainer.AutoSize = true;
            PageBodyContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PageBodyContainer.ColumnCount = 1;
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle());
            PageBodyContainer.ColumnStyles.Add(new ColumnStyle());
            PageBodyContainer.Controls.Add(ListContainer, 0, 0);
            PageBodyContainer.Location = new Point(3, 33);
            PageBodyContainer.Name = "PageBodyContainer";
            PageBodyContainer.RowCount = 1;
            PageBodyContainer.RowStyles.Add(new RowStyle());
            PageBodyContainer.Size = new Size(1852, 931);
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
            MenuContainer.Size = new Size(1902, 30);
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
            // TransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(PageContainer);
            Name = "TransactionPage";
            Text = "TransactionPage";
            WindowState = FormWindowState.Maximized;
            ListContainer.ResumeLayout(false);
            ListContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionsList).EndInit();
            PageBodyContainer.ResumeLayout(false);
            PageBodyContainer.PerformLayout();
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel ListContainer;
        private Label PageLabel;
        private Button AddButton;
        private DataGridView TransactionsList;
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