using Services.Abstract;
using Services.Concrete;
using Entities.Enums;

namespace FormUI
{
    public partial class FormDailyReport : Form
    {
        private readonly int _userId;
        private readonly IUserMealService _userMealService = new UserMealManager();
        public FormDailyReport()//int userId)
        {
            _userId = 5;
            InitializeComponent();
        }

        private void FormDailyReport_Load(object sender, EventArgs e)
        {
            var userMeals = _userMealService.GetUserMealsByUserIdAndMealDate(_userId, DateTime.Now).ToList();

            var breakFast = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Breakfast);
            var dinner = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Dinner);
            var lunch = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Lunch);
            var snack = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Snack);

            

            lbl_BreakfastCalorie.Text = breakFast?.Nutrionals.Calorie.ToString();
            lbl_BreakfastCarbonhidrate.Text = breakFast?.Nutrionals.Carbonhidrate.ToString();
            lbl_BreakfastFat.Text = breakFast?.Nutrionals.Fat.ToString();
            lbl_BreakfastProtein.Text = breakFast?.Nutrionals.Protein.ToString();

            lbl_LunchCalorie.Text = lunch?.Nutrionals.Calorie.ToString();
            lbl_LunchCarbonhidrate.Text = lunch?.Nutrionals.Carbonhidrate.ToString();
            lbl_LunchFat.Text = lunch?.Nutrionals.Fat.ToString();
            lbl_LunchProtein.Text = lunch?.Nutrionals.Protein.ToString();

            lbl_DinnerCalorie.Text = dinner?.Nutrionals.Calorie.ToString();
            lbl_DinnerCarbonhidrate.Text = dinner?.Nutrionals.Carbonhidrate.ToString();
            lbl_DinnerFat.Text = dinner?.Nutrionals.Fat.ToString();
            lbl_DinnerProtein.Text = dinner?.Nutrionals.Protein.ToString();

            lbl_SnackCalorie.Text = snack?.Nutrionals.Calorie.ToString();
            lbl_SnackCarbonhidrate.Text = snack?.Nutrionals.Carbonhidrate.ToString();
            lbl_SnackFat.Text = snack?.Nutrionals.Fat.ToString();
            lbl_SnackProtein.Text = snack?.Nutrionals.Protein.ToString();

        }
    }
}
