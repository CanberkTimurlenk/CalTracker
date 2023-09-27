namespace FormUI
{
    partial class FormVerification
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
            registrationButton = new Button();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            txtPassword = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 191, 107);
            label3.Location = new Point(25, 30);
            label3.Name = "label3";
            label3.Size = new Size(154, 27);
            label3.TabIndex = 0;
            label3.Text = "Verification";
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.FromArgb(32, 191, 107);
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(34, 179);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(218, 28);
            registrationButton.TabIndex = 4;
            registrationButton.Text = "REGISTER";
            registrationButton.UseVisualStyleBackColor = false;
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
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(36, 115);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(218, 28);
            txtPassword.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(36, 115);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 28);
            textBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 85);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 29;
            label4.Text = "Verification Code";
            // 
            // FormVerification
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 242);
            ControlBox = false;
            Controls.Add(txtPassword);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(kryptonButton1);
            Controls.Add(registrationButton);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormVerification";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button registrationButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox txtPassword;
        private TextBox textBox2;
        private Label label4;
    }
}