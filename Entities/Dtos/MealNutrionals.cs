using Entities.Enums;
using Services.Concrete;

namespace Entities.Dtos
{
    public record MealNutrionals
    {
        public MealTimes MealTime { get; init; }
        public Nutrionals Nutrionals { get; init; }
    }
}
