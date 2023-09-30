using Entities.Dtos;
using Entities.Enums;
using Krypton.Toolkit;
using Repository.Abstract;
using Services.Abstract;
using Services.Concrete;
using System.Data;
using System.Drawing.Drawing2D;

namespace FormUI
{

    public partial class FormMeals : Form
    {

        private static MealTimes selectedMealTime;
        private readonly IFoodService _foodService = new FoodManager();
        private readonly IUserMealService _userMealService = new UserMealManager();
        private readonly IFoodAmountService _foodAmountService = new FoodAmountManager();
        private readonly int _userId = 5; // BURAYI CONSTRUCTOR DA ALACAK
        private List<MealItem> _mealItemToDelete = new List<MealItem>();
        private List<MealItem> _mealItemToAdd = new List<MealItem>();
        private List<FoodNutrionals> _dataSource = new();

        public FormMeals()
        {
            InitializeComponent();
        }

        private void FormMeals_Load(object sender, EventArgs e)
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
            btn_Search.Enabled = false;
            btn_Save.Enabled = false;
            /*
            dgv_SelectedMealList.Columns.Add("Name", "İsim");
            dgv_SelectedMealList.Columns.Add("Calorie", "Kalori");
            dgv_SelectedMealList.Columns.Add("Fat", "Yağ");
            dgv_SelectedMealList.Columns.Add("Carbonhidrate", "Karbonhidrat");
            dgv_SelectedMealList.Columns.Add("Protein", "Protein");
            */
            dgv_SelectedMealList.AllowUserToAddRows = false;
            dgv_SelectedMealList.ReadOnly = true;
            dgv_MealList.ReadOnly = true;


        }


        private void Click(object sender, EventArgs e)
        {

        }

        private void btn_Breakfast_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Breakfast;
            /*
            _dataSource = _userMealService.GetUserMeals(_userId, DateTime.Now, selectedMealTime).ToList();
            dgv_SelectedMealList.DataSource = _dataSource;
            */
            SetDgvContent();
            ButtonActivities(btn);

        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Lunch;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Dinner;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Snack_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Snack;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var data = _foodService.GetFoodNamesContains(txt_Meal_Search.Text.Trim());
            dgv_MealList.DataSource = data.Select(f => new { İsim = f }).ToList();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var userMealId = _userMealService.CreateUserMeal(_userId, selectedMealTime, DateTime.Now);

            // add meal item
            // FoodId, Gram, UserMealId

            // elimde olanlar foodname,gram, usermealId

            if (_mealItemToAdd.Count > 0)
                _foodAmountService.AddRangeMealItems(_mealItemToAdd, userMealId);

            if (_mealItemToDelete.Count > 0)
                _foodAmountService.RemoveRangeMealItems(_mealItemToDelete, userMealId);


            _mealItemToDelete.Clear();
            _mealItemToAdd.Clear();

            //CreateUserMeal(int userId, );
            /*
            if (!btn_Breakfast.Enabled || !btn_Lunch.Enabled || !btn_Dinner.Enabled || !btn_Snack.Enabled)
            {

                //UserMeals userMeals = new UserMeals()
                //{
                //    MealTimes = selectedMealTime,
                //    Calorie = 

                //}
            }
            else
            {
                MessageBox.Show("Secili Degil");
            }
            btn_Search.Enabled = false;
            */
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dgv_MealList.SelectedRows.Count > 0 && dgv_MealList.SelectedRows[0].Cells[0].Value != null)
            {
                var selectedFoodName = dgv_MealList.SelectedRows[0].Cells[0].Value.ToString();

                var foodWithNutrionals = _foodService.GetFoodNutrionals(selectedFoodName, Convert.ToInt32(nud_Amount.Value));

                _dataSource.Add(foodWithNutrionals);
                dgv_SelectedMealList.DataSource = null;
                dgv_SelectedMealList.DataSource = _dataSource;

                _mealItemToAdd.Add(new MealItem()
                {
                    UserId = _userId,
                    FoodName = selectedFoodName,
                    Gram = Convert.ToInt32(nud_Amount.Value)
                });
                //var data1 = _foodService.GetFoodsNameBy(selectedFoodName);
                //dgv_SelectedMealList.Rows.Add(data1.Name, Math.Round(((data1.Calorie / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Fat / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Carbonhidrate / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Protein / data1.Gram) * (double)nud_Amount.Value), 2));
            }

            else
                MessageBox.Show("Lütfen Eklenecek  Besini Seçiniz");

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_SelectedMealList.SelectedRows.Count > 0 && dgv_SelectedMealList.SelectedRows[0].Cells[0].Value != null)
            {
                var selectedFoodName = dgv_SelectedMealList.SelectedRows[0].Cells[0].Value.ToString();
                var selectedFoodGram = Convert.ToInt32(dgv_SelectedMealList.SelectedRows[0].Cells[2].Value);
                var itemToDelete = _dataSource.Find(x => x.FoodName == selectedFoodName && x.Gram == selectedFoodGram);

                _dataSource.Remove(itemToDelete);
                dgv_SelectedMealList.DataSource = null;
                dgv_SelectedMealList.DataSource = _dataSource;

                _mealItemToDelete.Add(new MealItem()
                {
                    UserId = _userId,
                    FoodName = selectedFoodName,
                    Gram = Convert.ToInt32(nud_Amount.Value)
                });

            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Besini Seçiniz");
            }
        }

        private void ButtonActivities(KryptonButton btn)
        {
            foreach (Control item in this.Controls)
            {
                if (item is KryptonButton)
                {
                    ((KryptonButton)item).Enabled = true;
                }
            }
            btn.Enabled = false;
        }

        private void SetButtonStates()
        {
            if (btn_Search.Enabled.Equals(false))
                btn_Search.Enabled = true;

            btn_Save.Enabled = true;
        }

        private void SetDgvContent()
        {
            _dataSource = _userMealService.GetUserMeals(_userId, DateTime.Now, selectedMealTime).ToList();
            dgv_SelectedMealList.DataSource = _dataSource;
        }

        private void dgv_SelectedMealList_SelectionChanged(object sender, EventArgs e)
        {
            /*
            var X = dgv_MealList.SelectedRows[0].DataBoundItem as FoodMealDto;
            int z = 5;
            */
        }

        private void dgv_SelectedMealList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //var foodname = dgv_MealList.SelectedRows[0].Cells[0].Value; // name
            //var gram = dgv_MealList.SelectedRows[0].Cells[2].Value; // gram
        }


    }
}