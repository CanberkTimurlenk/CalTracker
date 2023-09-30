using Krypton.Toolkit;

namespace FormUI
{
    partial class FormAdmin
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
            txt_FoodName = new KryptonTextBox();
            kryptonLabel1 = new KryptonLabel();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            kryptonLabel4 = new KryptonLabel();
            kryptonLabel5 = new KryptonLabel();
            kryptonLabel6 = new KryptonLabel();
            kryptonLabel7 = new KryptonLabel();
            pb_FoodPicture = new PictureBox();
            btn_SelectPicture = new KryptonButton();
            btn_Save = new KryptonButton();
            kryptonLabel8 = new KryptonLabel();
            cmb_FoodCategory = new KryptonComboBox();
            nud_Calorie = new KryptonNumericUpDown();
            nud_Protein = new KryptonNumericUpDown();
            nud_Fat = new KryptonNumericUpDown();
            nud_Carbonhidrate = new KryptonNumericUpDown();
            nud_Gram = new KryptonNumericUpDown();
            txt_PictureUrl = new KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)pb_FoodPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmb_FoodCategory).BeginInit();
            SuspendLayout();
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(109, 35);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.PaletteMode = PaletteMode.Office365Silver;
            txt_FoodName.Size = new Size(120, 23);
            txt_FoodName.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(65, 35);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel1.Size = new Size(33, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Isim";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(57, 124);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel2.Size = new Size(41, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Kalori";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(48, 170);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel3.Size = new Size(50, 20);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Protein";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(65, 220);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel4.Size = new Size(31, 20);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Yag";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(19, 269);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel5.Size = new Size(82, 20);
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "Karbonhidrat";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(58, 319);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel6.Size = new Size(40, 20);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Gram";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(340, 100);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel7.Size = new Size(43, 20);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Resim";
            // 
            // pb_FoodPicture
            // 
            pb_FoodPicture.Location = new Point(288, 126);
            pb_FoodPicture.Name = "pb_FoodPicture";
            pb_FoodPicture.Size = new Size(152, 114);
            pb_FoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FoodPicture.TabIndex = 2;
            pb_FoodPicture.TabStop = false;
            // 
            // btn_SelectPicture
            // 
            btn_SelectPicture.CornerRoundingRadius = -1F;
            btn_SelectPicture.Location = new Point(320, 255);
            btn_SelectPicture.Name = "btn_SelectPicture";
            btn_SelectPicture.PaletteMode = PaletteMode.Office365Silver;
            btn_SelectPicture.Size = new Size(90, 25);
            btn_SelectPicture.TabIndex = 3;
            btn_SelectPicture.Values.Text = "Resim Ekle";
            btn_SelectPicture.Click += btn_SelectPicture_Click;
            // 
            // btn_Save
            // 
            btn_Save.CornerRoundingRadius = -1F;
            btn_Save.Location = new Point(208, 364);
            btn_Save.Name = "btn_Save";
            btn_Save.PaletteMode = PaletteMode.Office365Silver;
            btn_Save.Size = new Size(90, 25);
            btn_Save.TabIndex = 3;
            btn_Save.Values.Text = "Kaydet";
            btn_Save.Click += btn_Save_Click;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(57, 80);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel8.Size = new Size(41, 20);
            kryptonLabel8.TabIndex = 1;
            kryptonLabel8.Values.Text = "Kalori";
            // 
            // cmb_FoodCategory
            // 
            cmb_FoodCategory.CornerRoundingRadius = -1F;
            cmb_FoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FoodCategory.DropDownWidth = 121;
            cmb_FoodCategory.IntegralHeight = false;
            cmb_FoodCategory.Items.AddRange(new object[] { "Deniz Ürün", "Tavuk", "Meyve", "Tatlı", "Süt ve Süt Ürünleri", "Kırmız Et", "Kahvaltı", "Tahıl", "Soslar", "Fastfood", "Sebze", "Salatalar", "Çerez", "Çorba", "Yağ" });
            cmb_FoodCategory.Location = new Point(109, 79);
            cmb_FoodCategory.Name = "cmb_FoodCategory";
            cmb_FoodCategory.PaletteMode = PaletteMode.Office365Silver;
            cmb_FoodCategory.Size = new Size(121, 21);
            cmb_FoodCategory.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cmb_FoodCategory.TabIndex = 4;
            // 
            // nud_Calorie
            // 
            nud_Calorie.Location = new Point(109, 122);
            nud_Calorie.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Calorie.Name = "nud_Calorie";
            nud_Calorie.PaletteMode = PaletteMode.Office365Silver;
            nud_Calorie.Size = new Size(120, 22);
            nud_Calorie.TabIndex = 5;
            // 
            // nud_Protein
            // 
            nud_Protein.Location = new Point(109, 168);
            nud_Protein.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Protein.Name = "nud_Protein";
            nud_Protein.PaletteMode = PaletteMode.Office365Silver;
            nud_Protein.Size = new Size(120, 22);
            nud_Protein.TabIndex = 5;
            // 
            // nud_Fat
            // 
            nud_Fat.Location = new Point(109, 218);
            nud_Fat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Fat.Name = "nud_Fat";
            nud_Fat.PaletteMode = PaletteMode.Office365Silver;
            nud_Fat.Size = new Size(120, 22);
            nud_Fat.TabIndex = 5;
            // 
            // nud_Carbonhidrate
            // 
            nud_Carbonhidrate.Location = new Point(107, 269);
            nud_Carbonhidrate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Carbonhidrate.Name = "nud_Carbonhidrate";
            nud_Carbonhidrate.PaletteMode = PaletteMode.Office365Silver;
            nud_Carbonhidrate.Size = new Size(120, 22);
            nud_Carbonhidrate.TabIndex = 5;
            // 
            // nud_Gram
            // 
            nud_Gram.Location = new Point(107, 316);
            nud_Gram.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Gram.Name = "nud_Gram";
            nud_Gram.PaletteMode = PaletteMode.Office365Silver;
            nud_Gram.Size = new Size(120, 22);
            nud_Gram.TabIndex = 5;
            // 
            // txt_PictureUrl
            // 
            txt_PictureUrl.Location = new Point(303, 296);
            txt_PictureUrl.Name = "txt_PictureUrl";
            txt_PictureUrl.PaletteMode = PaletteMode.Office365Silver;
            txt_PictureUrl.Size = new Size(120, 23);
            txt_PictureUrl.TabIndex = 0;
            txt_PictureUrl.TextChanged += txt_PictureUrl_TextChanged;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(nud_Gram);
            Controls.Add(nud_Carbonhidrate);
            Controls.Add(nud_Fat);
            Controls.Add(nud_Protein);
            Controls.Add(nud_Calorie);
            Controls.Add(cmb_FoodCategory);
            Controls.Add(btn_Save);
            Controls.Add(btn_SelectPicture);
            Controls.Add(pb_FoodPicture);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel1);
            Controls.Add(txt_PictureUrl);
            Controls.Add(txt_FoodName);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pb_FoodPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmb_FoodCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonTextBox txt_FoodName;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox kryptonTextBox2;
        private KryptonLabel kryptonLabel2;
        private KryptonTextBox kryptonTextBox3;
        private KryptonLabel kryptonLabel3;
        private KryptonTextBox kryptonTextBox4;
        private KryptonLabel kryptonLabel4;
        private KryptonTextBox kryptonTextBox5;
        private KryptonLabel kryptonLabel5;
        private KryptonTextBox kryptonTextBox6;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel7;
        private PictureBox pb_FoodPicture;
        private PictureBox pictureBox1;
        private KryptonButton kryptonButton1;
        private KryptonButton btn_SelectPicture;
        private KryptonButton btn_Save;
        private KryptonLabel kryptonLabel8;
        private KryptonComboBox cmb_FoodCategory;
        private KryptonNumericUpDown nud_Calorie;
        private KryptonNumericUpDown nud_Protein;
        private KryptonNumericUpDown nud_Fat;
        private KryptonNumericUpDown nud_Carbonhidrate;
        private KryptonNumericUpDown nud_Gram;
        private KryptonTextBox txt_PictureUrl;
    }
}