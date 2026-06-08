namespace sipetok_form.Views.Transactions
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.2F);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Poppins", 7.8F);
            txtUsername.Location = new Point(13, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(406, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Poppins", 7.8F);
            txtPassword.Location = new Point(13, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(406, 27);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(53, 478);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(406, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Poppins", 7.8F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 981);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Poppins", 7.8F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1900, 981);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(btnLogin);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel1.Location = new Point(682, 200);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.MaximumSize = new Size(1920, 1080);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(536, 581);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Poppins SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 50);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(410, 60);
            label4.TabIndex = 0;
            label4.Text = "Login Page";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 110);
            label1.Margin = new Padding(3, 0, 3, 40);
            label1.Name = "label1";
            label1.Size = new Size(407, 75);
            label1.TabIndex = 9;
            label1.Text = "Masukkan username dan password untuk mengakses aplikasi SIPETOK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(txtUsername);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel2.Location = new Point(50, 225);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(434, 85);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(txtPassword);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Font = new Font("Poppins", 7.8F);
            flowLayoutPanel3.Location = new Point(50, 350);
            flowLayoutPanel3.Margin = new Padding(0, 0, 0, 40);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(434, 85);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 981);
            Controls.Add(panel1);
            MinimumSize = new Size(1918, 1028);
            Name = "LoginView";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Panel panel1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}
