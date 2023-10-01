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
            dgv_MealList = new Krypton.Toolkit.KryptonDataGridView();
            label1 = new Label();
            label2 = new Label();
            nud_Amount = new Krypton.Toolkit.KryptonNumericUpDown();
            btn_Breakfast = new Krypton.Toolkit.KryptonButton();
            btn_Lunch = new Krypton.Toolkit.KryptonButton();
            btn_Dinner = new Krypton.Toolkit.KryptonButton();
            btn_Snack = new Krypton.Toolkit.KryptonButton();
            btn_Search = new Krypton.Toolkit.KryptonButton();
            btn_Add = new Krypton.Toolkit.KryptonButton();
            btn_Remove = new Krypton.Toolkit.KryptonButton();
            btn_Save = new Krypton.Toolkit.KryptonButton();
            nud_Amount = new Krypton.Toolkit.KryptonNumericUpDown();
            pb_Food = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedMealList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_MealList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Food).BeginInit();
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
            // 
            // txt_Meal_Search
            // 
            txt_Meal_Search.Location = new Point(25, 98);
            txt_Meal_Search.Margin = new Padding(3, 4, 3, 4);
            txt_Meal_Search.Name = "txt_Meal_Search";
            txt_Meal_Search.Size = new Size(327, 27);
            txt_Meal_Search.TabIndex = 3;
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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 519);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 6;
            label1.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(225, 519);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 6;
            label2.Text = "Gram";
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
            // btn_Breakfast
            // 
            btn_Breakfast.CornerRoundingRadius = 40F;
            btn_Breakfast.Location = new Point(3, 7);
            btn_Breakfast.Margin = new Padding(3, 4, 3, 4);
            btn_Breakfast.Name = "btn_Breakfast";
            btn_Breakfast.OverrideDefault.Back.Color1 = Color.White;
            btn_Breakfast.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Breakfast.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Breakfast.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Breakfast.Size = new Size(166, 53);
            btn_Breakfast.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Breakfast.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Breakfast.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Breakfast.StateCommon.Border.Rounding = 40F;
            btn_Breakfast.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Breakfast.TabIndex = 8;
            btn_Breakfast.TabStop = false;
            btn_Breakfast.Values.Text = "Sabah";
            btn_Breakfast.Click += btn_Breakfast_Click;
            // 
            // btn_Lunch
            // 
            btn_Lunch.CornerRoundingRadius = 40F;
            btn_Lunch.Location = new Point(175, 7);
            btn_Lunch.Margin = new Padding(3, 4, 3, 4);
            btn_Lunch.Name = "btn_Lunch";
            btn_Lunch.OverrideDefault.Back.Color1 = Color.White;
            btn_Lunch.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Lunch.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Lunch.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Lunch.Size = new Size(166, 53);
            btn_Lunch.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Lunch.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Lunch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Lunch.StateCommon.Border.Rounding = 40F;
            btn_Lunch.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Lunch.TabIndex = 8;
            btn_Lunch.TabStop = false;
            btn_Lunch.Values.Text = "Öğlen";
            btn_Lunch.Click += btn_Lunch_Click;
            // 
            // btn_Dinner
            // 
            btn_Dinner.CornerRoundingRadius = 40F;
            btn_Dinner.Location = new Point(353, 7);
            btn_Dinner.Margin = new Padding(3, 4, 3, 4);
            btn_Dinner.Name = "btn_Dinner";
            btn_Dinner.OverrideDefault.Back.Color1 = Color.White;
            btn_Dinner.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Dinner.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Dinner.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Dinner.Size = new Size(166, 53);
            btn_Dinner.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Dinner.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Dinner.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Dinner.StateCommon.Border.Rounding = 40F;
            btn_Dinner.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Dinner.TabIndex = 8;
            btn_Dinner.TabStop = false;
            btn_Dinner.Values.Text = "Akşam";
            btn_Dinner.Click += btn_Dinner_Click;
            // 
            // btn_Snack
            // 
            btn_Snack.CornerRoundingRadius = 40F;
            btn_Snack.Location = new Point(525, 7);
            btn_Snack.Margin = new Padding(3, 4, 3, 4);
            btn_Snack.Name = "btn_Snack";
            btn_Snack.OverrideDefault.Back.Color1 = Color.White;
            btn_Snack.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Snack.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Snack.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Snack.Size = new Size(166, 53);
            btn_Snack.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Snack.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Snack.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Snack.StateCommon.Border.Rounding = 40F;
            btn_Snack.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Snack.TabIndex = 8;
            btn_Snack.TabStop = false;
            btn_Snack.Values.Text = "Aperatif";
            btn_Snack.Click += btn_Snack_Click;
            // 
            // btn_Search
            // 
            btn_Search.CornerRoundingRadius = 40F;
            btn_Search.Location = new Point(375, 83);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.OverrideDefault.Back.Color1 = Color.White;
            btn_Search.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Search.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Search.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Search.Size = new Size(72, 42);
            btn_Search.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Search.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Search.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Search.StateCommon.Border.Rounding = 40F;
            btn_Search.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Search.TabIndex = 8;
            btn_Search.TabStop = false;
            btn_Search.Values.Text = "Ara";
            btn_Search.Click += btn_Search_Click;
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
            dgv_MealList.CellContentClick += dgv_MealList_CellContentClick;
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
            btn_Add.CornerRoundingRadius = 40F;
            btn_Add.Location = new Point(338, 519);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.OverrideDefault.Back.Color1 = Color.White;
            btn_Add.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Add.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Add.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Add.Size = new Size(72, 42);
            btn_Add.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Add.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Add.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Add.StateCommon.Border.Rounding = 40F;
            btn_Add.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Add.TabIndex = 8;
            btn_Add.TabStop = false;
            btn_Add.Values.Text = "+";
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.CornerRoundingRadius = 40F;
            btn_Remove.Location = new Point(491, 519);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.OverrideDefault.Back.Color1 = Color.White;
            btn_Remove.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Remove.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Remove.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Remove.Size = new Size(72, 42);
            btn_Remove.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Remove.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Remove.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Remove.StateCommon.Border.Rounding = 40F;
            btn_Remove.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Remove.TabIndex = 8;
            btn_Remove.TabStop = false;
            btn_Remove.Values.Text = "-";
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Save
            // 
            btn_Save.CornerRoundingRadius = 40F;
            btn_Save.Location = new Point(708, 521);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.OverrideDefault.Back.Color1 = Color.White;
            btn_Save.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Save.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.Size = new Size(125, 42);
            btn_Save.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.StateCommon.Border.Rounding = 40F;
            btn_Save.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.TabIndex = 8;
            btn_Save.TabStop = false;
            btn_Save.Values.Text = "Kaydet";
            btn_Save.Click += btn_Save_Click;
            // 
            // pb_Food
            // 
            pb_Food.Location = new Point(62, 589);
            pb_Food.Name = "pb_Food";
            pb_Food.Size = new Size(807, 392);
            pb_Food.TabIndex = 8;
            pb_Food.TabStop = false;
            // 
            // FormMeals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 743);
            Controls.Add(btn_Save);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Add);
            Controls.Add(btn_Search);
            Controls.Add(btn_Snack);
            Controls.Add(btn_Dinner);
            Controls.Add(btn_Lunch);
            Controls.Add(btn_Breakfast);
            Controls.Add(nud_Amount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_MealList);
            Controls.Add(txt_Meal_Search);
            Controls.Add(dgv_SelectedMealList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMeals";
            ShowInTaskbar = false;
            Text = "FormMeals";
            Load += FormMeals_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedMealList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_MealList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Food).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonDataGridView dgv_SelectedMealList;
        private TextBox txt_Meal_Search;
        private Krypton.Toolkit.KryptonDataGridView dgv_MealList;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonNumericUpDown nud_Amount;
        private Krypton.Toolkit.KryptonButton btn_Breakfast;
        private Krypton.Toolkit.KryptonButton btn_Lunch;
        private Krypton.Toolkit.KryptonButton btn_Dinner;
        private Krypton.Toolkit.KryptonButton btn_Snack;
        private Krypton.Toolkit.KryptonButton btn_Search;
        private Krypton.Toolkit.KryptonButton btn_Add;
        private Krypton.Toolkit.KryptonButton btn_Remove;
        private Krypton.Toolkit.KryptonButton btn_Save;
        private Krypton.Toolkit.KryptonNumericUpDown nud_Amount;
        private PictureBox pb_Food;
    }
}