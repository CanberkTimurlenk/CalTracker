namespace FormUI
{
    partial class FormDailyReport
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
            pv_DailyGraph = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_BreakfastCalorie = new Label();
            lbl_LunchCalorie = new Label();
            lbl_DinnerCalorie = new Label();
            lbl_SnackCalorie = new Label();
            lbl_BreakfastProtein = new Label();
            lbl_LunchProtein = new Label();
            lbl_DinnerProtein = new Label();
            lbl_SnackProtein = new Label();
            lbl_BreakfastCarbonhidrate = new Label();
            lbl_BreakfastFat = new Label();
            lbl_LunchCarbonhidrate = new Label();
            lbl_LunchFat = new Label();
            lbl_DinnerCarbonhidrate = new Label();
            lbl_DinnerFat = new Label();
            lbl_SnackCarbonhidrate = new Label();
            lbl_SnackFat = new Label();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // pv_DailyGraph
            // 
            pv_DailyGraph.Location = new Point(159, 425);
            pv_DailyGraph.Margin = new Padding(3, 4, 3, 4);
            pv_DailyGraph.Name = "pv_DailyGraph";
            pv_DailyGraph.PanCursor = Cursors.Hand;
            pv_DailyGraph.Size = new Size(570, 227);
            pv_DailyGraph.TabIndex = 0;
            pv_DailyGraph.Text = "plotView1";
            pv_DailyGraph.ZoomHorizontalCursor = Cursors.SizeWE;
            pv_DailyGraph.ZoomRectangleCursor = Cursors.SizeNWSE;
            pv_DailyGraph.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 187);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Kahvalti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 241);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Oglen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 295);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Aksam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 345);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 1;
            label4.Text = "Aperatif";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 135);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 1;
            label5.Text = "Kalori";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 135);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 1;
            label6.Text = "Protein";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 135);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 1;
            label7.Text = "Karbonhidrat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(537, 135);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 1;
            label8.Text = "Yag";
            // 
            // lbl_BreakfastCalorie
            // 
            lbl_BreakfastCalorie.AutoSize = true;
            lbl_BreakfastCalorie.Location = new Point(309, 187);
            lbl_BreakfastCalorie.Name = "lbl_BreakfastCalorie";
            lbl_BreakfastCalorie.Size = new Size(17, 20);
            lbl_BreakfastCalorie.TabIndex = 1;
            lbl_BreakfastCalorie.Text = "0";
            // 
            // lbl_LunchCalorie
            // 
            lbl_LunchCalorie.AutoSize = true;
            lbl_LunchCalorie.Location = new Point(309, 241);
            lbl_LunchCalorie.Name = "lbl_LunchCalorie";
            lbl_LunchCalorie.Size = new Size(17, 20);
            lbl_LunchCalorie.TabIndex = 1;
            lbl_LunchCalorie.Text = "0";
            // 
            // lbl_DinnerCalorie
            // 
            lbl_DinnerCalorie.AutoSize = true;
            lbl_DinnerCalorie.Location = new Point(309, 295);
            lbl_DinnerCalorie.Name = "lbl_DinnerCalorie";
            lbl_DinnerCalorie.Size = new Size(17, 20);
            lbl_DinnerCalorie.TabIndex = 1;
            lbl_DinnerCalorie.Text = "0";
            // 
            // lbl_SnackCalorie
            // 
            lbl_SnackCalorie.AutoSize = true;
            lbl_SnackCalorie.Location = new Point(309, 345);
            lbl_SnackCalorie.Name = "lbl_SnackCalorie";
            lbl_SnackCalorie.Size = new Size(17, 20);
            lbl_SnackCalorie.TabIndex = 1;
            lbl_SnackCalorie.Text = "0";
            // 
            // lbl_BreakfastProtein
            // 
            lbl_BreakfastProtein.AutoSize = true;
            lbl_BreakfastProtein.Location = new Point(382, 187);
            lbl_BreakfastProtein.Name = "lbl_BreakfastProtein";
            lbl_BreakfastProtein.Size = new Size(17, 20);
            lbl_BreakfastProtein.TabIndex = 1;
            lbl_BreakfastProtein.Text = "0";
            // 
            // lbl_LunchProtein
            // 
            lbl_LunchProtein.AutoSize = true;
            lbl_LunchProtein.Location = new Point(382, 241);
            lbl_LunchProtein.Name = "lbl_LunchProtein";
            lbl_LunchProtein.Size = new Size(17, 20);
            lbl_LunchProtein.TabIndex = 1;
            lbl_LunchProtein.Text = "0";
            // 
            // lbl_DinnerProtein
            // 
            lbl_DinnerProtein.AutoSize = true;
            lbl_DinnerProtein.Location = new Point(382, 295);
            lbl_DinnerProtein.Name = "lbl_DinnerProtein";
            lbl_DinnerProtein.Size = new Size(17, 20);
            lbl_DinnerProtein.TabIndex = 1;
            lbl_DinnerProtein.Text = "0";
            // 
            // lbl_SnackProtein
            // 
            lbl_SnackProtein.AutoSize = true;
            lbl_SnackProtein.Location = new Point(382, 345);
            lbl_SnackProtein.Name = "lbl_SnackProtein";
            lbl_SnackProtein.Size = new Size(17, 20);
            lbl_SnackProtein.TabIndex = 1;
            lbl_SnackProtein.Text = "0";
            // 
            // lbl_BreakfastCarbonhidrate
            // 
            lbl_BreakfastCarbonhidrate.AutoSize = true;
            lbl_BreakfastCarbonhidrate.Location = new Point(453, 187);
            lbl_BreakfastCarbonhidrate.Name = "lbl_BreakfastCarbonhidrate";
            lbl_BreakfastCarbonhidrate.Size = new Size(17, 20);
            lbl_BreakfastCarbonhidrate.TabIndex = 1;
            lbl_BreakfastCarbonhidrate.Text = "0";
            // 
            // lbl_BreakfastFat
            // 
            lbl_BreakfastFat.AutoSize = true;
            lbl_BreakfastFat.Location = new Point(537, 187);
            lbl_BreakfastFat.Name = "lbl_BreakfastFat";
            lbl_BreakfastFat.Size = new Size(17, 20);
            lbl_BreakfastFat.TabIndex = 1;
            lbl_BreakfastFat.Text = "0";
            // 
            // lbl_LunchCarbonhidrate
            // 
            lbl_LunchCarbonhidrate.AutoSize = true;
            lbl_LunchCarbonhidrate.Location = new Point(453, 241);
            lbl_LunchCarbonhidrate.Name = "lbl_LunchCarbonhidrate";
            lbl_LunchCarbonhidrate.Size = new Size(17, 20);
            lbl_LunchCarbonhidrate.TabIndex = 1;
            lbl_LunchCarbonhidrate.Text = "0";
            // 
            // lbl_LunchFat
            // 
            lbl_LunchFat.AutoSize = true;
            lbl_LunchFat.Location = new Point(537, 241);
            lbl_LunchFat.Name = "lbl_LunchFat";
            lbl_LunchFat.Size = new Size(17, 20);
            lbl_LunchFat.TabIndex = 1;
            lbl_LunchFat.Text = "0";
            // 
            // lbl_DinnerCarbonhidrate
            // 
            lbl_DinnerCarbonhidrate.AutoSize = true;
            lbl_DinnerCarbonhidrate.Location = new Point(453, 295);
            lbl_DinnerCarbonhidrate.Name = "lbl_DinnerCarbonhidrate";
            lbl_DinnerCarbonhidrate.Size = new Size(17, 20);
            lbl_DinnerCarbonhidrate.TabIndex = 1;
            lbl_DinnerCarbonhidrate.Text = "0";
            // 
            // lbl_DinnerFat
            // 
            lbl_DinnerFat.AutoSize = true;
            lbl_DinnerFat.Location = new Point(537, 295);
            lbl_DinnerFat.Name = "lbl_DinnerFat";
            lbl_DinnerFat.Size = new Size(17, 20);
            lbl_DinnerFat.TabIndex = 1;
            lbl_DinnerFat.Text = "0";
            // 
            // lbl_SnackCarbonhidrate
            // 
            lbl_SnackCarbonhidrate.AutoSize = true;
            lbl_SnackCarbonhidrate.Location = new Point(453, 345);
            lbl_SnackCarbonhidrate.Name = "lbl_SnackCarbonhidrate";
            lbl_SnackCarbonhidrate.Size = new Size(17, 20);
            lbl_SnackCarbonhidrate.TabIndex = 1;
            lbl_SnackCarbonhidrate.Text = "0";
            // 
            // lbl_SnackFat
            // 
            lbl_SnackFat.AutoSize = true;
            lbl_SnackFat.Location = new Point(537, 345);
            lbl_SnackFat.Name = "lbl_SnackFat";
            lbl_SnackFat.Size = new Size(17, 20);
            lbl_SnackFat.TabIndex = 1;
            lbl_SnackFat.Text = "0";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(87, 40);
            kryptonLabel1.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(105, 24);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Gunluk Rapor";
            // 
            // FormDailyReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 703);
            Controls.Add(kryptonLabel1);
            Controls.Add(label8);
            Controls.Add(lbl_SnackFat);
            Controls.Add(lbl_SnackProtein);
            Controls.Add(lbl_SnackCarbonhidrate);
            Controls.Add(lbl_SnackCalorie);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(lbl_DinnerFat);
            Controls.Add(lbl_DinnerProtein);
            Controls.Add(lbl_DinnerCarbonhidrate);
            Controls.Add(lbl_DinnerCalorie);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(lbl_LunchFat);
            Controls.Add(lbl_LunchProtein);
            Controls.Add(lbl_LunchCarbonhidrate);
            Controls.Add(lbl_LunchCalorie);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(lbl_BreakfastFat);
            Controls.Add(lbl_BreakfastCarbonhidrate);
            Controls.Add(lbl_BreakfastProtein);
            Controls.Add(lbl_BreakfastCalorie);
            Controls.Add(label1);
            Controls.Add(pv_DailyGraph);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDailyReport";
            Text = "FormDailyReport";
            Load += FormDailyReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView pv_DailyGraph;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbl_BreakfastCalorie;
        private Label lbl_LunchCalorie;
        private Label lbl_DinnerCalorie;
        private Label lbl_SnackCalorie;
        private Label lbl_BreakfastProtein;
        private Label lbl_LunchProtein;
        private Label lbl_DinnerProtein;
        private Label lbl_SnackProtein;
        private Label lbl_BreakfastCarbonhidrate;
        private Label lbl_BreakfastFat;
        private Label lbl_LunchCarbonhidrate;
        private Label lbl_LunchFat;
        private Label lbl_DinnerCarbonhidrate;
        private Label lbl_DinnerFat;
        private Label lbl_SnackCarbonhidrate;
        private Label lbl_SnackFat;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}