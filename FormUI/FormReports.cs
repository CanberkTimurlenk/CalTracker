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
            userId = _userId;
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

            FormDailyReport daily = new FormDailyReport(_userId);
            daily.MdiParent = this;
            daily.Show();
        }

        private void FormReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void gunlukRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDailyReport daily = new FormDailyReport(_userId);
            CloseOtherChildForms(daily);
        }

        private void haftalikKiyasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompareWeekly weekly = new FormCompareWeekly(_userId);
            CloseOtherChildForms(weekly);
        }

        private void aylikKiyasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompareMonthly monthly = new FormCompareMonthly(_userId);
            CloseOtherChildForms(monthly);            
        }

        private void yemekRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostConsumed mostConsumed = new FormMostConsumed(_userId);
            CloseOtherChildForms(mostConsumed);
            
        }
        private void CloseOtherChildForms<T>(T form) where T : Form
        {
            if (ActiveMdiChild != null)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
