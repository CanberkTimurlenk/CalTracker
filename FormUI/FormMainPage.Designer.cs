namespace FormUI
{
    partial class FormMainPage
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
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(77, 88);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(162, 51);
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Kalori Takip";
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = -1F;
            kryptonButton2.Location = new Point(77, 195);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(162, 53);
            kryptonButton2.TabIndex = 0;
            kryptonButton2.Values.Text = "Raporlar";
            // 
            // kryptonButton3
            // 
            kryptonButton3.CornerRoundingRadius = -1F;
            kryptonButton3.Location = new Point(77, 304);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(162, 53);
            kryptonButton3.TabIndex = 0;
            kryptonButton3.Values.Text = "Ayarlar";
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 431);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Name = "FormMainPage";
            Text = "FormMainPage";
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}