namespace FormUI
{
    partial class FormFoodConsumption
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
            dgv_FoodConsumption = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_FoodConsumption).BeginInit();
            SuspendLayout();
            // 
            // dgv_FoodConsumption
            // 
            dgv_FoodConsumption.ColumnHeadersHeight = 36;
            dgv_FoodConsumption.Location = new Point(44, 46);
            dgv_FoodConsumption.Name = "dgv_FoodConsumption";
            dgv_FoodConsumption.RowHeadersWidth = 51;
            dgv_FoodConsumption.RowTemplate.Height = 29;
            dgv_FoodConsumption.Size = new Size(717, 361);
            dgv_FoodConsumption.TabIndex = 0;
            // 
            // FormFoodConsumption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_FoodConsumption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFoodConsumption";
            Text = "FormFoodConsumption";
            Load += FormFoodConsumption_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_FoodConsumption).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgv_FoodConsumption;
    }
}