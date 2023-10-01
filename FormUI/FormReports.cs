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
        public FormReports()
        {
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

            FormDailyReport daily = new FormDailyReport();
            daily.MdiParent = this;
            daily.Show();
        }

        private void FormReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void gunlukRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDailyReport daily = new FormDailyReport();
            //CloseOtherChildForms(daily);
            daily.MdiParent = this;
            daily.Show();
        }

        private void haftalikKiyasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompareWeekly weekly = new FormCompareWeekly();
            //CloseOtherChildForms(weekly);
            weekly.MdiParent = this;
            weekly.Show();
        }

        private void aylikKiyasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompareMonthly monthly = new FormCompareMonthly();
            //CloseOtherChildForms(monthly);
            monthly.MdiParent = this;
            monthly.Show();
        }

        private void yemekRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostConsumed mostConsumed = new FormMostConsumed();
            //CloseOtherChildForms(mostConsumed);
            mostConsumed.MdiParent = this;
            mostConsumed.Show();
        }
        private void CloseOtherChildForms(Form form)
        {
            //foreach icinde patliyor(InvalidOperationException)
            foreach (Form f in Application.OpenForms)
            {
                if (f != form)
                    f.Close();
            }
        }
    }
}
