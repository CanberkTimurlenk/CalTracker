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
            btn_Search = new Krypton.Toolkit.KryptonButton();
            btn_Breakfast = new Krypton.Toolkit.KryptonButton();
            btn_Lunch = new Krypton.Toolkit.KryptonButton();
            btn_Dinner = new Krypton.Toolkit.KryptonButton();
            btn_Snack = new Krypton.Toolkit.KryptonButton();
            btn_Save = new Krypton.Toolkit.KryptonButton();
            dgv_MealList = new Krypton.Toolkit.KryptonDataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_Add = new Krypton.Toolkit.KryptonButton();
            btn_Remove = new Krypton.Toolkit.KryptonButton();
            nud_Amount = new Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedMealList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_MealList).BeginInit();
            SuspendLayout();
            // 
            // dgv_SelectedMealList
            // 
            dgv_SelectedMealList.ColumnHeadersHeight = 36;
            dgv_SelectedMealList.Location = new Point(491, 159);
            dgv_SelectedMealList.Margin = new Padding(3, 4, 3, 4);
            dgv_SelectedMealList.Name = "dgv_SelectedMealList";
            dgv_SelectedMealList.RowHeadersWidth = 51;
            dgv_SelectedMealList.RowTemplate.Height = 25;
            dgv_SelectedMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SelectedMealList.Size = new Size(367, 317);
            dgv_SelectedMealList.TabIndex = 0;
            dgv_SelectedMealList.CellContentClick += dgv_SelectedMealList_CellContentClick_1;
            // 
            // txt_Meal_Search
            // 
            txt_Meal_Search.Location = new Point(25, 83);
            txt_Meal_Search.Margin = new Padding(3, 4, 3, 4);
            txt_Meal_Search.Name = "txt_Meal_Search";
            txt_Meal_Search.Size = new Size(327, 27);
            txt_Meal_Search.TabIndex = 3;
            // 
            // btn_Search
            // 
            btn_Search.CornerRoundingRadius = -1F;
            btn_Search.Location = new Point(360, 83);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(50, 33);
            btn_Search.TabIndex = 4;
            btn_Search.Tag = "5";
            btn_Search.Values.Text = "Ara";
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Breakfast
            // 
            btn_Breakfast.CornerRoundingRadius = -1F;
            btn_Breakfast.Location = new Point(25, 16);
            btn_Breakfast.Margin = new Padding(3, 4, 3, 4);
            btn_Breakfast.Name = "btn_Breakfast";
            btn_Breakfast.Size = new Size(122, 33);
            btn_Breakfast.TabIndex = 4;
            btn_Breakfast.Tag = "1";
            btn_Breakfast.Values.Text = "SABAH";
            btn_Breakfast.Click += btn_Breakfast_Click;
            // 
            // btn_Lunch
            // 
            btn_Lunch.CornerRoundingRadius = -1F;
            btn_Lunch.Location = new Point(175, 16);
            btn_Lunch.Margin = new Padding(3, 4, 3, 4);
            btn_Lunch.Name = "btn_Lunch";
            btn_Lunch.Size = new Size(122, 33);
            btn_Lunch.TabIndex = 4;
            btn_Lunch.Tag = "2";
            btn_Lunch.Values.Text = "Öğlen";
            btn_Lunch.Click += btn_Lunch_Click;
            // 
            // btn_Dinner
            // 
            btn_Dinner.CornerRoundingRadius = -1F;
            btn_Dinner.Location = new Point(330, 16);
            btn_Dinner.Margin = new Padding(3, 4, 3, 4);
            btn_Dinner.Name = "btn_Dinner";
            btn_Dinner.Size = new Size(122, 33);
            btn_Dinner.TabIndex = 4;
            btn_Dinner.Tag = "3";
            btn_Dinner.Values.Text = "Akşam";
            btn_Dinner.Click += btn_Dinner_Click;
            // 
            // btn_Snack
            // 
            btn_Snack.CornerRoundingRadius = -1F;
            btn_Snack.Location = new Point(480, 16);
            btn_Snack.Margin = new Padding(3, 4, 3, 4);
            btn_Snack.Name = "btn_Snack";
            btn_Snack.Size = new Size(122, 33);
            btn_Snack.TabIndex = 4;
            btn_Snack.Tag = "4";
            btn_Snack.Values.Text = "Aperatif";
            btn_Snack.Click += btn_Snack_Click;
            // 
            // btn_Save
            // 
            btn_Save.CornerRoundingRadius = -1F;
            btn_Save.Location = new Point(736, 517);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(122, 33);
            btn_Save.TabIndex = 4;
            btn_Save.Tag = "7";
            btn_Save.Values.Text = "Kaydet";
            btn_Save.Click += btn_Save_Click;
            // 
            // dgv_MealList
            // 
            dgv_MealList.ColumnHeadersHeight = 36;
            dgv_MealList.Location = new Point(25, 159);
            dgv_MealList.Margin = new Padding(3, 4, 3, 4);
            dgv_MealList.Name = "dgv_MealList";
            dgv_MealList.RowHeadersWidth = 51;
            dgv_MealList.RowTemplate.Height = 25;
            dgv_MealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_MealList.Size = new Size(385, 317);
            dgv_MealList.TabIndex = 5;
            //             
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 528);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 531);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Gram";
            // 
            // btn_Add
            // 
            btn_Add.CornerRoundingRadius = -1F;
            btn_Add.Location = new Point(288, 517);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(122, 33);
            btn_Add.TabIndex = 4;
            btn_Add.Tag = "8";
            btn_Add.Values.Text = "+";
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.CornerRoundingRadius = -1F;
            btn_Remove.Location = new Point(480, 517);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(122, 33);
            btn_Remove.TabIndex = 4;
            btn_Remove.Tag = "9";
            btn_Remove.Values.Text = "-";
            btn_Remove.Click += btn_Remove_Click;
            // 
            // nud_Amount
            // 
            nud_Amount.Location = new Point(82, 521);
            nud_Amount.Margin = new Padding(3, 4, 3, 4);
            nud_Amount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Amount.Name = "nud_Amount";
            nud_Amount.Size = new Size(137, 26);
            nud_Amount.TabIndex = 7;
            nud_Amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormMeals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 743);
            Controls.Add(nud_Amount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_MealList);
            Controls.Add(btn_Snack);
            Controls.Add(btn_Dinner);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Add);
            Controls.Add(btn_Save);
            Controls.Add(btn_Lunch);
            Controls.Add(btn_Breakfast);
            Controls.Add(btn_Search);
            Controls.Add(txt_Meal_Search);
            Controls.Add(dgv_SelectedMealList);
            Margin = new Padding(3, 4, 3, 4);
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
        private Krypton.Toolkit.KryptonButton btn_Search;
        private Krypton.Toolkit.KryptonButton btn_Breakfast;
        private Krypton.Toolkit.KryptonButton btn_Lunch;
        private Krypton.Toolkit.KryptonButton btn_Dinner;
        private Krypton.Toolkit.KryptonButton btn_Snack;
        private Krypton.Toolkit.KryptonButton btn_Save;
        private Krypton.Toolkit.KryptonDataGridView dgv_MealList;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton btn_Add;
        private Krypton.Toolkit.KryptonButton btn_Remove;
        private Krypton.Toolkit.KryptonNumericUpDown nud_Amount;
    }
}