namespace Entities.Dtos
{
    public record MealItem
    {
        public int UserId { get; init; }
        public string FoodName { get; init; }
        public int Gram { get; init; }
    }
}
