namespace sipetok_form.Views.Transactions
{
    partial class DetailTransactionPage
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
            BodyContainer = new TableLayoutPanel();
            PageContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            TransactionContainer = new TableLayoutPanel();
            TransactionDetailContainer = new FlowLayoutPanel();
            TransactionDetailGroup = new FlowLayoutPanel();
            TransactionDetailLabel = new Label();
            TransactionDetailList = new DataGridView();
            TransactionDataContainer = new FlowLayoutPanel();
            OrderStatusLabelGroup = new FlowLayoutPanel();
            OrderStatusLabel = new Label();
            OrderStatusLabelValue = new Label();
            PaymentStatusLabelGroup = new FlowLayoutPanel();
            PaymentStatusLabel = new Label();
            PaymentStatusLabelValue = new Label();
            DateLabelGroup = new FlowLayoutPanel();
            DateLabel = new Label();
            DateLabelValue = new Label();
            CustomerNameLabelGroup = new FlowLayoutPanel();
            CustomerNameLabel = new Label();
            CustomerNameLabelValue = new Label();
            CustomerPhoneLabelGroup = new FlowLayoutPanel();
            CustomerPhoneLabel = new Label();
            CustomerPhoneLabelValue = new Label();
            TotalPriceLabelGroup = new FlowLayoutPanel();
            TotalPriceLabel = new Label();
            TotalPriceLabelValue = new Label();
            PaymentAmountLabelGroup = new FlowLayoutPanel();
            PaymentAmountLabel = new Label();
            PaymentAmountLabelValue = new Label();
            BodyContainer.SuspendLayout();
            PageContainer.SuspendLayout();
            TransactionContainer.SuspendLayout();
            TransactionDetailContainer.SuspendLayout();
            TransactionDetailGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionDetailList).BeginInit();
            TransactionDataContainer.SuspendLayout();
            OrderStatusLabelGroup.SuspendLayout();
            PaymentStatusLabelGroup.SuspendLayout();
            DateLabelGroup.SuspendLayout();
            CustomerNameLabelGroup.SuspendLayout();
            CustomerPhoneLabelGroup.SuspendLayout();
            TotalPriceLabelGroup.SuspendLayout();
            PaymentAmountLabelGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BodyContainer
            // 
            BodyContainer.ColumnCount = 1;
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyContainer.Controls.Add(PageContainer, 0, 0);
            BodyContainer.Dock = DockStyle.Fill;
            BodyContainer.Location = new Point(0, 0);
            BodyContainer.Name = "BodyContainer";
            BodyContainer.RowCount = 1;
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyContainer.Size = new Size(982, 1033);
            BodyContainer.TabIndex = 2;
            // 
            // PageContainer
            // 
            PageContainer.Controls.Add(PageLabel);
            PageContainer.Controls.Add(TransactionContainer);
            PageContainer.FlowDirection = FlowDirection.TopDown;
            PageContainer.Location = new Point(3, 3);
            PageContainer.Name = "PageContainer";
            PageContainer.Padding = new Padding(10);
            PageContainer.Size = new Size(976, 1027);
            PageContainer.TabIndex = 6;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ControlText;
            PageLabel.Location = new Point(13, 10);
            PageLabel.Margin = new Padding(3, 0, 3, 15);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(256, 53);
            PageLabel.TabIndex = 1;
            PageLabel.Text = "Detail Transaksi";
            // 
            // TransactionContainer
            // 
            TransactionContainer.ColumnCount = 2;
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.85744F));
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.1425552F));
            TransactionContainer.Controls.Add(TransactionDetailContainer, 1, 0);
            TransactionContainer.Controls.Add(TransactionDataContainer, 0, 0);
            TransactionContainer.Location = new Point(13, 81);
            TransactionContainer.Name = "TransactionContainer";
            TransactionContainer.RowCount = 1;
            TransactionContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TransactionContainer.RowStyles.Add(new RowStyle());
            TransactionContainer.Size = new Size(954, 915);
            TransactionContainer.TabIndex = 23;
            // 
            // TransactionDetailContainer
            // 
            TransactionDetailContainer.AutoSize = true;
            TransactionDetailContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionDetailContainer.Controls.Add(TransactionDetailGroup);
            TransactionDetailContainer.Location = new Point(325, 3);
            TransactionDetailContainer.Name = "TransactionDetailContainer";
            TransactionDetailContainer.Size = new Size(626, 890);
            TransactionDetailContainer.TabIndex = 21;
            // 
            // TransactionDetailGroup
            // 
            TransactionDetailGroup.BorderStyle = BorderStyle.FixedSingle;
            TransactionDetailGroup.Controls.Add(TransactionDetailLabel);
            TransactionDetailGroup.Controls.Add(TransactionDetailList);
            TransactionDetailGroup.FlowDirection = FlowDirection.TopDown;
            TransactionDetailGroup.Font = new Font("Poppins", 7.8F);
            TransactionDetailGroup.Location = new Point(0, 0);
            TransactionDetailGroup.Margin = new Padding(0, 0, 0, 40);
            TransactionDetailGroup.Name = "TransactionDetailGroup";
            TransactionDetailGroup.Padding = new Padding(10);
            TransactionDetailGroup.Size = new Size(629, 850);
            TransactionDetailGroup.TabIndex = 18;
            // 
            // TransactionDetailLabel
            // 
            TransactionDetailLabel.AutoSize = true;
            TransactionDetailLabel.Font = new Font("Poppins", 10.2F);
            TransactionDetailLabel.Location = new Point(13, 10);
            TransactionDetailLabel.Name = "TransactionDetailLabel";
            TransactionDetailLabel.Size = new Size(119, 30);
            TransactionDetailLabel.TabIndex = 1;
            TransactionDetailLabel.Text = "Item Belanja";
            // 
            // TransactionDetailList
            // 
            TransactionDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionDetailList.Location = new Point(13, 43);
            TransactionDetailList.Name = "TransactionDetailList";
            TransactionDetailList.ReadOnly = true;
            TransactionDetailList.RowHeadersWidth = 51;
            TransactionDetailList.Size = new Size(612, 791);
            TransactionDetailList.TabIndex = 2;
            // 
            // TransactionDataContainer
            // 
            TransactionDataContainer.AutoSize = true;
            TransactionDataContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionDataContainer.Controls.Add(OrderStatusLabelGroup);
            TransactionDataContainer.Controls.Add(PaymentStatusLabelGroup);
            TransactionDataContainer.Controls.Add(DateLabelGroup);
            TransactionDataContainer.Controls.Add(CustomerNameLabelGroup);
            TransactionDataContainer.Controls.Add(CustomerPhoneLabelGroup);
            TransactionDataContainer.Controls.Add(TotalPriceLabelGroup);
            TransactionDataContainer.Controls.Add(PaymentAmountLabelGroup);
            TransactionDataContainer.FlowDirection = FlowDirection.TopDown;
            TransactionDataContainer.Location = new Point(3, 3);
            TransactionDataContainer.Name = "TransactionDataContainer";
            TransactionDataContainer.Size = new Size(306, 878);
            TransactionDataContainer.TabIndex = 20;
            // 
            // OrderStatusLabelGroup
            // 
            OrderStatusLabelGroup.AutoSize = true;
            OrderStatusLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OrderStatusLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            OrderStatusLabelGroup.Controls.Add(OrderStatusLabel);
            OrderStatusLabelGroup.Controls.Add(OrderStatusLabelValue);
            OrderStatusLabelGroup.FlowDirection = FlowDirection.TopDown;
            OrderStatusLabelGroup.Font = new Font("Poppins", 7.8F);
            OrderStatusLabelGroup.Location = new Point(0, 0);
            OrderStatusLabelGroup.Margin = new Padding(0, 0, 0, 40);
            OrderStatusLabelGroup.Name = "OrderStatusLabelGroup";
            OrderStatusLabelGroup.Padding = new Padding(10);
            OrderStatusLabelGroup.Size = new Size(160, 82);
            OrderStatusLabelGroup.TabIndex = 16;
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Font = new Font("Poppins", 10.2F);
            OrderStatusLabel.Location = new Point(13, 10);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new Size(118, 30);
            OrderStatusLabel.TabIndex = 1;
            OrderStatusLabel.Text = "Status Order";
            // 
            // OrderStatusLabelValue
            // 
            OrderStatusLabelValue.AutoSize = true;
            OrderStatusLabelValue.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderStatusLabelValue.Location = new Point(13, 40);
            OrderStatusLabelValue.Name = "OrderStatusLabelValue";
            OrderStatusLabelValue.Size = new Size(132, 30);
            OrderStatusLabelValue.TabIndex = 2;
            OrderStatusLabelValue.Text = "Order Status";
            // 
            // PaymentStatusLabelGroup
            // 
            PaymentStatusLabelGroup.AutoSize = true;
            PaymentStatusLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PaymentStatusLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            PaymentStatusLabelGroup.Controls.Add(PaymentStatusLabel);
            PaymentStatusLabelGroup.Controls.Add(PaymentStatusLabelValue);
            PaymentStatusLabelGroup.FlowDirection = FlowDirection.TopDown;
            PaymentStatusLabelGroup.Font = new Font("Poppins", 7.8F);
            PaymentStatusLabelGroup.Location = new Point(0, 122);
            PaymentStatusLabelGroup.Margin = new Padding(0, 0, 0, 40);
            PaymentStatusLabelGroup.Name = "PaymentStatusLabelGroup";
            PaymentStatusLabelGroup.Padding = new Padding(10);
            PaymentStatusLabelGroup.Size = new Size(190, 82);
            PaymentStatusLabelGroup.TabIndex = 15;
            // 
            // PaymentStatusLabel
            // 
            PaymentStatusLabel.AutoSize = true;
            PaymentStatusLabel.Font = new Font("Poppins", 10.2F);
            PaymentStatusLabel.Location = new Point(13, 10);
            PaymentStatusLabel.Name = "PaymentStatusLabel";
            PaymentStatusLabel.Size = new Size(148, 30);
            PaymentStatusLabel.TabIndex = 1;
            PaymentStatusLabel.Text = "Status Payment";
            // 
            // PaymentStatusLabelValue
            // 
            PaymentStatusLabelValue.AutoSize = true;
            PaymentStatusLabelValue.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentStatusLabelValue.Location = new Point(13, 40);
            PaymentStatusLabelValue.Name = "PaymentStatusLabelValue";
            PaymentStatusLabelValue.Size = new Size(162, 30);
            PaymentStatusLabelValue.TabIndex = 2;
            PaymentStatusLabelValue.Text = "Payment Status";
            // 
            // DateLabelGroup
            // 
            DateLabelGroup.AutoSize = true;
            DateLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DateLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            DateLabelGroup.Controls.Add(DateLabel);
            DateLabelGroup.Controls.Add(DateLabelValue);
            DateLabelGroup.FlowDirection = FlowDirection.TopDown;
            DateLabelGroup.Font = new Font("Poppins", 7.8F);
            DateLabelGroup.Location = new Point(0, 244);
            DateLabelGroup.Margin = new Padding(0, 0, 0, 40);
            DateLabelGroup.Name = "DateLabelGroup";
            DateLabelGroup.Padding = new Padding(10);
            DateLabelGroup.Size = new Size(250, 82);
            DateLabelGroup.TabIndex = 11;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Poppins", 10.2F);
            DateLabel.Location = new Point(13, 10);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(81, 30);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Tanggal";
            // 
            // DateLabelValue
            // 
            DateLabelValue.AutoSize = true;
            DateLabelValue.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabelValue.Location = new Point(13, 40);
            DateLabelValue.Name = "DateLabelValue";
            DateLabelValue.Size = new Size(222, 30);
            DateLabelValue.TabIndex = 2;
            DateLabelValue.Text = "Tanggal Pembayaran";
            // 
            // CustomerNameLabelGroup
            // 
            CustomerNameLabelGroup.AutoSize = true;
            CustomerNameLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerNameLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerNameLabelGroup.Controls.Add(CustomerNameLabel);
            CustomerNameLabelGroup.Controls.Add(CustomerNameLabelValue);
            CustomerNameLabelGroup.FlowDirection = FlowDirection.TopDown;
            CustomerNameLabelGroup.Font = new Font("Poppins", 7.8F);
            CustomerNameLabelGroup.Location = new Point(0, 366);
            CustomerNameLabelGroup.Margin = new Padding(0, 0, 0, 40);
            CustomerNameLabelGroup.Name = "CustomerNameLabelGroup";
            CustomerNameLabelGroup.Padding = new Padding(10);
            CustomerNameLabelGroup.Size = new Size(213, 88);
            CustomerNameLabelGroup.TabIndex = 10;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Poppins", 10.2F);
            CustomerNameLabel.Location = new Point(13, 10);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(155, 30);
            CustomerNameLabel.TabIndex = 4;
            CustomerNameLabel.Text = "Nama Customer";
            // 
            // CustomerNameLabelValue
            // 
            CustomerNameLabelValue.AutoSize = true;
            CustomerNameLabelValue.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabelValue.Location = new Point(13, 40);
            CustomerNameLabelValue.Name = "CustomerNameLabelValue";
            CustomerNameLabelValue.Size = new Size(185, 36);
            CustomerNameLabelValue.TabIndex = 5;
            CustomerNameLabelValue.Text = "Nama Customer";
            // 
            // CustomerPhoneLabelGroup
            // 
            CustomerPhoneLabelGroup.AutoSize = true;
            CustomerPhoneLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerPhoneLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneLabelGroup.Controls.Add(CustomerPhoneLabel);
            CustomerPhoneLabelGroup.Controls.Add(CustomerPhoneLabelValue);
            CustomerPhoneLabelGroup.FlowDirection = FlowDirection.TopDown;
            CustomerPhoneLabelGroup.Font = new Font("Poppins", 7.8F);
            CustomerPhoneLabelGroup.Location = new Point(0, 494);
            CustomerPhoneLabelGroup.Margin = new Padding(0, 0, 0, 40);
            CustomerPhoneLabelGroup.Name = "CustomerPhoneLabelGroup";
            CustomerPhoneLabelGroup.Padding = new Padding(10);
            CustomerPhoneLabelGroup.Size = new Size(306, 88);
            CustomerPhoneLabelGroup.TabIndex = 12;
            // 
            // CustomerPhoneLabel
            // 
            CustomerPhoneLabel.AutoSize = true;
            CustomerPhoneLabel.Font = new Font("Poppins", 10.2F);
            CustomerPhoneLabel.Location = new Point(13, 10);
            CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            CustomerPhoneLabel.Size = new Size(234, 30);
            CustomerPhoneLabel.TabIndex = 1;
            CustomerPhoneLabel.Text = "Nomor Telepon Customer";
            // 
            // CustomerPhoneLabelValue
            // 
            CustomerPhoneLabelValue.AutoSize = true;
            CustomerPhoneLabelValue.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneLabelValue.Location = new Point(13, 40);
            CustomerPhoneLabelValue.Name = "CustomerPhoneLabelValue";
            CustomerPhoneLabelValue.Size = new Size(278, 36);
            CustomerPhoneLabelValue.TabIndex = 2;
            CustomerPhoneLabelValue.Text = "Nomor Telepon Customer";
            // 
            // TotalPriceLabelGroup
            // 
            TotalPriceLabelGroup.AutoSize = true;
            TotalPriceLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TotalPriceLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            TotalPriceLabelGroup.Controls.Add(TotalPriceLabel);
            TotalPriceLabelGroup.Controls.Add(TotalPriceLabelValue);
            TotalPriceLabelGroup.FlowDirection = FlowDirection.TopDown;
            TotalPriceLabelGroup.Font = new Font("Poppins", 7.8F);
            TotalPriceLabelGroup.Location = new Point(0, 622);
            TotalPriceLabelGroup.Margin = new Padding(0, 0, 0, 40);
            TotalPriceLabelGroup.Name = "TotalPriceLabelGroup";
            TotalPriceLabelGroup.Padding = new Padding(10);
            TotalPriceLabelGroup.Size = new Size(165, 88);
            TotalPriceLabelGroup.TabIndex = 13;
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Poppins", 10.2F);
            TotalPriceLabel.Location = new Point(13, 10);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(110, 30);
            TotalPriceLabel.TabIndex = 1;
            TotalPriceLabel.Text = "Total Harga";
            // 
            // TotalPriceLabelValue
            // 
            TotalPriceLabelValue.AutoSize = true;
            TotalPriceLabelValue.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLabelValue.Location = new Point(13, 40);
            TotalPriceLabelValue.Name = "TotalPriceLabelValue";
            TotalPriceLabelValue.Size = new Size(137, 36);
            TotalPriceLabelValue.TabIndex = 2;
            TotalPriceLabelValue.Text = "Total Harga";
            // 
            // PaymentAmountLabelGroup
            // 
            PaymentAmountLabelGroup.AutoSize = true;
            PaymentAmountLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PaymentAmountLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            PaymentAmountLabelGroup.Controls.Add(PaymentAmountLabel);
            PaymentAmountLabelGroup.Controls.Add(PaymentAmountLabelValue);
            PaymentAmountLabelGroup.FlowDirection = FlowDirection.TopDown;
            PaymentAmountLabelGroup.Font = new Font("Poppins", 7.8F);
            PaymentAmountLabelGroup.Location = new Point(0, 750);
            PaymentAmountLabelGroup.Margin = new Padding(0, 0, 0, 40);
            PaymentAmountLabelGroup.Name = "PaymentAmountLabelGroup";
            PaymentAmountLabelGroup.Padding = new Padding(10);
            PaymentAmountLabelGroup.Size = new Size(261, 88);
            PaymentAmountLabelGroup.TabIndex = 14;
            // 
            // PaymentAmountLabel
            // 
            PaymentAmountLabel.AutoSize = true;
            PaymentAmountLabel.Font = new Font("Poppins", 10.2F);
            PaymentAmountLabel.Location = new Point(13, 10);
            PaymentAmountLabel.Name = "PaymentAmountLabel";
            PaymentAmountLabel.Size = new Size(178, 30);
            PaymentAmountLabel.TabIndex = 1;
            PaymentAmountLabel.Text = "Jumlah Dibayarkan";
            // 
            // PaymentAmountLabelValue
            // 
            PaymentAmountLabelValue.AutoSize = true;
            PaymentAmountLabelValue.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentAmountLabelValue.Location = new Point(13, 40);
            PaymentAmountLabelValue.Name = "PaymentAmountLabelValue";
            PaymentAmountLabelValue.Size = new Size(233, 36);
            PaymentAmountLabelValue.TabIndex = 2;
            PaymentAmountLabelValue.Text = "Jumlah Dibayarkan";
            // 
            // DetailTransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1033);
            Controls.Add(BodyContainer);
            Name = "DetailTransactionPage";
            Text = "DetailTransactionPage";
            BodyContainer.ResumeLayout(false);
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            TransactionContainer.ResumeLayout(false);
            TransactionContainer.PerformLayout();
            TransactionDetailContainer.ResumeLayout(false);
            TransactionDetailGroup.ResumeLayout(false);
            TransactionDetailGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionDetailList).EndInit();
            TransactionDataContainer.ResumeLayout(false);
            TransactionDataContainer.PerformLayout();
            OrderStatusLabelGroup.ResumeLayout(false);
            OrderStatusLabelGroup.PerformLayout();
            PaymentStatusLabelGroup.ResumeLayout(false);
            PaymentStatusLabelGroup.PerformLayout();
            DateLabelGroup.ResumeLayout(false);
            DateLabelGroup.PerformLayout();
            CustomerNameLabelGroup.ResumeLayout(false);
            CustomerNameLabelGroup.PerformLayout();
            CustomerPhoneLabelGroup.ResumeLayout(false);
            CustomerPhoneLabelGroup.PerformLayout();
            TotalPriceLabelGroup.ResumeLayout(false);
            TotalPriceLabelGroup.PerformLayout();
            PaymentAmountLabelGroup.ResumeLayout(false);
            PaymentAmountLabelGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BodyContainer;
        private FlowLayoutPanel PageContainer;
        private Label PageLabel;
        private TableLayoutPanel TransactionContainer;
        private FlowLayoutPanel TransactionDetailContainer;
        private FlowLayoutPanel TransactionDetailGroup;
        private Label TransactionDetailLabel;
        private DataGridView TransactionDetailList;
        private FlowLayoutPanel TransactionDataContainer;
        private FlowLayoutPanel DateLabelGroup;
        private Label DateLabel;
        private Label DateLabelValue;
        private FlowLayoutPanel CustomerNameLabelGroup;
        private Label CustomerNameLabel;
        private Label CustomerNameLabelValue;
        private FlowLayoutPanel CustomerPhoneLabelGroup;
        private Label CustomerPhoneLabel;
        private Label CustomerPhoneLabelValue;
        private FlowLayoutPanel TotalPriceLabelGroup;
        private Label TotalPriceLabel;
        private Label TotalPriceLabelValue;
        private FlowLayoutPanel PaymentAmountLabelGroup;
        private Label PaymentAmountLabel;
        private Label PaymentAmountLabelValue;
        private FlowLayoutPanel PaymentStatusLabelGroup;
        private Label PaymentStatusLabel;
        private Label PaymentStatusLabelValue;
        private FlowLayoutPanel OrderStatusLabelGroup;
        private Label OrderStatusLabel;
        private Label OrderStatusLabelValue;
    }
}