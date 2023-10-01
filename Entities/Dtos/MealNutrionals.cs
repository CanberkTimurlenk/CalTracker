using Entities.Enums;
using Services.Concrete;

namespace Entities.Dtos
{
    public class MealNutrionals : Nutrionals
    {
        public MealTimes MealTime { get; set; }
    }
}
