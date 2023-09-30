using Repository.Abstract;
using Repository.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodRepository _foodRepository = new FoodRepository();
        public IEnumerable<string> GetFoodNamesContains(string word)

            => _foodRepository.GetFoodNamesContains(word);


        public FoodNutrionals GetFoodNutrionals(string name, int gram)
        {
            var fn = _foodRepository.GetFoodNutritionals(name);

            var calculatedFoodNutrionals = new FoodNutrionals()
            {
                FoodName = fn.FoodName,
                Gram = gram,
                Calorie = Math.Round((fn.Calorie / fn.Gram) * gram, 2),
                Carbonhidrate = Math.Round((fn.Carbonhidrate / fn.Gram) * gram, 2),
                Protein = Math.Round((fn.Protein / fn.Gram) * gram, 2),
                Fat = Math.Round((fn.Fat / fn.Gram) * gram, 2)
            };

            return calculatedFoodNutrionals;

        }

        public IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names)

            => _foodRepository.GetFoodIdsByFoodName(names);

    }
}
