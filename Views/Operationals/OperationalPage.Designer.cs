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
            cancelBtn = new Button();
            labelOperationalDate = new Label();
            dtpOperationalDate = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            labelName = new Label();
            txtName = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            labelCost = new Label();
            txtCost = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            addBtn = new Button();
            operationalList = new DataGridView();
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
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)operationalList).BeginInit();
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
            cancelBtn.Click += cancelBtn_Click;
            // 
            // labelOperationalDate
            // 
            labelOperationalDate.AutoSize = true;
            labelOperationalDate.Font = new Font("Microsoft Sans Serif", 10.2F);
            labelOperationalDate.Location = new Point(13, 11);
            labelOperationalDate.Name = "labelOperationalDate";
            labelOperationalDate.Size = new Size(163, 20);
            labelOperationalDate.TabIndex = 1;
            labelOperationalDate.Text = "Tanggal Operasional";
            // 
            // dtpOperationalDate
            // 
            dtpOperationalDate.Font = new Font("Microsoft Sans Serif", 7.8F);
            dtpOperationalDate.Location = new Point(13, 34);
            dtpOperationalDate.Name = "dtpOperationalDate";
            dtpOperationalDate.Size = new Size(406, 22);
            dtpOperationalDate.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(labelOperationalDate);
            flowLayoutPanel4.Controls.Add(dtpOperationalDate);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel4.Location = new Point(30, 140);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel4.Size = new Size(440, 72);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 10.2F);
            labelName.Location = new Point(13, 11);
            labelName.Name = "labelName";
            labelName.Size = new Size(148, 20);
            labelName.TabIndex = 4;
            labelName.Text = "Nama Operasional";
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
            flowLayoutPanel5.Controls.Add(labelName);
            flowLayoutPanel5.Controls.Add(txtName);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel5.Location = new Point(30, 252);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel5.Size = new Size(440, 72);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Microsoft Sans Serif", 10.2F);
            labelCost.Location = new Point(13, 11);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(146, 20);
            labelCost.TabIndex = 1;
            labelCost.Text = "Biaya Operasional";
            // 
            // txtCost
            // 
            txtCost.Font = new Font("Microsoft Sans Serif", 7.8F);
            txtCost.Location = new Point(13, 34);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(406, 22);
            txtCost.TabIndex = 2;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(labelCost);
            flowLayoutPanel6.Controls.Add(txtCost);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Font = new Font("Microsoft Sans Serif", 7.8F);
            flowLayoutPanel6.Location = new Point(30, 364);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel6.Size = new Size(440, 72);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Controls.Add(operationalList);
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
            label1.Size = new Size(175, 36);
            label1.TabIndex = 2;
            label1.Text = "Operasional";
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
            addBtn.Text = "Tambah Data";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // operationalList
            // 
            operationalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operationalList.Location = new Point(3, 134);
            operationalList.Margin = new Padding(3, 3, 50, 3);
            operationalList.MaximumSize = new Size(1793, 787);
            operationalList.Name = "operationalList";
            operationalList.RowHeadersWidth = 51;
            operationalList.Size = new Size(1309, 787);
            operationalList.TabIndex = 3;
            operationalList.CellContentClick += operationalList_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(33, 29);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(266, 36);
            label2.TabIndex = 1;
            label2.Text = "Kelola Operasional";
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
            formPanel.Controls.Add(flowLayoutPanel4);
            formPanel.Controls.Add(flowLayoutPanel5);
            formPanel.Controls.Add(flowLayoutPanel6);
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
            menuLogout.Click += handleClickMenu;
            // 
            // laporanMenu
            // 
            laporanMenu.Name = "laporanMenu";
            laporanMenu.Size = new Size(90, 26);
            laporanMenu.Text = "Laporan";
            laporanMenu.Click += handleClickMenu;
            // 
            // operationalMenu
            // 
            operationalMenu.Name = "operationalMenu";
            operationalMenu.Size = new Size(121, 26);
            operationalMenu.Text = "Operasional";
            operationalMenu.Click += handleClickMenu;
            // 
            // transaksiMenu
            // 
            transaksiMenu.Name = "transaksiMenu";
            transaksiMenu.Size = new Size(103, 26);
            transaksiMenu.Text = "Transaksi";
            transaksiMenu.Click += handleClickMenu;
            // 
            // stokMenu
            // 
            stokMenu.Name = "stokMenu";
            stokMenu.Size = new Size(138, 26);
            stokMenu.Text = "Stok & Inventori";
            stokMenu.Click += handleClickMenu;
            // 
            // kategoriMenu
            // 
            kategoriMenu.Name = "kategoriMenu";
            kategoriMenu.Size = new Size(138, 26);
            kategoriMenu.Text = "Kategori Telur";
            kategoriMenu.Click += handleClickMenu;
            // 
            // penggunaMenu
            // 
            penggunaMenu.Name = "penggunaMenu";
            penggunaMenu.Size = new Size(106, 26);
            penggunaMenu.Text = "Pengguna";
            penggunaMenu.Click += handleClickMenu;
            // 
            // dashboardMenu
            // 
            dashboardMenu.Name = "dashboardMenu";
            dashboardMenu.Size = new Size(112, 26);
            dashboardMenu.Text = "Dashboard";
            dashboardMenu.Click += handleClickMenu;
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
            // OperationalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(container);
            Name = "OperationalPage";
            Text = "Operasional Tenant";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)operationalList).EndInit();
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
        private Label labelOperationalDate;
        private DateTimePicker dtpOperationalDate;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label labelName;
        private TextBox txtName;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelCost;
        private TextBox txtCost;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button addBtn;
        private DataGridView operationalList;
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
    }
}
 