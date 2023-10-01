using Entities.Dtos;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormCompareWeekly : Form
    {

        private readonly IUserMealService _userMealService = new UserMealManager();
        public FormCompareWeekly()
        {
            InitializeComponent();
        }

        private void FormCompareWeekly_Load(object sender, EventArgs e)
        {
             var x = _userMealService.GetUserNutrionalsAllByDateRange(DateTime.Now.AddDays(-7), DateTime.Now,1);


        }
    }
}
