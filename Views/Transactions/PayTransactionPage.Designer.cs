namespace sipetok_form.Views.Transactions
{
    partial class PayTransactionPage
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
            btnPay = new Button();
            Email = new Label();
            label4 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblDate = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            lblCustomerName = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            lblCustomerPhone = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            lblTotalPrice = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label6 = new Label();
            txtPaymentAmount = new TextBox();
            cancelBtn = new Button();
            label5 = new Label();
            flpContainer = new FlowLayoutPanel();
            dgvItems = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            validationErrorMsg = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            formPanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            formPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.AutoSize = true;
            btnPay.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(3, 780);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(316, 40);
            btnPay.TabIndex = 19;
            btnPay.Text = "Simpan Pembayaran";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Poppins", 10.2F);
            Email.Location = new Point(13, 10);
            Email.Name = "Email";
            Email.Size = new Size(234, 30);
            Email.TabIndex = 1;
            Email.Text = "Nomor Telepon Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.2F);
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 4;
            label4.Text = "Nama Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 1;
            label3.Text = "Tanggal";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(306, 631);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(lblDate);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(250, 82);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(13, 40);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(222, 30);
            lblDate.TabIndex = 2;
            lblDate.Text = "Tanggal Pembayaran";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(lblCustomerName);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel5.Location = new Point(0, 122);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(213, 88);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(13, 40);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(185, 36);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Nama Customer";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(Email);
            flowLayoutPanel6.Controls.Add(lblCustomerPhone);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel6.Location = new Point(0, 250);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10);
            flowLayoutPanel6.Size = new Size(306, 88);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerPhone.Location = new Point(13, 40);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(278, 36);
            lblCustomerPhone.TabIndex = 2;
            lblCustomerPhone.Text = "Nomor Telepon Customer";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(lblTotalPrice);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel3.Location = new Point(0, 378);
            flowLayoutPanel3.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(165, 88);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.2F);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "Total Harga";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(13, 40);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(137, 36);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "Total Harga";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Controls.Add(label6);
            flowLayoutPanel7.Controls.Add(txtPaymentAmount);
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel7.Location = new Point(0, 506);
            flowLayoutPanel7.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(10);
            flowLayoutPanel7.Size = new Size(306, 85);
            flowLayoutPanel7.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.2F);
            label6.Location = new Point(13, 10);
            label6.Name = "label6";
            label6.Size = new Size(178, 30);
            label6.TabIndex = 1;
            label6.Text = "Jumlah Dibayarkan";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(13, 43);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(278, 27);
            txtPaymentAmount.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(325, 780);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(491, 40);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Batalkan";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10.2F);
            label5.Location = new Point(13, 10);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 1;
            label5.Text = "Item Belanja";
            // 
            // flpContainer
            // 
            flpContainer.BorderStyle = BorderStyle.FixedSingle;
            flpContainer.Controls.Add(label5);
            flpContainer.Controls.Add(dgvItems);
            flpContainer.FlowDirection = FlowDirection.TopDown;
            flpContainer.Font = new Font("Poppins", 7.8F);
            flpContainer.Location = new Point(0, 0);
            flpContainer.Margin = new Padding(0, 0, 0, 40);
            flpContainer.Name = "flpContainer";
            flpContainer.Padding = new Padding(10);
            flpContainer.Size = new Size(629, 762);
            flpContainer.TabIndex = 18;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(13, 43);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(612, 701);
            dgvItems.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(flpContainer);
            flowLayoutPanel2.Location = new Point(325, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(626, 771);
            flowLayoutPanel2.TabIndex = 21;
            // 
            // validationErrorMsg
            // 
            validationErrorMsg.AutoSize = true;
            validationErrorMsg.BackColor = SystemColors.Control;
            validationErrorMsg.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validationErrorMsg.ForeColor = Color.Red;
            validationErrorMsg.Location = new Point(13, 78);
            validationErrorMsg.Margin = new Padding(3, 0, 3, 40);
            validationErrorMsg.Name = "validationErrorMsg";
            validationErrorMsg.Size = new Size(0, 30);
            validationErrorMsg.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.85744F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.1425552F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelBtn, 1, 1);
            tableLayoutPanel2.Controls.Add(btnPay, 0, 1);
            tableLayoutPanel2.Location = new Point(13, 151);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(954, 823);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(13, 10);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(257, 53);
            label2.TabIndex = 1;
            label2.Text = "Bayar Transaksi";
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(validationErrorMsg);
            formPanel.Controls.Add(tableLayoutPanel2);
            formPanel.FlowDirection = FlowDirection.TopDown;
            formPanel.Location = new Point(3, 3);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(10);
            formPanel.Size = new Size(976, 1027);
            formPanel.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(formPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(982, 1033);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // PayTransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "PayTransactionPage";
            Text = "PayTransactionPage";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flpContainer.ResumeLayout(false);
            flpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPay;
        private Label Email;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button cancelBtn;
        private Label label5;
        private FlowLayoutPanel flpContainer;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label validationErrorMsg;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private FlowLayoutPanel formPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDate;
        private Label lblCustomerName;
        private Label lblCustomerPhone;
        private DataGridView dgvItems;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label1;
        private Label lblTotalPrice;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label6;
        private TextBox txtPaymentAmount;
    }
}