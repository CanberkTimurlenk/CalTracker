using Entities.Abstract;

namespace Entities.Concrete
{
    public class UserData : BaseEntity, IEntity
    {
        public double BodyMassIndex { get; set; }
        public BmiStatus BmiStatus { get; set; }
        public double DailyCalorie { get; set; }
        public double DailyFat { get; set; }
        public double DailyCarbonhidrate { get; set; }
        public double DailyProtein { get; set; }
        public double RequiredCalorie { get; set; }
        public double WaterAmount { get; set; }
        public DateTime Date { get; set; }

        public List<UserMeals> UserMeals { get; set; }


    }


}