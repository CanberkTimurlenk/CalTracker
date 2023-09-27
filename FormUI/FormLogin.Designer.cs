namespace FormUI
{
    partial class FormLogin
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
            label6 = new Label();
            label5 = new Label();
            clearButton = new Button();
            loginButton = new Button();
            checkboxShowPass = new CheckBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(165, 177, 194);
            label6.Location = new Point(99, 425);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 19;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 386);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 20;
            label5.Text = "Dont Have an Account";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(32, 191, 107);
            clearButton.Location = new Point(38, 331);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(218, 34);
            clearButton.TabIndex = 4;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(32, 191, 107);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(38, 285);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(218, 28);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Cursor = Cursors.Hand;
            checkboxShowPass.FlatStyle = FlatStyle.Flat;
            checkboxShowPass.Location = new Point(137, 232);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(119, 21);
            checkboxShowPass.TabIndex = 2;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(38, 102);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(218, 28);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 72);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 191, 107);
            label3.Location = new Point(33, 19);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 6;
            label3.Text = "Get Started";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(38, 177);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(218, 28);
            txtPassword.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(249, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(28, 25);
            kryptonButton1.StatePressed.Back.Color1 = Color.Red;
            kryptonButton1.StatePressed.Back.Color2 = Color.Red;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(255, 128, 128);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(255, 128, 128);
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 128);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 128);
            kryptonButton1.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateTracking.Border.ColorAngle = 1F;
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 21;
            kryptonButton1.Values.Text = "X";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 477);
            ControlBox = false;
            Controls.Add(kryptonButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(checkboxShowPass);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button clearButton;
        private Button loginButton;
        private CheckBox checkboxShowPass;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Label label3;
        private TextBox txtPassword;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}