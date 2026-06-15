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
            cancelBtn = new Button();
            label5 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            txtPrice = new TextBox();
            Description = new Label();
            txtDescription = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label4 = new Label();
            txtName = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            addBtn = new Button();
            EggCategoryList = new DataGridView();
            label2 = new Label();
            validationErrorMsg = new Label();
            formPanel = new FlowLayoutPanel();
            btnSave = new Button();
            body = new TableLayoutPanel();
            menuLogout = new ToolStripMenuItem();
            laporanMenu = new ToolStripMenuItem();
            operationalMenu = new ToolStripMenuItem();
            transaksiMenu = new ToolStripMenuItem();
            stokMenu = new ToolStripMenuItem();
            kategoriMenu = new ToolStripMenuItem();
            penggunaMenu = new ToolStripMenuItem();
            dashboardMenu = new ToolStripMenuItem();
            topMenu = new MenuStrip();
            container = new TableLayoutPanel();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EggCategoryList).BeginInit();
            formPanel.SuspendLayout();
            body.SuspendLayout();
            topMenu.SuspendLayout();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(33, 533);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(434, 48);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Batalkan";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 1;
            label5.Text = "Price";
            label5.Click += label5_Click;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Controls.Add(label5);
            flowLayoutPanel7.Controls.Add(txtPrice);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel7.Location = new Point(30, 364);
            flowLayoutPanel7.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel7.Size = new Size(440, 72);
            flowLayoutPanel7.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtPrice.Location = new Point(13, 34);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(406, 22);
            txtPrice.TabIndex = 3;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Microsoft Sans Serif", 10.2F);
            Description.Location = new Point(13, 11);
            Description.Name = "Description";
            Description.Size = new Size(80, 20);
            Description.TabIndex = 1;
            Description.Text = "Deskripsi";
            Description.Click += Email_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtDescription.Location = new Point(13, 34);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(406, 22);
            txtDescription.TabIndex = 2;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(Description);
            flowLayoutPanel6.Controls.Add(txtDescription);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel6.Location = new Point(30, 252);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel6.Size = new Size(440, 72);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(13, 11);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Nama";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtName.Location = new Point(13, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(406, 22);
            txtName.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(txtName);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel5.Location = new Point(30, 140);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel5.Size = new Size(440, 72);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Controls.Add(EggCategoryList);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1362, 924);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 2;
            label1.Text = "Kategori telur";
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(3, 54);
            addBtn.Margin = new Padding(3, 3, 3, 29);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(181, 48);
            addBtn.TabIndex = 17;
            addBtn.Text = "Tambah Telur";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(33, 29);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(312, 36);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Pengguna";
            // 
            // validationErrorMsg
            // 
            validationErrorMsg.AutoSize = true;
            validationErrorMsg.BackColor = SystemColors.Control;
            validationErrorMsg.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationErrorMsg.ForeColor = Color.Red;
            validationErrorMsg.Location = new Point(33, 80);
            validationErrorMsg.Margin = new Padding(3, 0, 3, 40);
            validationErrorMsg.Name = "validationErrorMsg";
            validationErrorMsg.Size = new Size(0, 20);
            validationErrorMsg.TabIndex = 15;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(flowLayoutPanel5);
            formPanel.Controls.Add(flowLayoutPanel6);
            formPanel.Controls.Add(flowLayoutPanel7);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(cancelBtn);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(1371, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(30, 29, 30, 29);
            formPanel.Size = new Size(485, 912);
            formPanel.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(33, 479);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(434, 48);
            btnSave.TabIndex = 9;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // body
            // 
            body.AutoSize = true;
            body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            body.ColumnCount = 2;
            body.ColumnStyles.Add(new ColumnStyle());
            body.ColumnStyles.Add(new ColumnStyle());
            body.Controls.Add(flowLayoutPanel1, 0, 0);
            body.Controls.Add(formPanel, 1, 0);
            body.Location = new Point(3, 35);
            body.Name = "body";
            body.RowCount = 1;
            body.RowStyles.Add(new RowStyle());
            body.Size = new Size(1859, 930);
            body.TabIndex = 7;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(79, 26);
            menuLogout.Text = "Logout";
            // 
            // laporanMenu
            // 
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(90, 26);
            laporanMenu.Text = "Laporan";
            // 
            // operationalMenu
            // 
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(121, 26);
            operationalMenu.Text = "Operasional";
            // 
            // transaksiMenu
            // 
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(103, 26);
            transaksiMenu.Text = "Transaksi";
            // 
            // stokMenu
            // 
            stokMenu.Name = "stokMenu";
            stokMenu.Size = new Size(138, 26);
            stokMenu.Text = "Stok & Inventori";
            stokMenu.Click += stokMenu_Click;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(138, 26);
            kategoriMenu.Text = "Kategori Telur";
            // 
            // penggunaMenu
            // 
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(106, 26);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += penggunaMenu_Click;
            // 
            // dashboardMenu
            // 
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(112, 26);
            dashboardMenu.Text = "Dashboard";
            // 
            // topMenu
            // 
            topMenu.BackColor = SystemColors.ControlLight;
            topMenu.Dock = DockStyle.Fill;
            topMenu.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topMenu.ImageScalingSize = new Size(20, 20);
            topMenu.Items.AddRange(new ToolStripItem[] { dashboardMenu, penggunaMenu, kategoriMenu, stokMenu, transaksiMenu, operationalMenu, laporanMenu, menuLogout });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.Padding = new Padding(6, 3, 0, 3);
            topMenu.Size = new Size(1902, 32);
            topMenu.TabIndex = 6;
            topMenu.Text = "menuStrip1";
            // 
            // container
            // 
            container.ColumnCount = 1;
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.Controls.Add(topMenu, 0, 0);
            container.Controls.Add(body, 0, 1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.RowCount = 2;
            container.RowStyles.Add(new RowStyle());
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.Size = new Size(1902, 1033);
            container.TabIndex = 1;
            // 
            // EggCategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(container);
            Name = "EggCategoryPage";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "EggCategoryPage";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EggCategoryList).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            body.ResumeLayout(false);
            body.PerformLayout();
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelBtn;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label Description;
        private TextBox txtDescription;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private TextBox txtName;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button addBtn;
        private DataGridView EggCategoryList;
        private Label label2;
        private Label validationErrorMsg;
        private FlowLayoutPanel formPanel;
        private Button btnSave;
        private TableLayoutPanel body;
        private ToolStripMenuItem menuLogout;
        private ToolStripMenuItem laporanMenu;
        private ToolStripMenuItem operationalMenu;
        private ToolStripMenuItem transaksiMenu;
        private ToolStripMenuItem stokMenu;
        private ToolStripMenuItem kategoriMenu;
        private ToolStripMenuItem penggunaMenu;
        private ToolStripMenuItem dashboardMenu;
        private MenuStrip topMenu;
        private TableLayoutPanel container;
        private TextBox txtPrice;
    }
}