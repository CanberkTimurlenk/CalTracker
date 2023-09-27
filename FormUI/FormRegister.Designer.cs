namespace FormUI
{
    partial class FormRegister
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
            label3 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtComPassword = new TextBox();
            checkBox1 = new CheckBox();
            checkboxShowPass = new CheckBox();
            registrationButton = new Button();
            clearButton = new Button();
            label5 = new Label();
            label6 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 191, 107);
            label3.Location = new Point(25, 30);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 0;
            label3.Text = "Get Started";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 83);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(30, 113);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(218, 28);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 159);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(30, 189);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 28);
            textBox2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(30, 189);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(218, 28);
            txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 232);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 1;
            label4.Text = "Confirm Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(30, 262);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(218, 28);
            txtComPassword.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(126, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Cursor = Cursors.Hand;
            checkboxShowPass.FlatStyle = FlatStyle.Flat;
            checkboxShowPass.Location = new Point(126, 296);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(119, 21);
            checkboxShowPass.TabIndex = 3;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.FromArgb(32, 191, 107);
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(30, 351);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(218, 28);
            registrationButton.TabIndex = 4;
            registrationButton.Text = "CONTINUE";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.Enabled = false;
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(32, 191, 107);
            clearButton.Location = new Point(30, 398);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(218, 28);
            clearButton.TabIndex = 4;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 438);
            label5.Name = "label5";
            label5.Size = new Size(161, 17);
            label5.TabIndex = 5;
            label5.Text = "Already have an Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(165, 177, 194);
            label6.Location = new Point(91, 464);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 5;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click_1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(245, 12);
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
            kryptonButton1.TabIndex = 22;
            kryptonButton1.Values.Text = "X";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 513);
            ControlBox = false;
            Controls.Add(kryptonButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clearButton);
            Controls.Add(registrationButton);
            Controls.Add(checkboxShowPass);
            Controls.Add(checkBox1);
            Controls.Add(txtComPassword);
            Controls.Add(txtPassword);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox textBox2;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtComPassword;
        private CheckBox checkBox1;
        private CheckBox checkboxShowPass;
        private Button registrationButton;
        private Button clearButton;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }



}
