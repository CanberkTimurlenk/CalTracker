using Entities.Concrete;
using Services.Abstract;
using Services.Concrete;
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
        private readonly User _user;
        private readonly IUserService _userService = new UserManager();
        public FormMainPage(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {
            SetBackgroundColor();
            lbl_Welcome.Text = $"Hoşgeldin :  {_user.FirstName} {_user.LastName} ";
            lbl_BmiStatus.Text = $"Bmi İndeksiniz : {_userService.CalculateBmi(_user.Id, _user.Height, _user.Weight)}";
        }

        private void btn_CalorieTrack_Click(object sender, EventArgs e)
        {
            FormMeals meals = new FormMeals(_user.Id);
            meals.Show();
            meals.Owner = this;
            this.Hide();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports(_user.Id);
            reports.Show();
            reports.Owner = this;
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings(_user.Id);
            settings.Show();
            settings.Owner = this;
            this.Hide();
        }

        private void SetBackgroundColor()
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

        private void FormMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ToDo: cikis yapilip logine donmesi iyi olabilir
        }
    }
}



