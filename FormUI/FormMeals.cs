using Entities.Enums;
using Krypton.Toolkit;
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
    public partial class FormMeals : Form
    {
        private static MealTimes selectedMealTime;
        private readonly IFoodService _foodService = new FoodManager();

        public FormMeals()
        {
            InitializeComponent();
        }

        private void FormMeals_Load(object sender, EventArgs e)
        {
            dgv_SelectedMealList.Columns.Add("Name", "İsim");
            dgv_SelectedMealList.Columns.Add("Calorie", "Kalori");
            dgv_SelectedMealList.Columns.Add("Fat", "Yağ");
            dgv_SelectedMealList.Columns.Add("Carbonhidrate", "Karbonhidrat");
            dgv_SelectedMealList.Columns.Add("Protein", "Protein");
            dgv_SelectedMealList.ReadOnly = true;
            dgv_MealList.ReadOnly = true;
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

        private void Click(object sender, EventArgs e)
        {
            KryptonButton btn = sender as KryptonButton;

            //Todo enum.tag
            switch (btn.Tag)
            {
                case "1":
                    selectedMealTime = MealTimes.Breakfast;
                    ButtonActivities(btn);
                    break;
                case "2":
                    selectedMealTime = MealTimes.Lunch;
                    ButtonActivities(btn);
                    break;
                case "3":
                    selectedMealTime = MealTimes.Dinner;
                    ButtonActivities(btn);
                    break;
                case "4":
                    selectedMealTime = MealTimes.Snack;
                    ButtonActivities(btn);
                    break;
                case "5":

                    var data = _foodService.GetFoodNamesContains(txt_Meal_Search.Text.Trim());
                    dgv_MealList.DataSource = data.Select(f => new { İsim = f }).ToList();

                    break;
                case "6":
                    selectedMealTime = MealTimes.Lunch;
                    ButtonActivities(btn);
                    break;
                case "7":

                    break;
                case "8":

                    if (dgv_MealList.SelectedRows.Count > 0 && dgv_MealList.SelectedRows[0].Cells[0].Value != null)
                    {
                        var selectedFoodName = dgv_MealList.SelectedRows[0].Cells[0].Value.ToString();
                        var data1 = _foodService.GetFoodsNameBy(selectedFoodName);
                        dgv_SelectedMealList.Rows.Add(data1.Name, Math.Round(((data1.Calorie / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Fat / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Carbonhidrate / data1.Gram) * (double)nud_Amount.Value), 2), Math.Round(((data1.Protein / data1.Gram) * (double)nud_Amount.Value), 2));
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Eklenecek  Besini Seçiniz");
                    }
                    break;
                case "9":
                    if (dgv_SelectedMealList.SelectedRows.Count > 0 && dgv_SelectedMealList.SelectedRows[0].Cells[0].Value != null)
                    {
                        dgv_SelectedMealList.Rows.Remove(dgv_SelectedMealList.SelectedRows[0]);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Silinecek Besini Seçiniz");
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
