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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = -1F;
            kryptonButton2.Location = new Point(77, 197);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            kryptonButton2.Size = new Size(162, 53);
            kryptonButton2.TabIndex = 0;
            kryptonButton2.Values.Text = "Raporlar";
            // 
            // kryptonButton1
            // 
            kryptonButton3.CornerRoundingRadius = -1F;
            kryptonButton3.Location = new Point(77, 304);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            kryptonButton3.Size = new Size(162, 53);
            kryptonButton3.TabIndex = 0;
            kryptonButton3.Values.Text = "Ayarlar";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 191, 107);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(52, 62);
            button1.Name = "button1";
            button1.Size = new Size(376, 89);
            button1.TabIndex = 1;
            button1.Text = "Kalori Takip                   ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.CornerRoundingRadius = 40F;
            kryptonButton1.Enabled = false;
            kryptonButton1.Location = new Point(52, 67);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Image = (Image)resources.GetObject("kryptonButton1.OverrideDefault.Back.Image");
            kryptonButton1.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.Size = new Size(104, 77);
            kryptonButton1.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Back.ColorAngle = 0F;
            kryptonButton1.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateCommon.Back.Image = (Image)resources.GetObject("kryptonButton1.StateCommon.Back.Image");
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 40F;
            kryptonButton1.StateCommon.Border.Width = 0;
            kryptonButton1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateNormal.Border.Rounding = 40F;
            kryptonButton1.StateNormal.Border.Width = 0;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(32, 191, 107);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(32, 191, 107);
            kryptonButton1.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButton1.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButton1.StateTracking.Border.ColorAngle = 0F;
            kryptonButton1.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StateTracking.Border.Rounding = 40F;
            kryptonButton1.StateTracking.Border.Width = 0;
            kryptonButton1.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "";
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 431);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(button1);
            Name = "FormMainPage";
            Text = "FormMainPage";
            Load += FormMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}