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
            tableLayoutPanel1 = new TableLayoutPanel();
            formPanel = new FlowLayoutPanel();
            label2 = new Label();
            validationErrorMsg = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flpContainer = new FlowLayoutPanel();
            label5 = new Label();
            btnAddItem = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            dtDate = new DateTimePicker();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            txtCustomerName = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            Email = new Label();
            txtCustomerPhoneNumber = new TextBox();
            cancelBtn = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            formPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flpContainer.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(13, 10);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(297, 53);
            label2.TabIndex = 1;
            label2.Text = "Tambah Transaksi";
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.16981F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.83019F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelBtn, 1, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 1);
            tableLayoutPanel2.Location = new Point(13, 151);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(954, 823);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(flpContainer);
            flowLayoutPanel2.Controls.Add(btnAddItem);
            flowLayoutPanel2.Location = new Point(453, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(494, 771);
            flowLayoutPanel2.TabIndex = 21;
            // 
            // flpContainer
            // 
            flpContainer.BorderStyle = BorderStyle.FixedSingle;
            flpContainer.Controls.Add(label5);
            flpContainer.FlowDirection = FlowDirection.TopDown;
            flpContainer.Font = new Font("Poppins", 7.8F);
            flpContainer.Location = new Point(0, 0);
            flpContainer.Margin = new Padding(0, 0, 0, 40);
            flpContainer.Name = "flpContainer";
            flpContainer.Padding = new Padding(10);
            flpContainer.Size = new Size(491, 680);
            flpContainer.TabIndex = 18;
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
            // btnAddItem
            // 
            btnAddItem.AutoSize = true;
            btnAddItem.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(3, 723);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(488, 48);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Tambah Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(434, 375);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(dtDate);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(434, 85);
            flowLayoutPanel4.TabIndex = 11;
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
            // dtDate
            // 
            dtDate.Location = new Point(13, 43);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(406, 27);
            dtDate.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(txtCustomerName);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel5.Location = new Point(0, 125);
            flowLayoutPanel5.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(10);
            flowLayoutPanel5.Size = new Size(434, 85);
            flowLayoutPanel5.TabIndex = 10;
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
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Poppins", 7.8F);
            txtCustomerName.Location = new Point(13, 43);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(406, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(Email);
            flowLayoutPanel6.Controls.Add(txtCustomerPhoneNumber);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel6.Location = new Point(0, 250);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(10);
            flowLayoutPanel6.Size = new Size(434, 85);
            flowLayoutPanel6.TabIndex = 12;
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
            // txtCustomerPhoneNumber
            // 
            txtCustomerPhoneNumber.Font = new Font("Poppins", 7.8F);
            txtCustomerPhoneNumber.Location = new Point(13, 43);
            txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            txtCustomerPhoneNumber.Size = new Size(406, 27);
            txtCustomerPhoneNumber.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(453, 780);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(491, 40);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Batalkan";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 780);
            button1.Name = "button1";
            button1.Size = new Size(432, 40);
            button1.TabIndex = 19;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // AddTransactionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "AddTransactionPage";
            Text = "AddTransactionPage";
            tableLayoutPanel1.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flpContainer.ResumeLayout(false);
            flpContainer.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel formPanel;
        private Label label2;
        private Label validationErrorMsg;
        private Button cancelBtn;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private DateTimePicker dtDate;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private TextBox txtCustomerName;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label Email;
        private TextBox txtCustomerPhoneNumber;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flpContainer;
        private Label label5;
        private Button btnAddItem;
        private TableLayoutPanel tableLayoutPanel2;
    }
}