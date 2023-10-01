using Entities.Enums;
using Services.Concrete;

namespace Entities.Dtos
{
    public class MealNutrionals
    {
        public MealTimes MealTime { get; set; }
        public Nutrionals Nutrionals { get; set; }
    }
}
