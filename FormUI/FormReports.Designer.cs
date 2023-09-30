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
            menuStrip1.Items.AddRange(new ToolStripItem[] { gunlukRaporToolStripMenuItem, kiyasRaporuToolStripMenuItem, yemekRaporuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gunlukRaporToolStripMenuItem
            // 
            gunlukRaporToolStripMenuItem.Name = "gunlukRaporToolStripMenuItem";
            gunlukRaporToolStripMenuItem.Size = new Size(91, 20);
            gunlukRaporToolStripMenuItem.Text = "Gunluk Rapor";
            // 
            // kiyasRaporuToolStripMenuItem
            // 
            kiyasRaporuToolStripMenuItem.Name = "kiyasRaporuToolStripMenuItem";
            kiyasRaporuToolStripMenuItem.Size = new Size(87, 20);
            kiyasRaporuToolStripMenuItem.Text = "Kiyas Raporu";
            // 
            // yemekRaporuToolStripMenuItem
            // 
            yemekRaporuToolStripMenuItem.Name = "yemekRaporuToolStripMenuItem";
            yemekRaporuToolStripMenuItem.Size = new Size(95, 20);
            yemekRaporuToolStripMenuItem.Text = "Yemek Raporu";
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormReports";
            Text = "FormReports";
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