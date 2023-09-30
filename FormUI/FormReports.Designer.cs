namespace FormUI
{
    partial class FormReports
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
            menuStrip1 = new MenuStrip();
            gunlukRaporToolStripMenuItem = new ToolStripMenuItem();
            kiyasRaporuToolStripMenuItem = new ToolStripMenuItem();
            yemekRaporuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gunlukRaporToolStripMenuItem, kiyasRaporuToolStripMenuItem, yemekRaporuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gunlukRaporToolStripMenuItem
            // 
            gunlukRaporToolStripMenuItem.Name = "gunlukRaporToolStripMenuItem";
            gunlukRaporToolStripMenuItem.Size = new Size(112, 24);
            gunlukRaporToolStripMenuItem.Text = "Gunluk Rapor";
            // 
            // kiyasRaporuToolStripMenuItem
            // 
            kiyasRaporuToolStripMenuItem.Name = "kiyasRaporuToolStripMenuItem";
            kiyasRaporuToolStripMenuItem.Size = new Size(109, 24);
            kiyasRaporuToolStripMenuItem.Text = "Kiyas Raporu";
            // 
            // yemekRaporuToolStripMenuItem
            // 
            yemekRaporuToolStripMenuItem.Name = "yemekRaporuToolStripMenuItem";
            yemekRaporuToolStripMenuItem.Size = new Size(118, 24);
            yemekRaporuToolStripMenuItem.Text = "Yemek Raporu";
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReports";
            Text = "FormReports";
            Load += FormReports_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gunlukRaporToolStripMenuItem;
        private ToolStripMenuItem kiyasRaporuToolStripMenuItem;
        private ToolStripMenuItem yemekRaporuToolStripMenuItem;
    }
}