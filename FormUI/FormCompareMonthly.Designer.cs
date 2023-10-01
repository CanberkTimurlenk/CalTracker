namespace FormUI
{
    partial class FormCompareMonthly
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
            cmb_Category = new Krypton.Toolkit.KryptonComboBox();
            label2 = new Label();
            lbl_TotalOthers = new Label();
            lbl_SnackOthers = new Label();
            lbl_DinnerOthers = new Label();
            lbl_TotalYou = new Label();
            lbl_SnackYou = new Label();
            lbl_DinnerYou = new Label();
            lbl_LunchOthers = new Label();
            label6 = new Label();
            lbl_LunchYou = new Label();
            lbl_BreakfastOthers = new Label();
            label5 = new Label();
            lbl_BreakfastYou = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pv_Category = new OxyPlot.WindowsForms.PlotView();
            pv_MealTime = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)cmb_Category).BeginInit();
            SuspendLayout();
            // 
            // cmb_Category
            // 
            cmb_Category.CornerRoundingRadius = -1F;
            cmb_Category.DropDownWidth = 121;
            cmb_Category.IntegralHeight = false;
            cmb_Category.Location = new Point(539, 91);
            cmb_Category.Margin = new Padding(3, 4, 3, 4);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(138, 25);
            cmb_Category.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Category.TabIndex = 21;
            cmb_Category.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 173);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 19;
            label2.Text = "Diger Kullanicilar";
            // 
            // lbl_TotalOthers
            // 
            lbl_TotalOthers.AutoSize = true;
            lbl_TotalOthers.Location = new Point(568, 173);
            lbl_TotalOthers.Name = "lbl_TotalOthers";
            lbl_TotalOthers.Size = new Size(17, 20);
            lbl_TotalOthers.TabIndex = 18;
            lbl_TotalOthers.Text = "0";
            // 
            // lbl_SnackOthers
            // 
            lbl_SnackOthers.AutoSize = true;
            lbl_SnackOthers.Location = new Point(485, 173);
            lbl_SnackOthers.Name = "lbl_SnackOthers";
            lbl_SnackOthers.Size = new Size(17, 20);
            lbl_SnackOthers.TabIndex = 17;
            lbl_SnackOthers.Text = "0";
            // 
            // lbl_DinnerOthers
            // 
            lbl_DinnerOthers.AutoSize = true;
            lbl_DinnerOthers.Location = new Point(422, 173);
            lbl_DinnerOthers.Name = "lbl_DinnerOthers";
            lbl_DinnerOthers.Size = new Size(17, 20);
            lbl_DinnerOthers.TabIndex = 16;
            lbl_DinnerOthers.Text = "0";
            // 
            // lbl_TotalYou
            // 
            lbl_TotalYou.AutoSize = true;
            lbl_TotalYou.Location = new Point(568, 137);
            lbl_TotalYou.Name = "lbl_TotalYou";
            lbl_TotalYou.Size = new Size(17, 20);
            lbl_TotalYou.TabIndex = 15;
            lbl_TotalYou.Text = "0";
            // 
            // lbl_SnackYou
            // 
            lbl_SnackYou.AutoSize = true;
            lbl_SnackYou.Location = new Point(485, 137);
            lbl_SnackYou.Name = "lbl_SnackYou";
            lbl_SnackYou.Size = new Size(17, 20);
            lbl_SnackYou.TabIndex = 14;
            lbl_SnackYou.Text = "0";
            // 
            // lbl_DinnerYou
            // 
            lbl_DinnerYou.AutoSize = true;
            lbl_DinnerYou.Location = new Point(422, 137);
            lbl_DinnerYou.Name = "lbl_DinnerYou";
            lbl_DinnerYou.Size = new Size(17, 20);
            lbl_DinnerYou.TabIndex = 13;
            lbl_DinnerYou.Text = "0";
            // 
            // lbl_LunchOthers
            // 
            lbl_LunchOthers.AutoSize = true;
            lbl_LunchOthers.Location = new Point(368, 173);
            lbl_LunchOthers.Name = "lbl_LunchOthers";
            lbl_LunchOthers.Size = new Size(17, 20);
            lbl_LunchOthers.TabIndex = 20;
            lbl_LunchOthers.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 96);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 12;
            label6.Text = "Aperatif";
            // 
            // lbl_LunchYou
            // 
            lbl_LunchYou.AutoSize = true;
            lbl_LunchYou.Location = new Point(368, 137);
            lbl_LunchYou.Name = "lbl_LunchYou";
            lbl_LunchYou.Size = new Size(17, 20);
            lbl_LunchYou.TabIndex = 11;
            lbl_LunchYou.Text = "0";
            // 
            // lbl_BreakfastOthers
            // 
            lbl_BreakfastOthers.AutoSize = true;
            lbl_BreakfastOthers.Location = new Point(305, 173);
            lbl_BreakfastOthers.Name = "lbl_BreakfastOthers";
            lbl_BreakfastOthers.Size = new Size(17, 20);
            lbl_BreakfastOthers.TabIndex = 10;
            lbl_BreakfastOthers.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 96);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Aksam";
            // 
            // lbl_BreakfastYou
            // 
            lbl_BreakfastYou.AutoSize = true;
            lbl_BreakfastYou.Location = new Point(305, 137);
            lbl_BreakfastYou.Name = "lbl_BreakfastYou";
            lbl_BreakfastYou.Size = new Size(17, 20);
            lbl_BreakfastYou.TabIndex = 8;
            lbl_BreakfastYou.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 96);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Oglen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 96);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Kahvalti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 137);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 5;
            label1.Text = "Siz";
            // 
            // pv_Category
            // 
            pv_Category.Location = new Point(446, 320);
            pv_Category.Margin = new Padding(3, 4, 3, 4);
            pv_Category.Name = "pv_Category";
            pv_Category.PanCursor = Cursors.Hand;
            pv_Category.Size = new Size(455, 231);
            pv_Category.TabIndex = 4;
            pv_Category.Text = "plotView1";
            pv_Category.ZoomHorizontalCursor = Cursors.SizeWE;
            pv_Category.ZoomRectangleCursor = Cursors.SizeNWSE;
            pv_Category.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // pv_MealTime
            // 
            pv_MealTime.Location = new Point(14, 320);
            pv_MealTime.Margin = new Padding(3, 4, 3, 4);
            pv_MealTime.Name = "pv_MealTime";
            pv_MealTime.PanCursor = Cursors.Hand;
            pv_MealTime.Size = new Size(423, 231);
            pv_MealTime.TabIndex = 3;
            pv_MealTime.Text = "plotView1";
            pv_MealTime.ZoomHorizontalCursor = Cursors.SizeWE;
            pv_MealTime.ZoomRectangleCursor = Cursors.SizeNWSE;
            pv_MealTime.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // FormCompareMonthly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmb_Category);
            Controls.Add(label2);
            Controls.Add(lbl_TotalOthers);
            Controls.Add(lbl_SnackOthers);
            Controls.Add(lbl_DinnerOthers);
            Controls.Add(lbl_TotalYou);
            Controls.Add(lbl_SnackYou);
            Controls.Add(lbl_DinnerYou);
            Controls.Add(lbl_LunchOthers);
            Controls.Add(label6);
            Controls.Add(lbl_LunchYou);
            Controls.Add(lbl_BreakfastOthers);
            Controls.Add(label5);
            Controls.Add(lbl_BreakfastYou);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pv_Category);
            Controls.Add(pv_MealTime);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompareMonthly";
            Text = "FormCompareMonthly";
            Load += FormCompareMonthly_Load;
            ((System.ComponentModel.ISupportInitialize)cmb_Category).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cmb_Category;
        private Label label2;
        private Label lbl_TotalOthers;
        private Label lbl_SnackOthers;
        private Label lbl_DinnerOthers;
        private Label lbl_TotalYou;
        private Label lbl_SnackYou;
        private Label lbl_DinnerYou;
        private Label lbl_LunchOthers;
        private Label label6;
        private Label lbl_LunchYou;
        private Label lbl_BreakfastOthers;
        private Label label5;
        private Label lbl_BreakfastYou;
        private Label label4;
        private Label label3;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView pv_Category;
        private OxyPlot.WindowsForms.PlotView pv_MealTime;
    }
}