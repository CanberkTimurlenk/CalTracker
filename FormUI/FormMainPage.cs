using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Repositories.Context;
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
        KaloriTakipDbContext db = new KaloriTakipDbContext();


        public FormMainPage(User user)
        {
            _user = user;
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
            lbl_Welcome.Text = $"Hoşgeldin :  {_user.FirstName} {_user.LastName} ";
            lbl_BmiStatus.Text = $"Bmi İndeksiniz : {_userService.CalculateBmi(_user.Id, _user.Height, _user.Weight)}";
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            new FormSettings(_user.Id).Show();

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            new FormReports(_user.Id).Show();
        }

        private void btn_CalorieTrack_Click(object sender, EventArgs e)
        {
            new FormMeals(_user.Id).Show();
        }
    }
}



