using Entities.Concrete;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repository.Abstract;
using Repository.Abstract.Base;

namespace Repository.Concrete.EFCore
{
    public class UserMealsRepository : BaseRepository<UserMeal>, IUserMealsRepository
    {

        public UserMeal GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime)
        {
            using var context = new KaloriTakipDbContext();

            var result = context.UserMeals.Where(um => um.UserId.Equals(userId)
                                            && um.MealDate.Date.Equals(mealDate.Date)
                                            && um.MealTime == mealTime)
                                          .Include(um => um.FoodAmounts)
                                          .ThenInclude(fa => fa.Food)
                                          .FirstOrDefault();
            return result;

        }

        public int GetUserMealIdByUserIdAndMealDateAndMealTime(int userId, DateTime mealDate, MealTimes mealTime)
        {
            using var context = new KaloriTakipDbContext();

            return context.UserMeals.Where(um => um.UserId.Equals(userId)
                                        && um.MealDate.Date.Equals(mealDate.Date)
                                        && um.MealTime == mealTime)
                                    .Select(um => um.Id)                
                                    .FirstOrDefault();
        }
    }
}
