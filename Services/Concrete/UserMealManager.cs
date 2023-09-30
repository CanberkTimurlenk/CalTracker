using Entities.Concrete;
using Entities.Dtos;
using Entities.Enums;
using Repository.Abstract;
using Repository.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public class UserMealManager : IUserMealService
    {
        private readonly IUserMealsRepository _userMealRepository = new UserMealsRepository();
        public IEnumerable<FoodNutrionals> GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime)
        {
            var userMeals = _userMealRepository.GetUserMeals(userId, mealDate, mealTime);

            if (userMeals is null)
                return new List<FoodNutrionals>();

            var foodList = new List<FoodNutrionals>();

            userMeals.FoodAmounts.ForEach(fa =>
            {
                foodList.Add(new FoodNutrionals
                {
                    FoodName = fa.Food.Name,
                    Gram = fa.Gram,
                    Calorie = Math.Round((fa.Food.Calorie / fa.Food.Gram) * fa.Gram, 2),
                    Carbonhidrate = Math.Round((fa.Food.Carbonhidrate / fa.Food.Gram) * fa.Gram, 2),
                    Fat = Math.Round((fa.Food.Carbonhidrate / fa.Food.Gram) * fa.Gram, 2),
                    Protein = Math.Round((fa.Food.Protein / fa.Food.Gram) * fa.Gram, 2)
                });
            });

            return foodList;
        }

        public int CreateUserMeal(int userId, MealTimes mealTime, DateTime date)
        {
            if (CheckIfUserMealExists(userId, mealTime, date))
                return _userMealRepository.GetUserMealIdByUserIdAndMealDateAndMealTime(userId, date, mealTime);

            var userMeal = new UserMeal { UserId = userId, MealDate = date, MealTime = mealTime };

            _userMealRepository.Create(userMeal);

            return userMeal.Id;

        }

        private bool CheckIfUserMealExists(int userId, MealTimes mealTime, DateTime mealDate)
        
         =>  _userMealRepository.Any(
                um => um.UserId.Equals(userId)
                && um.MealDate.Date.Equals(mealDate.Date)
                && um.MealTime == mealTime);

            

      
        
    }
}

    /*
    public void AddRangeMealItems(List<MealItem> _mealItemToAdd)
    {
        // userId , FoodName , Gram , Date

        foreach (var item in _mealItemToAdd)
        {
            var userMeal = _userMealRepository.GetUserMeals(item.UserId, item.Date, item.MealTime);

            if (userMeal is null)
            {
                userMeal = new UserMeal()
                {
                    UserId = item.UserId,
                    MealDate = item.Date,
                    MealTime = item.MealTime,
                    FoodAmounts = new List<FoodAmount>()
                };
            }

            var foodAmount = new FoodAmount()
            {
                FoodId = item.FoodId,
                Gram = item.Gram
            };

            userMeal.FoodAmounts.Add(foodAmount);

            _userMealRepository.Add(userMeal);


        }
    */

