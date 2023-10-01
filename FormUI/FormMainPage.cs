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
    public partial class FormMainPage : Form
    {
        private readonly int _userId;
        public FormMainPage()
        {
            //_userId = userId;
            InitializeComponent();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
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

        private void btn_CalorieTrack_Click(object sender, EventArgs e)
        {
            FormMeals meals = new FormMeals();
            meals.Show();
            meals.Owner = this;
            this.Hide();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports();
            reports.Show();
            reports.Owner = this;
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.Show();
            settings.Owner = this;
            this.Hide();
        }

        private void FormMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cikis yapilip logine donmesi iyi olabilir
        }
    }
}



