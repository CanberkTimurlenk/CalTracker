using Entities.Concrete;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFoodService
    {
         IEnumerable<string> GetFoodNamesContains(string word);
         Food GetFoodsNameBy(string word);
        public void AddNewFood(Food food);
        IEnumerable<string> GetFoodNamesContains(string word);
        //Food GetFoodsNameBy(string word);

        FoodNutrionals GetFoodNutrionals(string name, int gram);

        public IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names);
    }
}
