using Entities.Concrete;
using Entities.Enums;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IUserMealService
    {
        IEnumerable<FoodNutrionals> GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime);
        int CreateUserMeal(int userId, MealTimes mealTime, DateTime date);
    }
}
