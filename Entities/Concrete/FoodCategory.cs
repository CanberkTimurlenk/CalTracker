using Entities.Abstract;

namespace Entities.Concrete
{
    public class FoodCategory : BaseEntity, IEntity
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        public List<Food> Foods { get; set; }
    }
}
