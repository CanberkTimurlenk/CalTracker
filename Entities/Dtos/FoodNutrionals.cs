namespace Services.Concrete
{
    public record FoodNutrionals
    {
        public string FoodName { get; init; }
        public int Gram { get; init; }
        public Nutrionals Nutrionals { get; init; }

    }
}
