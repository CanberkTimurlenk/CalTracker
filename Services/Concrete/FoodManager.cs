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
        public void AddNewFood(Food food)
        //public void AddNewFood(string name, double calorie, double fat, double protein, double carbonhidrate,int categoryId, string? imagePath, int gram)
        {
            //Food food = new Food() 
            //{
            //    Name = name,
            //    Calorie = calorie,
            //    Fat = fat,
            //    Protein = protein,
            //    Carbonhidrate = carbonhidrate,
            //    FoodCategoryId = categoryId,
            //    ImagePath = imagePath,
            //    Gram = gram
            //};
            _foodRepository.Create(food);
        }
    }
}
