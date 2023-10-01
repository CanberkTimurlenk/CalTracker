using Entities.Concrete;
using Repository.Abstract.Base;
using Services.Concrete;

namespace Repository.Abstract
{
    public interface IFoodRepository : IBaseRepository<Food>
    {
        IEnumerable<string> GetFoodNamesContains(string word);
        FoodNutrionals GetFoodNutritionals(string word);
        IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names);
    }
}
