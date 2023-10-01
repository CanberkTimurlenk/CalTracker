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
            cmb_Categories = new Krypton.Toolkit.KryptonComboBox();
            label2 = new Label();
            lbl_OthersTotal = new Label();
            lbl_OthersSnack = new Label();
            lbl_OthersDinner = new Label();
            lbl_Total = new Label();
            lbl_Snack = new Label();
            lbl_Dinner = new Label();
            lbl_OthersLunch = new Label();
            label6 = new Label();
            lbl_lunch = new Label();
            lbl_OthersBreakfast = new Label();
            label5 = new Label();
            lbl_Breakfast = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pv_Category = new OxyPlot.WindowsForms.PlotView();
            pv_MealTime = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).BeginInit();
            SuspendLayout();
            // 
            // cmb_Categories
            // 
            cmb_Categories.CornerRoundingRadius = -1F;
            cmb_Categories.DropDownWidth = 121;
            cmb_Categories.IntegralHeight = false;
            cmb_Categories.Location = new Point(539, 91);
            cmb_Categories.Margin = new Padding(3, 4, 3, 4);
            cmb_Categories.Name = "cmb_Categories";
            cmb_Categories.Size = new Size(138, 25);
            cmb_Categories.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Categories.TabIndex = 21;
            cmb_Categories.Text = "Kategori";
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
            // lbl_OthersTotal
            // 
            lbl_OthersTotal.AutoSize = true;
            lbl_OthersTotal.Location = new Point(568, 173);
            lbl_OthersTotal.Name = "lbl_OthersTotal";
            lbl_OthersTotal.Size = new Size(17, 20);
            lbl_OthersTotal.TabIndex = 18;
            lbl_OthersTotal.Text = "0";
            // 
            // lbl_OthersSnack
            // 
            lbl_OthersSnack.AutoSize = true;
            lbl_OthersSnack.Location = new Point(485, 173);
            lbl_OthersSnack.Name = "lbl_OthersSnack";
            lbl_OthersSnack.Size = new Size(17, 20);
            lbl_OthersSnack.TabIndex = 17;
            lbl_OthersSnack.Text = "0";
            // 
            // lbl_OthersDinner
            // 
            lbl_OthersDinner.AutoSize = true;
            lbl_OthersDinner.Location = new Point(422, 173);
            lbl_OthersDinner.Name = "lbl_OthersDinner";
            lbl_OthersDinner.Size = new Size(17, 20);
            lbl_OthersDinner.TabIndex = 16;
            lbl_OthersDinner.Text = "0";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(568, 137);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(17, 20);
            lbl_Total.TabIndex = 15;
            lbl_Total.Text = "0";
            // 
            // lbl_Snack
            // 
            lbl_Snack.AutoSize = true;
            lbl_Snack.Location = new Point(485, 137);
            lbl_Snack.Name = "lbl_Snack";
            lbl_Snack.Size = new Size(17, 20);
            lbl_Snack.TabIndex = 14;
            lbl_Snack.Text = "0";
            // 
            // lbl_Dinner
            // 
            lbl_Dinner.AutoSize = true;
            lbl_Dinner.Location = new Point(422, 137);
            lbl_Dinner.Name = "lbl_Dinner";
            lbl_Dinner.Size = new Size(17, 20);
            lbl_Dinner.TabIndex = 13;
            lbl_Dinner.Text = "0";
            // 
            // lbl_OthersLunch
            // 
            lbl_OthersLunch.AutoSize = true;
            lbl_OthersLunch.Location = new Point(368, 173);
            lbl_OthersLunch.Name = "lbl_OthersLunch";
            lbl_OthersLunch.Size = new Size(17, 20);
            lbl_OthersLunch.TabIndex = 20;
            lbl_OthersLunch.Text = "0";
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
            // lbl_lunch
            // 
            lbl_lunch.AutoSize = true;
            lbl_lunch.Location = new Point(368, 137);
            lbl_lunch.Name = "lbl_lunch";
            lbl_lunch.Size = new Size(17, 20);
            lbl_lunch.TabIndex = 11;
            lbl_lunch.Text = "0";
            // 
            // lbl_OthersBreakfast
            // 
            lbl_OthersBreakfast.AutoSize = true;
            lbl_OthersBreakfast.Location = new Point(305, 173);
            lbl_OthersBreakfast.Name = "lbl_OthersBreakfast";
            lbl_OthersBreakfast.Size = new Size(17, 20);
            lbl_OthersBreakfast.TabIndex = 10;
            lbl_OthersBreakfast.Text = "0";
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
            // lbl_Breakfast
            // 
            lbl_Breakfast.AutoSize = true;
            lbl_Breakfast.Location = new Point(305, 137);
            lbl_Breakfast.Name = "lbl_Breakfast";
            lbl_Breakfast.Size = new Size(17, 20);
            lbl_Breakfast.TabIndex = 8;
            lbl_Breakfast.Text = "0";
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
            Controls.Add(cmb_Categories);
            Controls.Add(label2);
            Controls.Add(lbl_OthersTotal);
            Controls.Add(lbl_OthersSnack);
            Controls.Add(lbl_OthersDinner);
            Controls.Add(lbl_Total);
            Controls.Add(lbl_Snack);
            Controls.Add(lbl_Dinner);
            Controls.Add(lbl_OthersLunch);
            Controls.Add(label6);
            Controls.Add(lbl_lunch);
            Controls.Add(lbl_OthersBreakfast);
            Controls.Add(label5);
            Controls.Add(lbl_Breakfast);
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
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cmb_Categories;
        private Label label2;
        private Label lbl_OthersTotal;
        private Label lbl_OthersSnack;
        private Label lbl_OthersDinner;
        private Label lbl_Total;
        private Label lbl_Snack;
        private Label lbl_Dinner;
        private Label lbl_OthersLunch;
        private Label label6;
        private Label lbl_lunch;
        private Label lbl_OthersBreakfast;
        private Label label5;
        private Label lbl_Breakfast;
        private Label label4;
        private Label label3;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView pv_Category;
        private OxyPlot.WindowsForms.PlotView pv_MealTime;
    }
}