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
            PayButton = new Button();
            CustomerPhonelLabel = new Label();
            CustomerNameLabel = new Label();
            DateLabel = new Label();
            TransactionDataContainer = new FlowLayoutPanel();
            DateLabelGroup = new FlowLayoutPanel();
            DateValueLabel = new Label();
            CustomerNameLabelGroup = new FlowLayoutPanel();
            CustomerNameLabelValue = new Label();
            CustomerPhoneLabelGroup = new FlowLayoutPanel();
            CustomerPhoneLabelValue = new Label();
            TotalPriceLabelGroup = new FlowLayoutPanel();
            CustomerPriceLabel = new Label();
            CustomerPriceLabelValue = new Label();
            PaymentAmountInputGroup = new FlowLayoutPanel();
            PaymentAmountLabel = new Label();
            PaymentAmountTextField = new TextBox();
            CancelButton = new Button();
            TransactionDetailLabel = new Label();
            TransactionDetailContainer = new FlowLayoutPanel();
            TransactionDetailList = new DataGridView();
            TransactionDetailGroup = new FlowLayoutPanel();
            ValidationErrorMessageLabel = new Label();
            TransactionContainer = new TableLayoutPanel();
            PageLabel = new Label();
            PageContainer = new FlowLayoutPanel();
            BodyContainer = new TableLayoutPanel();
            TransactionDataContainer.SuspendLayout();
            DateLabelGroup.SuspendLayout();
            CustomerNameLabelGroup.SuspendLayout();
            CustomerPhoneLabelGroup.SuspendLayout();
            TotalPriceLabelGroup.SuspendLayout();
            PaymentAmountInputGroup.SuspendLayout();
            TransactionDetailContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionDetailList).BeginInit();
            TransactionDetailGroup.SuspendLayout();
            TransactionContainer.SuspendLayout();
            PageContainer.SuspendLayout();
            BodyContainer.SuspendLayout();
            SuspendLayout();
            // 
            // PayButton
            // 
            PayButton.AutoSize = true;
            PayButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PayButton.Location = new Point(3, 585);
            PayButton.Margin = new Padding(3, 2, 3, 2);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(267, 30);
            PayButton.TabIndex = 19;
            PayButton.Text = "Simpan Pembayaran";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // CustomerPhonelLabel
            // 
            CustomerPhonelLabel.AutoSize = true;
            CustomerPhonelLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            CustomerPhonelLabel.Location = new Point(12, 8);
            CustomerPhonelLabel.Name = "CustomerPhonelLabel";
            CustomerPhonelLabel.Size = new Size(170, 17);
            CustomerPhonelLabel.TabIndex = 1;
            CustomerPhonelLabel.Text = "Nomor Telepon Customer";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            CustomerNameLabel.Location = new Point(12, 8);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(109, 17);
            CustomerNameLabel.TabIndex = 4;
            CustomerNameLabel.Text = "Nama Customer";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            DateLabel.Location = new Point(12, 8);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(60, 17);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Tanggal";
            // 
            // TransactionDataContainer
            // 
            TransactionDataContainer.AutoSize = true;
            TransactionDataContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionDataContainer.Controls.Add(DateLabelGroup);
            TransactionDataContainer.Controls.Add(CustomerNameLabelGroup);
            TransactionDataContainer.Controls.Add(CustomerPhoneLabelGroup);
            TransactionDataContainer.Controls.Add(TotalPriceLabelGroup);
            TransactionDataContainer.Controls.Add(PaymentAmountInputGroup);
            TransactionDataContainer.FlowDirection = FlowDirection.TopDown;
            TransactionDataContainer.Location = new Point(3, 2);
            TransactionDataContainer.Margin = new Padding(3, 2, 3, 2);
            TransactionDataContainer.Name = "TransactionDataContainer";
            TransactionDataContainer.Size = new Size(267, 425);
            TransactionDataContainer.TabIndex = 20;
            // 
            // DateLabelGroup
            // 
            DateLabelGroup.AutoSize = true;
            DateLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DateLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            DateLabelGroup.Controls.Add(DateLabel);
            DateLabelGroup.Controls.Add(DateValueLabel);
            DateLabelGroup.FlowDirection = FlowDirection.TopDown;
            DateLabelGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            DateLabelGroup.Location = new Point(0, 0);
            DateLabelGroup.Margin = new Padding(0, 0, 0, 30);
            DateLabelGroup.Name = "DateLabelGroup";
            DateLabelGroup.Padding = new Padding(9, 8, 9, 8);
            DateLabelGroup.Size = new Size(188, 52);
            DateLabelGroup.TabIndex = 11;
            // 
            // DateValueLabel
            // 
            DateValueLabel.AutoSize = true;
            DateValueLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateValueLabel.Location = new Point(12, 25);
            DateValueLabel.Name = "DateValueLabel";
            DateValueLabel.Size = new Size(162, 17);
            DateValueLabel.TabIndex = 2;
            DateValueLabel.Text = "Tanggal Pembayaran";
            // 
            // CustomerNameLabelGroup
            // 
            CustomerNameLabelGroup.AutoSize = true;
            CustomerNameLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerNameLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerNameLabelGroup.Controls.Add(CustomerNameLabel);
            CustomerNameLabelGroup.Controls.Add(CustomerNameLabelValue);
            CustomerNameLabelGroup.FlowDirection = FlowDirection.TopDown;
            CustomerNameLabelGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            CustomerNameLabelGroup.Location = new Point(0, 82);
            CustomerNameLabelGroup.Margin = new Padding(0, 0, 0, 30);
            CustomerNameLabelGroup.Name = "CustomerNameLabelGroup";
            CustomerNameLabelGroup.Padding = new Padding(9, 8, 9, 8);
            CustomerNameLabelGroup.Size = new Size(163, 55);
            CustomerNameLabelGroup.TabIndex = 10;
            // 
            // CustomerNameLabelValue
            // 
            CustomerNameLabelValue.AutoSize = true;
            CustomerNameLabelValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabelValue.Location = new Point(12, 25);
            CustomerNameLabelValue.Name = "CustomerNameLabelValue";
            CustomerNameLabelValue.Size = new Size(137, 20);
            CustomerNameLabelValue.TabIndex = 5;
            CustomerNameLabelValue.Text = "Nama Customer";
            // 
            // CustomerPhoneLabelGroup
            // 
            CustomerPhoneLabelGroup.AutoSize = true;
            CustomerPhoneLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerPhoneLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneLabelGroup.Controls.Add(CustomerPhonelLabel);
            CustomerPhoneLabelGroup.Controls.Add(CustomerPhoneLabelValue);
            CustomerPhoneLabelGroup.FlowDirection = FlowDirection.TopDown;
            CustomerPhoneLabelGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            CustomerPhoneLabelGroup.Location = new Point(0, 167);
            CustomerPhoneLabelGroup.Margin = new Padding(0, 0, 0, 30);
            CustomerPhoneLabelGroup.Name = "CustomerPhoneLabelGroup";
            CustomerPhoneLabelGroup.Padding = new Padding(9, 8, 9, 8);
            CustomerPhoneLabelGroup.Size = new Size(238, 55);
            CustomerPhoneLabelGroup.TabIndex = 12;
            // 
            // CustomerPhoneLabelValue
            // 
            CustomerPhoneLabelValue.AutoSize = true;
            CustomerPhoneLabelValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneLabelValue.Location = new Point(12, 25);
            CustomerPhoneLabelValue.Name = "CustomerPhoneLabelValue";
            CustomerPhoneLabelValue.Size = new Size(212, 20);
            CustomerPhoneLabelValue.TabIndex = 2;
            CustomerPhoneLabelValue.Text = "Nomor Telepon Customer";
            // 
            // TotalPriceLabelGroup
            // 
            TotalPriceLabelGroup.AutoSize = true;
            TotalPriceLabelGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TotalPriceLabelGroup.BorderStyle = BorderStyle.FixedSingle;
            TotalPriceLabelGroup.Controls.Add(CustomerPriceLabel);
            TotalPriceLabelGroup.Controls.Add(CustomerPriceLabelValue);
            TotalPriceLabelGroup.FlowDirection = FlowDirection.TopDown;
            TotalPriceLabelGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            TotalPriceLabelGroup.Location = new Point(0, 252);
            TotalPriceLabelGroup.Margin = new Padding(0, 0, 0, 30);
            TotalPriceLabelGroup.Name = "TotalPriceLabelGroup";
            TotalPriceLabelGroup.Padding = new Padding(9, 8, 9, 8);
            TotalPriceLabelGroup.Size = new Size(129, 55);
            TotalPriceLabelGroup.TabIndex = 13;
            // 
            // CustomerPriceLabel
            // 
            CustomerPriceLabel.AutoSize = true;
            CustomerPriceLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            CustomerPriceLabel.Location = new Point(12, 8);
            CustomerPriceLabel.Name = "CustomerPriceLabel";
            CustomerPriceLabel.Size = new Size(83, 17);
            CustomerPriceLabel.TabIndex = 1;
            CustomerPriceLabel.Text = "Total Harga";
            // 
            // CustomerPriceLabelValue
            // 
            CustomerPriceLabelValue.AutoSize = true;
            CustomerPriceLabelValue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPriceLabelValue.Location = new Point(12, 25);
            CustomerPriceLabelValue.Name = "CustomerPriceLabelValue";
            CustomerPriceLabelValue.Size = new Size(103, 20);
            CustomerPriceLabelValue.TabIndex = 2;
            CustomerPriceLabelValue.Text = "Total Harga";
            // 
            // PaymentAmountInputGroup
            // 
            PaymentAmountInputGroup.AutoSize = true;
            PaymentAmountInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PaymentAmountInputGroup.BorderStyle = BorderStyle.FixedSingle;
            PaymentAmountInputGroup.Controls.Add(PaymentAmountLabel);
            PaymentAmountInputGroup.Controls.Add(PaymentAmountTextField);
            PaymentAmountInputGroup.FlowDirection = FlowDirection.TopDown;
            PaymentAmountInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            PaymentAmountInputGroup.Location = new Point(0, 337);
            PaymentAmountInputGroup.Margin = new Padding(0, 0, 0, 30);
            PaymentAmountInputGroup.Name = "PaymentAmountInputGroup";
            PaymentAmountInputGroup.Padding = new Padding(9, 8, 9, 8);
            PaymentAmountInputGroup.Size = new Size(270, 58);
            PaymentAmountInputGroup.TabIndex = 14;
            // 
            // PaymentAmountLabel
            // 
            PaymentAmountLabel.AutoSize = true;
            PaymentAmountLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            PaymentAmountLabel.Location = new Point(12, 8);
            PaymentAmountLabel.Name = "PaymentAmountLabel";
            PaymentAmountLabel.Size = new Size(129, 17);
            PaymentAmountLabel.TabIndex = 1;
            PaymentAmountLabel.Text = "Jumlah Dibayarkan";
            // 
            // PaymentAmountTextField
            // 
            PaymentAmountTextField.Location = new Point(12, 27);
            PaymentAmountTextField.Margin = new Padding(3, 2, 3, 2);
            PaymentAmountTextField.Name = "PaymentAmountTextField";
            PaymentAmountTextField.Size = new Size(244, 19);
            PaymentAmountTextField.TabIndex = 2;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(276, 585);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(430, 30);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Batalkan";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // TransactionDetailLabel
            // 
            TransactionDetailLabel.AutoSize = true;
            TransactionDetailLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            TransactionDetailLabel.Location = new Point(12, 8);
            TransactionDetailLabel.Name = "TransactionDetailLabel";
            TransactionDetailLabel.Size = new Size(85, 17);
            TransactionDetailLabel.TabIndex = 1;
            TransactionDetailLabel.Text = "Item Belanja";
            // 
            // TransactionDetailContainer
            // 
            TransactionDetailContainer.BorderStyle = BorderStyle.FixedSingle;
            TransactionDetailContainer.Controls.Add(TransactionDetailLabel);
            TransactionDetailContainer.Controls.Add(TransactionDetailList);
            TransactionDetailContainer.FlowDirection = FlowDirection.TopDown;
            TransactionDetailContainer.Font = new Font("Microsoft Sans Serif", 7.8F);
            TransactionDetailContainer.Location = new Point(0, 0);
            TransactionDetailContainer.Margin = new Padding(0, 0, 0, 30);
            TransactionDetailContainer.Name = "TransactionDetailContainer";
            TransactionDetailContainer.Padding = new Padding(9, 8, 9, 8);
            TransactionDetailContainer.Size = new Size(551, 572);
            TransactionDetailContainer.TabIndex = 18;
            // 
            // TransactionDetailList
            // 
            TransactionDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionDetailList.Location = new Point(12, 27);
            TransactionDetailList.Margin = new Padding(3, 2, 3, 2);
            TransactionDetailList.Name = "TransactionDetailList";
            TransactionDetailList.RowHeadersWidth = 51;
            TransactionDetailList.Size = new Size(536, 526);
            TransactionDetailList.TabIndex = 2;
            // 
            // TransactionDetailGroup
            // 
            TransactionDetailGroup.AutoSize = true;
            TransactionDetailGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionDetailGroup.Controls.Add(TransactionDetailContainer);
            TransactionDetailGroup.Location = new Point(276, 2);
            TransactionDetailGroup.Margin = new Padding(3, 2, 3, 2);
            TransactionDetailGroup.Name = "TransactionDetailGroup";
            TransactionDetailGroup.Size = new Size(551, 579);
            TransactionDetailGroup.TabIndex = 21;
            // 
            // ValidationErrorMessageLabel
            // 
            ValidationErrorMessageLabel.AutoSize = true;
            ValidationErrorMessageLabel.BackColor = SystemColors.Control;
            ValidationErrorMessageLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidationErrorMessageLabel.ForeColor = Color.Red;
            ValidationErrorMessageLabel.Location = new Point(12, 48);
            ValidationErrorMessageLabel.Margin = new Padding(3, 0, 3, 30);
            ValidationErrorMessageLabel.Name = "ValidationErrorMessageLabel";
            ValidationErrorMessageLabel.Size = new Size(0, 17);
            ValidationErrorMessageLabel.TabIndex = 15;
            // 
            // TransactionContainer
            // 
            TransactionContainer.ColumnCount = 2;
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.69461F));
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.30539F));
            TransactionContainer.Controls.Add(TransactionDetailGroup, 1, 0);
            TransactionContainer.Controls.Add(TransactionDataContainer, 0, 0);
            TransactionContainer.Controls.Add(CancelButton, 1, 1);
            TransactionContainer.Controls.Add(PayButton, 0, 1);
            TransactionContainer.Location = new Point(12, 97);
            TransactionContainer.Margin = new Padding(3, 2, 3, 2);
            TransactionContainer.Name = "TransactionContainer";
            TransactionContainer.RowCount = 2;
            TransactionContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TransactionContainer.RowStyles.Add(new RowStyle());
            TransactionContainer.Size = new Size(835, 617);
            TransactionContainer.TabIndex = 23;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.ControlText;
            PageLabel.Location = new Point(12, 8);
            PageLabel.Margin = new Padding(3, 0, 3, 11);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(185, 29);
            PageLabel.TabIndex = 1;
            PageLabel.Text = "Bayar Transaksi";
            // 
            // PageContainer
            // 
            PageContainer.Controls.Add(PageLabel);
            PageContainer.Controls.Add(ValidationErrorMessageLabel);
            PageContainer.Controls.Add(TransactionContainer);
            PageContainer.FlowDirection = FlowDirection.TopDown;
            PageContainer.Location = new Point(3, 2);
            PageContainer.Margin = new Padding(3, 2, 3, 2);
            PageContainer.Name = "PageContainer";
            PageContainer.Padding = new Padding(9, 8, 9, 8);
            PageContainer.Size = new Size(853, 770);
            PageContainer.TabIndex = 6;
            // 
            // BodyContainer
            // 
            BodyContainer.ColumnCount = 1;
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyContainer.Controls.Add(PageContainer, 0, 0);
            BodyContainer.Dock = DockStyle.Fill;
            BodyContainer.Location = new Point(0, 0);
            BodyContainer.Margin = new Padding(3, 2, 3, 2);
            BodyContainer.Name = "BodyContainer";
            BodyContainer.RowCount = 1;
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BodyContainer.Size = new Size(859, 775);
            BodyContainer.TabIndex = 1;
            // 
            // PayTransactionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 775);
            Controls.Add(BodyContainer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PayTransactionPage";
            Text = "PayTransactionPage";
            TransactionDataContainer.ResumeLayout(false);
            TransactionDataContainer.PerformLayout();
            DateLabelGroup.ResumeLayout(false);
            DateLabelGroup.PerformLayout();
            CustomerNameLabelGroup.ResumeLayout(false);
            CustomerNameLabelGroup.PerformLayout();
            CustomerPhoneLabelGroup.ResumeLayout(false);
            CustomerPhoneLabelGroup.PerformLayout();
            TotalPriceLabelGroup.ResumeLayout(false);
            TotalPriceLabelGroup.PerformLayout();
            PaymentAmountInputGroup.ResumeLayout(false);
            PaymentAmountInputGroup.PerformLayout();
            TransactionDetailContainer.ResumeLayout(false);
            TransactionDetailContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionDetailList).EndInit();
            TransactionDetailGroup.ResumeLayout(false);
            TransactionContainer.ResumeLayout(false);
            TransactionContainer.PerformLayout();
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            BodyContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button PayButton;
        private Label CustomerPhonelLabel;
        private Label CustomerNameLabel;
        private Label DateLabel;
        private FlowLayoutPanel TransactionDataContainer;
        private FlowLayoutPanel DateLabelGroup;
        private FlowLayoutPanel CustomerNameLabelGroup;
        private FlowLayoutPanel CustomerPhoneLabelGroup;
        private Button CancelButton;
        private Label TransactionDetailLabel;
        private FlowLayoutPanel TransactionDetailContainer;
        private FlowLayoutPanel TransactionDetailGroup;
        private Label ValidationErrorMessageLabel;
        private TableLayoutPanel TransactionContainer;
        private Label PageLabel;
        private FlowLayoutPanel PageContainer;
        private TableLayoutPanel BodyContainer;
        private Label DateValueLabel;
        private Label CustomerNameLabelValue;
        private Label CustomerPhoneLabelValue;
        private DataGridView TransactionDetailList;
        private FlowLayoutPanel TotalPriceLabelGroup;
        private Label CustomerPriceLabel;
        private Label CustomerPriceLabelValue;
        private FlowLayoutPanel PaymentAmountInputGroup;
        private Label PaymentAmountLabel;
        private TextBox PaymentAmountTextField;
    }
}