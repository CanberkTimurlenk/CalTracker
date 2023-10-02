namespace FormUI
{
    partial class FormRecommendation
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
            label1 = new Label();
            cmb_Activitiy = new ComboBox();
            label3 = new Label();
            lbl_RecomendedCalorie = new Label();
            btn_Calculate = new Krypton.Toolkit.KryptonButton();
            lbl_DailyCalorie = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Aktivite Durumu";
            // 
            // cmb_Activitiy
            // 
            cmb_Activitiy.FormattingEnabled = true;
            cmb_Activitiy.Location = new Point(136, 11);
            cmb_Activitiy.Name = "cmb_Activitiy";
            cmb_Activitiy.Size = new Size(121, 23);
            cmb_Activitiy.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 0;
            label3.Text = "Günlük Kalori İhtiyacı";
            // 
            // lbl_RecomendedCalorie
            // 
            lbl_RecomendedCalorie.AutoSize = true;
            lbl_RecomendedCalorie.Location = new Point(183, 165);
            lbl_RecomendedCalorie.Name = "lbl_RecomendedCalorie";
            lbl_RecomendedCalorie.Size = new Size(37, 15);
            lbl_RecomendedCalorie.TabIndex = 0;
            lbl_RecomendedCalorie.Text = "Kalori";
            // 
            // btn_Calculate
            // 
            btn_Calculate.CornerRoundingRadius = 40F;
            btn_Calculate.Location = new Point(66, 70);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.OverrideDefault.Back.Color1 = Color.White;
            btn_Calculate.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Calculate.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.Size = new Size(145, 40);
            btn_Calculate.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.StateCommon.Border.Rounding = 40F;
            btn_Calculate.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.TabIndex = 9;
            btn_Calculate.TabStop = false;
            btn_Calculate.Values.Text = "Hesapla";
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // lbl_DailyCalorie
            // 
            lbl_DailyCalorie.AutoSize = true;
            lbl_DailyCalorie.Location = new Point(183, 192);
            lbl_DailyCalorie.Name = "lbl_DailyCalorie";
            lbl_DailyCalorie.Size = new Size(37, 15);
            lbl_DailyCalorie.TabIndex = 0;
            lbl_DailyCalorie.Text = "Kalori";
            // 
            // FormRecommendation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 273);
            Controls.Add(btn_Calculate);
            Controls.Add(cmb_Activitiy);
            Controls.Add(lbl_DailyCalorie);
            Controls.Add(lbl_RecomendedCalorie);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormRecommendation";
            Text = "FormRecommendation";
            Load += FormRecommendation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_Activitiy;
        private Label label3;
        private Label label5;
        private Label lbl_RecomendedCalorie;
        private Krypton.Toolkit.KryptonButton btn_Calculate;
        private Label lbl_DailyCalorie;
    }
}