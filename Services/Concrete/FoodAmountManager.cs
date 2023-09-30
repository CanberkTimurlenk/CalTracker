using Entities.Dtos;
using Repository.Abstract;
using Repository.Concrete.EFCore;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class FoodAmountManager : IFoodAmountService
    {
        private readonly IFoodAmountRepository _foodAmountRepository = new FoodAmountRepository();
        private readonly IFoodService _foodService = new FoodManager();
        public void AddRangeMealItems(IEnumerable<MealItem> mealItems, int userMealId)
        {

            var foodIds = _foodService.GetFoodIdsByFoodName(mealItems.Select(mi => mi.FoodName)).ToList();
            var mealItemList = mealItems.ToList();


            for (int i = 0; i < mealItemList.Count; i++)
            {
                _foodAmountRepository.Create(new FoodAmount()
                {
                    FoodId = foodIds[i],
                    UserMealId = userMealId,
                    Gram = mealItemList[i].Gram
                });

            }

        }

        public void RemoveRangeMealItems(IEnumerable<MealItem> mealItems, int userMealId)
        {

            var foodIds = _foodService.GetFoodIdsByFoodName(mealItems.Select(mi => mi.FoodName)).ToList();
            var mealItemList = mealItems.ToList();


            for (int i = 0; i < mealItemList.Count; i++)
            {
                _foodAmountRepository.Delete(new FoodAmount()
                {
                    FoodId = foodIds[i],
                    UserMealId = userMealId,
                    Gram = mealItemList[i].Gram
                });

            }

        }
    }
}
