using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormReports : Form
    {
        private readonly int _userId;
        public FormReports(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(32, 191, 107);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(32, 191, 107),
                Color.FromArgb(50, 210, 255),
                360f
            );
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            };
        }

        private void gunlukRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDailyReport(_userId).Show();
        }

        private void kiyasRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //batuhan sor
        }

        private void yemekRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMostConsumed(_userId).Show();   
        }
    }
}
