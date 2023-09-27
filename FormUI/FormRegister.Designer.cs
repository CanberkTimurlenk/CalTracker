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
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtComPassword = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkboxShowPass = new System.Windows.Forms.CheckBox();
            registrationButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            label3.Location = new System.Drawing.Point(28, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 27);
            label3.TabIndex = 0;
            label3.Text = "Get Started";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 121);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtUsername.Location = new System.Drawing.Point(33, 151);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(218, 28);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 197);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(33, 227);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(218, 28);
            textBox2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPassword.Location = new System.Drawing.Point(33, 227);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(218, 28);
            txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 17);
            label4.TabIndex = 1;
            label4.Text = "Confirm Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            txtComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtComPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtComPassword.Location = new System.Drawing.Point(33, 300);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new System.Drawing.Size(218, 28);
            txtComPassword.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(129, 334);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(122, 21);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            checkboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkboxShowPass.Location = new System.Drawing.Point(129, 334);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new System.Drawing.Size(119, 21);
            checkboxShowPass.TabIndex = 3;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += new System.EventHandler(checkboxShowPass_CheckedChanged);
            // 
            // registrationButton
            // 
            registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            registrationButton.ForeColor = System.Drawing.Color.White;
            registrationButton.Location = new System.Drawing.Point(33, 389);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new System.Drawing.Size(218, 28);
            registrationButton.TabIndex = 4;
            registrationButton.Text = "REGISTER";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += new System.EventHandler(registrationButton_Click);
            // 
            // clearButton
            // 
            clearButton.BackColor = System.Drawing.Color.White;
            clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            clearButton.Enabled = false;
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            clearButton.Location = new System.Drawing.Point(33, 436);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(218, 28);
            clearButton.TabIndex = 4;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += new System.EventHandler(button1_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(62, 476);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 17);
            label5.TabIndex = 5;
            label5.Text = "Already have an Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = System.Windows.Forms.Cursors.Hand;
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(78)))), ((int)(((byte)(165)))));
            label6.Location = new System.Drawing.Point(94, 502);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(97, 17);
            label6.TabIndex = 5;
            label6.Text = "Back to LOGIN";
            label6.Click += new System.EventHandler(label6_Click_1);
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(285, 544);
            ControlBox = false;
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
            Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += new System.EventHandler(FormRegister_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }



}
