using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;
using Repository.Context;

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
    }
}
