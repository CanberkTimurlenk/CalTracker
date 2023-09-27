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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
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
            bunifuFormControlBox1 = new Bunifu.UI.WinForms.BunifuFormControlBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 78, 165);
            label6.Location = new Point(95, 426);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 19;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 390);
            label5.Name = "label5";
            label5.Size = new Size(189, 23);
            label5.TabIndex = 20;
            label5.Text = "Dont Have an Account";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(116, 86, 174);
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
            loginButton.BackColor = Color.FromArgb(116, 86, 174);
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
            checkboxShowPass.Location = new Point(105, 231);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(151, 27);
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
            label2.Size = new Size(84, 23);
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
            label1.Size = new Size(89, 23);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(33, 19);
            label3.Name = "label3";
            label3.Size = new Size(194, 34);
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
            // bunifuFormControlBox1
            // 
            bunifuFormControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bunifuFormControlBox1.BunifuFormDrag = null;
            bunifuFormControlBox1.CloseBoxOptions.BackColor = Color.Transparent;
            bunifuFormControlBox1.CloseBoxOptions.BorderRadius = 0;
            bunifuFormControlBox1.CloseBoxOptions.Enabled = true;
            bunifuFormControlBox1.CloseBoxOptions.EnableDefaultAction = true;
            bunifuFormControlBox1.CloseBoxOptions.HoverColor = Color.FromArgb(232, 17, 35);
            bunifuFormControlBox1.CloseBoxOptions.Icon = (Image)resources.GetObject("bunifuFormControlBox1.CloseBoxOptions.Icon");
            bunifuFormControlBox1.CloseBoxOptions.IconAlt = null;
            bunifuFormControlBox1.CloseBoxOptions.IconColor = Color.Black;
            bunifuFormControlBox1.CloseBoxOptions.IconHoverColor = Color.White;
            bunifuFormControlBox1.CloseBoxOptions.IconPressedColor = Color.White;
            bunifuFormControlBox1.CloseBoxOptions.IconSize = new Size(18, 18);
            bunifuFormControlBox1.CloseBoxOptions.PressedColor = Color.FromArgb(232, 17, 35);
            bunifuFormControlBox1.HelpBox = false;
            bunifuFormControlBox1.HelpBoxOptions.BackColor = Color.Transparent;
            bunifuFormControlBox1.HelpBoxOptions.BorderRadius = 0;
            bunifuFormControlBox1.HelpBoxOptions.Enabled = true;
            bunifuFormControlBox1.HelpBoxOptions.EnableDefaultAction = true;
            bunifuFormControlBox1.HelpBoxOptions.HoverColor = Color.LightGray;
            bunifuFormControlBox1.HelpBoxOptions.Icon = (Image)resources.GetObject("bunifuFormControlBox1.HelpBoxOptions.Icon");
            bunifuFormControlBox1.HelpBoxOptions.IconAlt = null;
            bunifuFormControlBox1.HelpBoxOptions.IconColor = Color.Black;
            bunifuFormControlBox1.HelpBoxOptions.IconHoverColor = Color.Black;
            bunifuFormControlBox1.HelpBoxOptions.IconPressedColor = Color.Black;
            bunifuFormControlBox1.HelpBoxOptions.IconSize = new Size(22, 22);
            bunifuFormControlBox1.HelpBoxOptions.PressedColor = Color.Silver;
            bunifuFormControlBox1.Location = new Point(87, 99);
            bunifuFormControlBox1.Margin = new Padding(4, 4, 4, 4);
            bunifuFormControlBox1.MaximizeBox = true;
            bunifuFormControlBox1.MaximizeBoxOptions.BackColor = Color.Transparent;
            bunifuFormControlBox1.MaximizeBoxOptions.BorderRadius = 0;
            bunifuFormControlBox1.MaximizeBoxOptions.Enabled = true;
            bunifuFormControlBox1.MaximizeBoxOptions.EnableDefaultAction = true;
            bunifuFormControlBox1.MaximizeBoxOptions.HoverColor = Color.LightGray;
            bunifuFormControlBox1.MaximizeBoxOptions.Icon = (Image)resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.Icon");
            bunifuFormControlBox1.MaximizeBoxOptions.IconAlt = (Image)resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.IconAlt");
            bunifuFormControlBox1.MaximizeBoxOptions.IconColor = Color.Black;
            bunifuFormControlBox1.MaximizeBoxOptions.IconHoverColor = Color.Black;
            bunifuFormControlBox1.MaximizeBoxOptions.IconPressedColor = Color.Black;
            bunifuFormControlBox1.MaximizeBoxOptions.IconSize = new Size(16, 16);
            bunifuFormControlBox1.MaximizeBoxOptions.PressedColor = Color.Silver;
            bunifuFormControlBox1.MinimizeBox = true;
            bunifuFormControlBox1.MinimizeBoxOptions.BackColor = Color.Transparent;
            bunifuFormControlBox1.MinimizeBoxOptions.BorderRadius = 0;
            bunifuFormControlBox1.MinimizeBoxOptions.Enabled = true;
            bunifuFormControlBox1.MinimizeBoxOptions.EnableDefaultAction = true;
            bunifuFormControlBox1.MinimizeBoxOptions.HoverColor = Color.LightGray;
            bunifuFormControlBox1.MinimizeBoxOptions.Icon = (Image)resources.GetObject("bunifuFormControlBox1.MinimizeBoxOptions.Icon");
            bunifuFormControlBox1.MinimizeBoxOptions.IconAlt = null;
            bunifuFormControlBox1.MinimizeBoxOptions.IconColor = Color.Black;
            bunifuFormControlBox1.MinimizeBoxOptions.IconHoverColor = Color.Black;
            bunifuFormControlBox1.MinimizeBoxOptions.IconPressedColor = Color.Black;
            bunifuFormControlBox1.MinimizeBoxOptions.IconSize = new Size(14, 14);
            bunifuFormControlBox1.MinimizeBoxOptions.PressedColor = Color.Silver;
            bunifuFormControlBox1.Name = "bunifuFormControlBox1";
            bunifuFormControlBox1.ShowDesignBorders = false;
            bunifuFormControlBox1.Size = new Size(182, 49);
            bunifuFormControlBox1.TabIndex = 21;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 477);
            ControlBox = false;
            Controls.Add(bunifuFormControlBox1);
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
        private Bunifu.UI.WinForms.BunifuFormControlBox bunifuFormControlBox1;
    }
}