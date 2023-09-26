namespace Entities.Concrete
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        public List<Food> Foods { get; set; }
    }
}
