using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormCompareMonthly : Form
    {
        private readonly int _userId;
        IUserMealService _userMealService = new UserMealManager();
        public FormCompareMonthly(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormCompareMonthly_Load(object sender, EventArgs e)
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

            cmb_Categories.DataSource = Enum.GetValues(typeof(Entities.Enums.Categories));
            var user = _userMealService.GetUserNutrionalsByUserIdAndDateRange(_userId, DateTime.Now.AddDays(-7), DateTime.Now, cmb_Categories.SelectedIndex);
            var otherUsers = _userMealService.GetUserNutrionalsAllByDateRange(DateTime.Now.AddDays(-7), DateTime.Now, cmb_Categories.SelectedIndex);

            lbl_Breakfast.Text = user.Breakfast.ToString();
            lbl_lunch.Text = user.Lunch.ToString();
            lbl_Dinner.Text = user.Dinner.ToString();
            lbl_Snack.Text = user.Snack.ToString();
            lbl_Total.Text = (user.Breakfast + user.Lunch + user.Dinner + user.Snack).ToString() + " kcal"; //kategorideki toplam kalori mi?

            lbl_OthersBreakfast.Text = otherUsers.Breakfast.ToString();
            lbl_OthersLunch.Text = otherUsers.Lunch.ToString();
            lbl_OthersDinner.Text = otherUsers.Dinner.ToString();
            lbl_OthersSnack.Text = otherUsers.Snack.ToString();
            lbl_OthersTotal.Text = (otherUsers.Breakfast + otherUsers.Lunch + otherUsers.Dinner + otherUsers.Snack).ToString() + " kcal";
        }
    }
}
