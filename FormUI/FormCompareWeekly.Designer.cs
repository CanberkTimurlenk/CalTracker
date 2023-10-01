namespace FormUI
{
    partial class FormCompareWeekly
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
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmb_Categories = new Krypton.Toolkit.KryptonComboBox();
            lbl_Breakfast = new Label();
            lbl_lunch = new Label();
            lbl_Dinner = new Label();
            lbl_Snack = new Label();
            lbl_OthersBreakfast = new Label();
            lbl_OthersLunch = new Label();
            lbl_OthersDinner = new Label();
            lbl_OthersSnack = new Label();
            lbl_Total = new Label();
            lbl_OthersTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).BeginInit();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.Location = new Point(58, 379);
            plotView1.Margin = new Padding(3, 4, 3, 4);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(349, 151);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(517, 379);
            plotView2.Margin = new Padding(3, 4, 3, 4);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(349, 151);
            plotView2.TabIndex = 0;
            plotView2.Text = "plotView1";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 157);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "Siz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 193);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Diger Kullanicilar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 116);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Kahvalti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 116);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Oglen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 116);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 1;
            label5.Text = "Aksam";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 116);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 1;
            label6.Text = "Aperatif";
            // 
            // cmb_Categories
            // 
            cmb_Categories.CornerRoundingRadius = -1F;
            cmb_Categories.DropDownWidth = 121;
            cmb_Categories.IntegralHeight = false;
            cmb_Categories.Location = new Point(544, 111);
            cmb_Categories.Margin = new Padding(3, 4, 3, 4);
            cmb_Categories.Name = "cmb_Categories";
            cmb_Categories.Size = new Size(138, 25);
            cmb_Categories.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Categories.TabIndex = 2;
            cmb_Categories.Text = "Kategori";
            // 
            // lbl_Breakfast
            // 
            lbl_Breakfast.AutoSize = true;
            lbl_Breakfast.Location = new Point(310, 157);
            lbl_Breakfast.Name = "lbl_Breakfast";
            lbl_Breakfast.Size = new Size(17, 20);
            lbl_Breakfast.TabIndex = 1;
            lbl_Breakfast.Text = "0";
            // 
            // lbl_lunch
            // 
            lbl_lunch.AutoSize = true;
            lbl_lunch.Location = new Point(373, 157);
            lbl_lunch.Name = "lbl_lunch";
            lbl_lunch.Size = new Size(17, 20);
            lbl_lunch.TabIndex = 1;
            lbl_lunch.Text = "0";
            // 
            // lbl_Dinner
            // 
            lbl_Dinner.AutoSize = true;
            lbl_Dinner.Location = new Point(426, 157);
            lbl_Dinner.Name = "lbl_Dinner";
            lbl_Dinner.Size = new Size(17, 20);
            lbl_Dinner.TabIndex = 1;
            lbl_Dinner.Text = "0";
            // 
            // lbl_Snack
            // 
            lbl_Snack.AutoSize = true;
            lbl_Snack.Location = new Point(489, 157);
            lbl_Snack.Name = "lbl_Snack";
            lbl_Snack.Size = new Size(17, 20);
            lbl_Snack.TabIndex = 1;
            lbl_Snack.Text = "0";
            // 
            // lbl_OthersBreakfast
            // 
            lbl_OthersBreakfast.AutoSize = true;
            lbl_OthersBreakfast.Location = new Point(310, 193);
            lbl_OthersBreakfast.Name = "lbl_OthersBreakfast";
            lbl_OthersBreakfast.Size = new Size(17, 20);
            lbl_OthersBreakfast.TabIndex = 1;
            lbl_OthersBreakfast.Text = "0";
            // 
            // lbl_OthersLunch
            // 
            lbl_OthersLunch.AutoSize = true;
            lbl_OthersLunch.Location = new Point(373, 193);
            lbl_OthersLunch.Name = "lbl_OthersLunch";
            lbl_OthersLunch.Size = new Size(17, 20);
            lbl_OthersLunch.TabIndex = 1;
            lbl_OthersLunch.Text = "0";
            // 
            // lbl_OthersDinner
            // 
            lbl_OthersDinner.AutoSize = true;
            lbl_OthersDinner.Location = new Point(426, 193);
            lbl_OthersDinner.Name = "lbl_OthersDinner";
            lbl_OthersDinner.Size = new Size(17, 20);
            lbl_OthersDinner.TabIndex = 1;
            lbl_OthersDinner.Text = "0";
            // 
            // lbl_OthersSnack
            // 
            lbl_OthersSnack.AutoSize = true;
            lbl_OthersSnack.Location = new Point(489, 193);
            lbl_OthersSnack.Name = "lbl_OthersSnack";
            lbl_OthersSnack.Size = new Size(17, 20);
            lbl_OthersSnack.TabIndex = 1;
            lbl_OthersSnack.Text = "0";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(573, 157);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(17, 20);
            lbl_Total.TabIndex = 1;
            lbl_Total.Text = "0";
            // 
            // lbl_OthersTotal
            // 
            lbl_OthersTotal.AutoSize = true;
            lbl_OthersTotal.Location = new Point(573, 193);
            lbl_OthersTotal.Name = "lbl_OthersTotal";
            lbl_OthersTotal.Size = new Size(17, 20);
            lbl_OthersTotal.TabIndex = 1;
            lbl_OthersTotal.Text = "0";
            // 
            // FormCompareWeekly
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
            Controls.Add(plotView2);
            Controls.Add(plotView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompareWeekly";
            Text = "FormCompare";
            Load += FormCompareWeekly_Load;
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonComboBox cmb_Categories;
        private Label lbl_Breakfast;
        private Label lbl_lunch;
        private Label lbl_Dinner;
        private Label lbl_Snack;
        private Label lbl_OthersBreakfast;
        private Label lbl_OthersLunch;
        private Label lbl_OthersDinner;
        private Label lbl_OthersSnack;
        private Label lbl_Total;
        private Label lbl_OthersTotal;
    }
}