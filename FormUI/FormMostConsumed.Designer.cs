namespace FormUI
{
    partial class FormMostConsumed
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Breakfast = new Label();
            lbl_Lunch = new Label();
            lbl_Dinner = new Label();
            lbl_Snack = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(248, 226);
            label1.Name = "label1";
            label1.Size = new Size(101, 72);
            label1.TabIndex = 0;
            label1.Text = "Kahvalti";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(388, 226);
            label2.Name = "label2";
            label2.Size = new Size(88, 72);
            label2.TabIndex = 0;
            label2.Text = "Oglen";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(524, 226);
            label3.Name = "label3";
            label3.Size = new Size(92, 72);
            label3.TabIndex = 0;
            label3.Text = "Aksam";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(657, 226);
            label4.Name = "label4";
            label4.Size = new Size(102, 72);
            label4.TabIndex = 0;
            label4.Text = "Aperatif";
            // 
            // lbl_Breakfast
            // 
            lbl_Breakfast.BackColor = Color.Transparent;
            lbl_Breakfast.Location = new Point(258, 264);
            lbl_Breakfast.Name = "lbl_Breakfast";
            lbl_Breakfast.Size = new Size(80, 72);
            lbl_Breakfast.TabIndex = 0;
            lbl_Breakfast.Text = "food";
            // 
            // lbl_Lunch
            // 
            lbl_Lunch.BackColor = Color.Transparent;
            lbl_Lunch.Location = new Point(388, 264);
            lbl_Lunch.Name = "lbl_Lunch";
            lbl_Lunch.Size = new Size(80, 72);
            lbl_Lunch.TabIndex = 0;
            lbl_Lunch.Text = "food";
            // 
            // lbl_Dinner
            // 
            lbl_Dinner.BackColor = Color.Transparent;
            lbl_Dinner.Location = new Point(524, 264);
            lbl_Dinner.Name = "lbl_Dinner";
            lbl_Dinner.Size = new Size(80, 72);
            lbl_Dinner.TabIndex = 0;
            lbl_Dinner.Text = "food";
            // 
            // lbl_Snack
            // 
            lbl_Snack.BackColor = Color.Transparent;
            lbl_Snack.Location = new Point(669, 264);
            lbl_Snack.Name = "lbl_Snack";
            lbl_Snack.Size = new Size(80, 72);
            lbl_Snack.TabIndex = 0;
            lbl_Snack.Text = "food";
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(128, 264);
            label13.Name = "label13";
            label13.Size = new Size(118, 72);
            label13.TabIndex = 0;
            label13.Text = "Yemek Adi";
            // 
            // FormMostConsumed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 544);
            Controls.Add(lbl_Snack);
            Controls.Add(lbl_Dinner);
            Controls.Add(label4);
            Controls.Add(lbl_Lunch);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(lbl_Breakfast);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMostConsumed";
            Text = "FormMostConsumed";
            Load += FormMostConsumed_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Breakfast;
        private Label lbl_Lunch;
        private Label lbl_Dinner;
        private Label lbl_Snack;
        private Label label13;
    }
}