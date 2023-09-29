using Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class UserMeals : BaseEntity, IEntity
    {
        public DateTime MealDate { get; set; } = DateTime.Now;
        public MealTimes MealTimes { get; set; }

        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public double Portion { get; set; }


        public User User { get; set; }
        public int UserId { get; set; }

        public List<Food> Foods { get; set; }
    }
}
