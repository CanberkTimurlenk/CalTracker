using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Repository.Abstract;
using Repository.Abstract.Base;
using Repository.Context;
using Services.Concrete;

namespace Repository.Concrete.EFCore
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public IEnumerable<string> GetFoodNamesContains(string word)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Foods
                            .Where(f => f.Name.Contains(word))
                            .Select(f => f.Name).ToList();
        }

        public FoodNutrionals GetFoodNutritionals(string word)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Foods
                            .Where(f => f.Name.Equals(word))
                            .Select(f => new FoodNutrionals
                            {
                                FoodName = f.Name,
                                Gram = f.Gram,
                                Calorie = f.Calorie,
                                Protein = f.Protein,
                                Fat = f.Fat
                            }).FirstOrDefault()!;
        }


        public IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names)
        {
            using var KaloriTakipDbContext = new KaloriTakipDbContext();

            return KaloriTakipDbContext.Foods
            .Where(food => names.Contains(food.Name))
            .Select(food => food.Id).ToList();
          
        }
    }
}
