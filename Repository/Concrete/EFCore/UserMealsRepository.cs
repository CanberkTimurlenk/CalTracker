using Entities.Concrete;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Repository.Abstract;
using Repository.Abstract.Base;
using Repository.Context;

namespace Repository.Concrete.EFCore
{
    public class UserMealsRepository : BaseRepository<UserMeal>, IUserMealRepository
    {

        public UserMeal GetUserMealByUserIdAndMealDateAndMealTime(int userId, DateTime mealDate, MealTimes mealTime)
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

        public IEnumerable<UserMeal> GetUserMealsByUserIdAndMealDate(int userId, DateTime mealDate)
        {
            using var context = new KaloriTakipDbContext();

            var result = context.UserMeals.Where(um => um.UserId.Equals(userId)
                                            && um.MealDate.Date.Equals(mealDate.Date))
                                          .Include(um => um.FoodAmounts)
                                          .ThenInclude(fa => fa.Food)
                                          .ToList();

            return result;

        }
        public IEnumerable<UserMeal> GetUserMealsAllByDateRange(DateTime startDate, DateTime endDate)
        {
            using var context = new KaloriTakipDbContext();
            return GetUserMealsByDateRangeAsQueryable(startDate, endDate, context).ToList();

        }

        public IEnumerable<UserMeal> GetUserMealsByUserIdAndDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            using var context = new KaloriTakipDbContext();

            var result = GetUserMealsByDateRangeAsQueryable(startDate, endDate, context)
                                .Where(um => um.UserId.Equals(userId))
                                .ToList();

            return result;

        }

        private IQueryable<UserMeal> GetUserMealsByDateRangeAsQueryable(DateTime startDate, DateTime endDate, KaloriTakipDbContext context)
        {
            var query = context.UserMeals.Where(um => um.MealDate >= startDate
                                            && um.MealDate <= endDate)
                                          .Include(um => um.FoodAmounts)
                                          .ThenInclude(fa => fa.Food);

            return query;

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
