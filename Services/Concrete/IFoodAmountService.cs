using Entities.Dtos;

namespace Services.Concrete
{
    public interface IFoodAmountService
    {
        void AddRangeMealItems(IEnumerable<MealItem> mealItems, int userMealId);
        void RemoveRangeMealItems(IEnumerable<MealItem> mealItems, int userMealId);
    }
}