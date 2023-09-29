namespace FormUI
{
    partial class FormMeals
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
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            dgv_SelectedMealList = new Krypton.Toolkit.KryptonDataGridView();
            txt_Meal_Search = new TextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            dgv_MealList = new Krypton.Toolkit.KryptonDataGridView();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            label2 = new Label();
            kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            kryptonButton9 = new Krypton.Toolkit.KryptonButton();
            nud_Amount = new Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedMealList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_MealList).BeginInit();
            SuspendLayout();
            // 
            // dgv_SelectedMealList
            // 
            dgv_SelectedMealList.Location = new Point(430, 119);
            dgv_SelectedMealList.Name = "dgv_SelectedMealList";
            dgv_SelectedMealList.RowTemplate.Height = 25;
            dgv_SelectedMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SelectedMealList.Size = new Size(321, 238);
            dgv_SelectedMealList.TabIndex = 0;
            // 
            // txt_Meal_Search
            // 
            txt_Meal_Search.Location = new Point(22, 62);
            txt_Meal_Search.Name = "txt_Meal_Search";
            txt_Meal_Search.Size = new Size(287, 23);
            txt_Meal_Search.TabIndex = 3;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(315, 62);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(44, 25);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Tag = "5";
            kryptonButton1.Values.Text = "Ara";
            kryptonButton1.Click += Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = -1F;
            kryptonButton2.Location = new Point(22, 12);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(107, 25);
            kryptonButton2.TabIndex = 4;
            kryptonButton2.Tag = "1";
            kryptonButton2.Values.Text = "SABAH";
            kryptonButton2.Click += Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.CornerRoundingRadius = -1F;
            kryptonButton3.Location = new Point(153, 12);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(107, 25);
            kryptonButton3.TabIndex = 4;
            kryptonButton3.Tag = "2";
            kryptonButton3.Values.Text = "Öğlen";
            kryptonButton3.Click += Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.CornerRoundingRadius = -1F;
            kryptonButton4.Location = new Point(289, 12);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(107, 25);
            kryptonButton4.TabIndex = 4;
            kryptonButton4.Tag = "3";
            kryptonButton4.Values.Text = "Akşam";
            kryptonButton4.Click += Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.CornerRoundingRadius = -1F;
            kryptonButton5.Location = new Point(420, 12);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(107, 25);
            kryptonButton5.TabIndex = 4;
            kryptonButton5.Tag = "4";
            kryptonButton5.Values.Text = "Aperatif";
            kryptonButton5.Click += Click;
            // 
            // kryptonButton8
            // 
            kryptonButton8.CornerRoundingRadius = -1F;
            kryptonButton8.Location = new Point(644, 388);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(107, 25);
            kryptonButton8.TabIndex = 4;
            kryptonButton8.Tag = "7";
            kryptonButton8.Values.Text = "Kaydet";
            kryptonButton8.Click += Click;
            // 
            // dgv_MealList
            // 
            dgv_MealList.Location = new Point(22, 119);
            dgv_MealList.Name = "dgv_MealList";
            dgv_MealList.RowTemplate.Height = 25;
            dgv_MealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_MealList.Size = new Size(337, 238);
            dgv_MealList.TabIndex = 5;
            // 
            // kryptonButton6
            // 
            kryptonButton6.CornerRoundingRadius = -1F;
            kryptonButton6.Location = new Point(644, 75);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(107, 25);
            kryptonButton6.TabIndex = 4;
            kryptonButton6.Tag = "6";
            kryptonButton6.Values.Text = "Öğünlerim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 396);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 398);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Gram";
            // 
            // kryptonButton7
            // 
            kryptonButton7.CornerRoundingRadius = -1F;
            kryptonButton7.Location = new Point(252, 388);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.Size = new Size(107, 25);
            kryptonButton7.TabIndex = 4;
            kryptonButton7.Tag = "8";
            kryptonButton7.Values.Text = "+";
            kryptonButton7.Click += Click;
            // 
            // kryptonButton9
            // 
            kryptonButton9.CornerRoundingRadius = -1F;
            kryptonButton9.Location = new Point(420, 388);
            kryptonButton9.Name = "kryptonButton9";
            kryptonButton9.Size = new Size(107, 25);
            kryptonButton9.TabIndex = 4;
            kryptonButton9.Tag = "9";
            kryptonButton9.Values.Text = "-";
            kryptonButton9.Click += Click;
            // 
            // nud_Amount
            // 
            nud_Amount.Location = new Point(72, 391);
            nud_Amount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Amount.Name = "nud_Amount";
            nud_Amount.Size = new Size(120, 22);
            nud_Amount.TabIndex = 7;
            nud_Amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormMeals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(nud_Amount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_MealList);
            Controls.Add(kryptonButton6);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton9);
            Controls.Add(kryptonButton7);
            Controls.Add(kryptonButton8);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(txt_Meal_Search);
            Controls.Add(dgv_SelectedMealList);
            Name = "FormMeals";
            ShowInTaskbar = false;
            Text = "FormMeals";
            Load += FormMeals_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedMealList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_MealList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonDataGridView dgv_SelectedMealList;
        private TextBox txt_Meal_Search;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonDataGridView dgv_MealList;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private Krypton.Toolkit.KryptonButton kryptonButton9;
        private Krypton.Toolkit.KryptonNumericUpDown nud_Amount;
    }
}