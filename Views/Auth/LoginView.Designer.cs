namespace sipetok_form.Views.Auth
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
            UsernameLabel = new Label();
            UsernameTextField = new TextBox();
            PasswordTextField = new TextBox();
            PasswordLabel = new Label();
            LoginBtn = new Button();
            PageContainer = new Panel();
            BodyContainer = new TableLayoutPanel();
            LoginContainer = new FlowLayoutPanel();
            PageLabel = new Label();
            PageSubLabel = new Label();
            UsernameInputGroup = new FlowLayoutPanel();
            PasswordInputGroup = new FlowLayoutPanel();
            PageContainer.SuspendLayout();
            BodyContainer.SuspendLayout();
            LoginContainer.SuspendLayout();
            UsernameInputGroup.SuspendLayout();
            PasswordInputGroup.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            UsernameLabel.Location = new Point(13, 11);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(86, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // UsernameTextField
            // 
            UsernameTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            UsernameTextField.Location = new Point(13, 34);
            UsernameTextField.Name = "UsernameTextField";
            UsernameTextField.Size = new Size(406, 22);
            UsernameTextField.TabIndex = 2;
            // 
            // PasswordTextField
            // 
            PasswordTextField.Font = new Font("Microsoft Sans Serif", 7.8F);
            PasswordTextField.Location = new Point(13, 34);
            PasswordTextField.Name = "PasswordTextField";
            PasswordTextField.Size = new Size(406, 22);
            PasswordTextField.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 10.2F);
            PasswordLabel.Location = new Point(13, 11);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(83, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSize = true;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(53, 453);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(406, 48);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Masuk";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PageContainer
            // 
            PageContainer.Controls.Add(BodyContainer);
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Font = new Font("Microsoft Sans Serif", 7.8F);
            PageContainer.Location = new Point(0, 0);
            PageContainer.Name = "PageContainer";
            PageContainer.Size = new Size(1902, 989);
            PageContainer.TabIndex = 6;
            // 
            // BodyContainer
            // 
            BodyContainer.ColumnCount = 1;
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BodyContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            BodyContainer.Controls.Add(LoginContainer, 0, 0);
            BodyContainer.Dock = DockStyle.Fill;
            BodyContainer.Font = new Font("Microsoft Sans Serif", 7.8F);
            BodyContainer.Location = new Point(0, 0);
            BodyContainer.Name = "BodyContainer";
            BodyContainer.RowCount = 1;
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BodyContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 989F));
            BodyContainer.Size = new Size(1902, 989);
            BodyContainer.TabIndex = 8;
            // 
            // LoginContainer
            // 
            LoginContainer.Anchor = AnchorStyles.None;
            LoginContainer.AutoSize = true;
            LoginContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginContainer.BorderStyle = BorderStyle.FixedSingle;
            LoginContainer.Controls.Add(PageLabel);
            LoginContainer.Controls.Add(PageSubLabel);
            LoginContainer.Controls.Add(UsernameInputGroup);
            LoginContainer.Controls.Add(PasswordInputGroup);
            LoginContainer.Controls.Add(LoginBtn);
            LoginContainer.FlowDirection = FlowDirection.TopDown;
            LoginContainer.Font = new Font("Microsoft Sans Serif", 7.8F);
            LoginContainer.Location = new Point(683, 216);
            LoginContainer.Margin = new Padding(10, 11, 10, 11);
            LoginContainer.MaximumSize = new Size(1920, 1079);
            LoginContainer.Name = "LoginContainer";
            LoginContainer.Padding = new Padding(50, 51, 50, 51);
            LoginContainer.Size = new Size(536, 557);
            LoginContainer.TabIndex = 7;
            // 
            // PageLabel
            // 
            PageLabel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PageLabel.Location = new Point(50, 51);
            PageLabel.Margin = new Padding(0);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(410, 60);
            PageLabel.TabIndex = 0;
            PageLabel.Text = "Login Page";
            PageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageSubLabel
            // 
            PageSubLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageSubLabel.Location = new Point(53, 111);
            PageSubLabel.Margin = new Padding(3, 0, 3, 40);
            PageSubLabel.Name = "PageSubLabel";
            PageSubLabel.Size = new Size(407, 75);
            PageSubLabel.TabIndex = 9;
            PageSubLabel.Text = "Masukkan username dan password untuk mengakses aplikasi SIPETOK";
            PageSubLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameInputGroup
            // 
            UsernameInputGroup.AutoSize = true;
            UsernameInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsernameInputGroup.BorderStyle = BorderStyle.FixedSingle;
            UsernameInputGroup.Controls.Add(UsernameLabel);
            UsernameInputGroup.Controls.Add(UsernameTextField);
            UsernameInputGroup.Dock = DockStyle.Fill;
            UsernameInputGroup.FlowDirection = FlowDirection.TopDown;
            UsernameInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            UsernameInputGroup.Location = new Point(50, 226);
            UsernameInputGroup.Margin = new Padding(0, 0, 0, 40);
            UsernameInputGroup.Name = "UsernameInputGroup";
            UsernameInputGroup.Padding = new Padding(10, 11, 10, 11);
            UsernameInputGroup.Size = new Size(434, 72);
            UsernameInputGroup.TabIndex = 8;
            // 
            // PasswordInputGroup
            // 
            PasswordInputGroup.AutoSize = true;
            PasswordInputGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PasswordInputGroup.BorderStyle = BorderStyle.FixedSingle;
            PasswordInputGroup.Controls.Add(PasswordLabel);
            PasswordInputGroup.Controls.Add(PasswordTextField);
            PasswordInputGroup.Dock = DockStyle.Fill;
            PasswordInputGroup.FlowDirection = FlowDirection.TopDown;
            PasswordInputGroup.Font = new Font("Microsoft Sans Serif", 7.8F);
            PasswordInputGroup.Location = new Point(50, 338);
            PasswordInputGroup.Margin = new Padding(0, 0, 0, 40);
            PasswordInputGroup.Name = "PasswordInputGroup";
            PasswordInputGroup.Padding = new Padding(10, 11, 10, 11);
            PasswordInputGroup.Size = new Size(434, 72);
            PasswordInputGroup.TabIndex = 8;
            // 
            // LoginView
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 989);
            Controls.Add(PageContainer);
            MinimumSize = new Size(1917, 1026);
            Name = "LoginView";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            PageContainer.ResumeLayout(false);
            BodyContainer.ResumeLayout(false);
            BodyContainer.PerformLayout();
            LoginContainer.ResumeLayout(false);
            LoginContainer.PerformLayout();
            UsernameInputGroup.ResumeLayout(false);
            UsernameInputGroup.PerformLayout();
            PasswordInputGroup.ResumeLayout(false);
            PasswordInputGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label UsernameLabel;
        private TextBox UsernameTextField;
        private TextBox PasswordTextField;
        private Label PasswordLabel;
        private Button LoginBtn;
        private Panel PageContainer;
        private Label PageLabel;
        private FlowLayoutPanel PasswordInputGroup;
        private FlowLayoutPanel LoginContainer;
        private FlowLayoutPanel UsernameInputGroup;
        private TableLayoutPanel BodyContainer;
        private Label PageSubLabel;
    }
}
