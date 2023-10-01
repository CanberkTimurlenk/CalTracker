using Entities.Concrete;
using Entities.Enums;
using Repository.Abstract.Base;

namespace Repository.Abstract
{
    public interface IUserMealsRepository : IBaseRepository<UserMeal>
    {
        UserMeal GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime);
        int GetUserMealIdByUserIdAndMealDateAndMealTime(int userId, DateTime mealDate, MealTimes mealTime);
    }
}
