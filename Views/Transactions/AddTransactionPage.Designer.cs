namespace sipetok_form.Views.Transactions
{
    partial class AddTransactionPage
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
            ValidationErrorMessageLabel = new Label();
            TransactionContainer = new TableLayoutPanel();
            TransactionItemsGroup = new FlowLayoutPanel();
            TransactionItemsContainer = new FlowLayoutPanel();
            TransactionDetailLabel = new Label();
            AddItemButton = new Button();
            TransactionDataContainer = new FlowLayoutPanel();
            DateInputGroup = new FlowLayoutPanel();
            DateInputLabel = new Label();
            DateTimePicker = new DateTimePicker();
            CustomerNameInputGroup = new FlowLayoutPanel();
            CustomerNameLabel = new Label();
            CustomerNameTextField = new TextBox();
            CustomerPhoneNumberInputGroup = new FlowLayoutPanel();
            CustomerPhoneNumberLabel = new Label();
            CustomerPhoneNumbeTextField = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            BodyContainer.SuspendLayout();
            PageContainer.SuspendLayout();
            TransactionContainer.SuspendLayout();
            TransactionItemsGroup.SuspendLayout();
            TransactionItemsContainer.SuspendLayout();
            TransactionDataContainer.SuspendLayout();
            DateInputGroup.SuspendLayout();
            CustomerNameInputGroup.SuspendLayout();
            CustomerPhoneNumberInputGroup.SuspendLayout();
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
            BodyContainer.TabIndex = 0;
            // 
            // PageContainer
            // 
            PageContainer.Controls.Add(PageLabel);
            PageContainer.Controls.Add(ValidationErrorMessageLabel);
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
            PageLabel.Size = new Size(297, 53);
            PageLabel.TabIndex = 1;
            PageLabel.Text = "Tambah Transaksi";
            // 
            // ValidationErrorMessageLabel
            // 
            ValidationErrorMessageLabel.AutoSize = true;
            ValidationErrorMessageLabel.BackColor = SystemColors.Control;
            ValidationErrorMessageLabel.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidationErrorMessageLabel.ForeColor = Color.Red;
            ValidationErrorMessageLabel.Location = new Point(13, 78);
            ValidationErrorMessageLabel.Margin = new Padding(3, 0, 3, 40);
            ValidationErrorMessageLabel.Name = "ValidationErrorMessageLabel";
            ValidationErrorMessageLabel.Size = new Size(0, 30);
            ValidationErrorMessageLabel.TabIndex = 15;
            // 
            // TransactionContainer
            // 
            TransactionContainer.ColumnCount = 2;
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.16981F));
            TransactionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.83019F));
            TransactionContainer.Controls.Add(TransactionItemsGroup, 1, 0);
            TransactionContainer.Controls.Add(TransactionDataContainer, 0, 0);
            TransactionContainer.Controls.Add(CancelButton, 1, 1);
            TransactionContainer.Controls.Add(SaveButton, 0, 1);
            TransactionContainer.Location = new Point(13, 151);
            TransactionContainer.Name = "TransactionContainer";
            TransactionContainer.RowCount = 2;
            TransactionContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TransactionContainer.RowStyles.Add(new RowStyle());
            TransactionContainer.Size = new Size(954, 823);
            TransactionContainer.TabIndex = 23;
            // 
            // TransactionItemsGroup
            // 
            TransactionItemsGroup.AutoSize = true;
            TransactionItemsGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionItemsGroup.Controls.Add(TransactionItemsContainer);
            TransactionItemsGroup.Controls.Add(AddItemButton);
            TransactionItemsGroup.Location = new Point(453, 3);
            TransactionItemsGroup.Name = "TransactionItemsGroup";
            TransactionItemsGroup.Size = new Size(494, 771);
            TransactionItemsGroup.TabIndex = 21;
            // 
            // TransactionItemsContainer
            // 
            TransactionItemsContainer.BorderStyle = BorderStyle.FixedSingle;
            TransactionItemsContainer.Controls.Add(TransactionDetailLabel);
            TransactionItemsContainer.FlowDirection = FlowDirection.TopDown;
            TransactionItemsContainer.Font = new Font("Poppins", 7.8F);
            TransactionItemsContainer.Location = new Point(0, 0);
            TransactionItemsContainer.Margin = new Padding(0, 0, 0, 40);
            TransactionItemsContainer.Name = "TransactionItemsContainer";
            TransactionItemsContainer.Padding = new Padding(10);
            TransactionItemsContainer.Size = new Size(491, 680);
            TransactionItemsContainer.TabIndex = 18;
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
            // AddItemButton
            // 
            AddItemButton.AutoSize = true;
            AddItemButton.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemButton.Location = new Point(3, 723);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(488, 48);
            AddItemButton.TabIndex = 9;
            AddItemButton.Text = "Tambah Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // TransactionDataContainer
            // 
            TransactionDataContainer.AutoSize = true;
            TransactionDataContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TransactionDataContainer.Controls.Add(DateInputGroup);
            TransactionDataContainer.Controls.Add(CustomerNameInputGroup);
            TransactionDataContainer.Controls.Add(CustomerPhoneNumberInputGroup);
            TransactionDataContainer.Location = new Point(3, 3);
            TransactionDataContainer.Name = "TransactionDataContainer";
            TransactionDataContainer.Size = new Size(434, 375);
            TransactionDataContainer.TabIndex = 20;
            // 
            // DateInputGroup
            // 
            DateInputGroup.AutoSize = true;
            DateInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DateInputGroup.BorderStyle = BorderStyle.FixedSingle;
            DateInputGroup.Controls.Add(DateInputLabel);
            DateInputGroup.Controls.Add(DateTimePicker);
            DateInputGroup.FlowDirection = FlowDirection.TopDown;
            DateInputGroup.Font = new Font("Poppins", 7.8F);
            DateInputGroup.Location = new Point(0, 0);
            DateInputGroup.Margin = new Padding(0, 0, 0, 40);
            DateInputGroup.Name = "DateInputGroup";
            DateInputGroup.Padding = new Padding(10);
            DateInputGroup.Size = new Size(434, 85);
            DateInputGroup.TabIndex = 11;
            // 
            // DateInputLabel
            // 
            DateInputLabel.AutoSize = true;
            DateInputLabel.Font = new Font("Poppins", 10.2F);
            DateInputLabel.Location = new Point(13, 10);
            DateInputLabel.Name = "DateInputLabel";
            DateInputLabel.Size = new Size(81, 30);
            DateInputLabel.TabIndex = 1;
            DateInputLabel.Text = "Tanggal";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(13, 43);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(406, 27);
            DateTimePicker.TabIndex = 3;
            // 
            // CustomerNameInputGroup
            // 
            CustomerNameInputGroup.AutoSize = true;
            CustomerNameInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerNameInputGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerNameInputGroup.Controls.Add(CustomerNameLabel);
            CustomerNameInputGroup.Controls.Add(CustomerNameTextField);
            CustomerNameInputGroup.FlowDirection = FlowDirection.TopDown;
            CustomerNameInputGroup.Font = new Font("Poppins", 7.8F);
            CustomerNameInputGroup.Location = new Point(0, 125);
            CustomerNameInputGroup.Margin = new Padding(0, 0, 0, 40);
            CustomerNameInputGroup.Name = "CustomerNameInputGroup";
            CustomerNameInputGroup.Padding = new Padding(10);
            CustomerNameInputGroup.Size = new Size(434, 85);
            CustomerNameInputGroup.TabIndex = 10;
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
            // CustomerNameTextField
            // 
            CustomerNameTextField.Font = new Font("Poppins", 7.8F);
            CustomerNameTextField.Location = new Point(13, 43);
            CustomerNameTextField.Name = "CustomerNameTextField";
            CustomerNameTextField.Size = new Size(406, 27);
            CustomerNameTextField.TabIndex = 3;
            // 
            // CustomerPhoneNumberInputGroup
            // 
            CustomerPhoneNumberInputGroup.AutoSize = true;
            CustomerPhoneNumberInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerPhoneNumberInputGroup.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneNumberInputGroup.Controls.Add(CustomerPhoneNumberLabel);
            CustomerPhoneNumberInputGroup.Controls.Add(CustomerPhoneNumbeTextField);
            CustomerPhoneNumberInputGroup.FlowDirection = FlowDirection.TopDown;
            CustomerPhoneNumberInputGroup.Font = new Font("Poppins", 7.8F);
            CustomerPhoneNumberInputGroup.Location = new Point(0, 250);
            CustomerPhoneNumberInputGroup.Margin = new Padding(0, 0, 0, 40);
            CustomerPhoneNumberInputGroup.Name = "CustomerPhoneNumberInputGroup";
            CustomerPhoneNumberInputGroup.Padding = new Padding(10);
            CustomerPhoneNumberInputGroup.Size = new Size(434, 85);
            CustomerPhoneNumberInputGroup.TabIndex = 12;
            // 
            // CustomerPhoneNumberLabel
            // 
            CustomerPhoneNumberLabel.AutoSize = true;
            CustomerPhoneNumberLabel.Font = new Font("Poppins", 10.2F);
            CustomerPhoneNumberLabel.Location = new Point(13, 10);
            CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            CustomerPhoneNumberLabel.Size = new Size(234, 30);
            CustomerPhoneNumberLabel.TabIndex = 1;
            CustomerPhoneNumberLabel.Text = "Nomor Telepon Customer";
            // 
            // CustomerPhoneNumbeTextField
            // 
            CustomerPhoneNumbeTextField.Font = new Font("Poppins", 7.8F);
            CustomerPhoneNumbeTextField.Location = new Point(13, 43);
            CustomerPhoneNumbeTextField.Name = "CustomerPhoneNumbeTextField";
            CustomerPhoneNumbeTextField.Size = new Size(406, 27);
            CustomerPhoneNumbeTextField.TabIndex = 2;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(453, 780);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(491, 40);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Batalkan";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(3, 780);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(432, 40);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Simpan";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddTransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1033);
            Controls.Add(BodyContainer);
            Name = "AddTransactionPage";
            Text = "AddTransactionPage";
            BodyContainer.ResumeLayout(false);
            PageContainer.ResumeLayout(false);
            PageContainer.PerformLayout();
            TransactionContainer.ResumeLayout(false);
            TransactionContainer.PerformLayout();
            TransactionItemsGroup.ResumeLayout(false);
            TransactionItemsGroup.PerformLayout();
            TransactionItemsContainer.ResumeLayout(false);
            TransactionItemsContainer.PerformLayout();
            TransactionDataContainer.ResumeLayout(false);
            TransactionDataContainer.PerformLayout();
            DateInputGroup.ResumeLayout(false);
            DateInputGroup.PerformLayout();
            CustomerNameInputGroup.ResumeLayout(false);
            CustomerNameInputGroup.PerformLayout();
            CustomerPhoneNumberInputGroup.ResumeLayout(false);
            CustomerPhoneNumberInputGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BodyContainer;
        private FlowLayoutPanel PageContainer;
        private Label PageLabel;
        private Label ValidationErrorMessageLabel;
        private Button CancelButton;
        private Button SaveButton;
        private FlowLayoutPanel TransactionDataContainer;
        private FlowLayoutPanel DateInputGroup;
        private Label DateInputLabel;
        private DateTimePicker DateTimePicker;
        private FlowLayoutPanel CustomerNameInputGroup;
        private Label CustomerNameLabel;
        private TextBox CustomerNameTextField;
        private FlowLayoutPanel CustomerPhoneNumberInputGroup;
        private Label CustomerPhoneNumberLabel;
        private TextBox CustomerPhoneNumbeTextField;
        private FlowLayoutPanel TransactionItemsGroup;
        private FlowLayoutPanel TransactionItemsContainer;
        private Label TransactionDetailLabel;
        private Button AddItemButton;
        private TableLayoutPanel TransactionContainer;
    }
}