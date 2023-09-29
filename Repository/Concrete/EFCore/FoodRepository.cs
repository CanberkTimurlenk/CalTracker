using Entities.Concrete;
using Repository.Abstract.Base;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
