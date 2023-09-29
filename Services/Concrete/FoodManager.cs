using Entities.Concrete;
using Repository.Abstract;
using Repository.Concrete.EFCore;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class FoodManager :IFoodService
    {
        IFoodRepository _foodRepository = new FoodRepository();
        public IEnumerable<string> GetFoodNamesContains(string word) 
        {           
           return  _foodRepository.GetFoodNamesContains(word);
        }

        public Food GetFoodsNameBy(string word)
        {
            return _foodRepository.Get(f=>f.Name.Equals(word));
        }
    }
}
