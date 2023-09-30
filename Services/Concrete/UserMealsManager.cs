using Entities.Concrete;
using Entities.Enums;
using Repository.Concrete.EFCore;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class UserMealsManager : IUserMealsService
    {
        UserMealsRepository userMealsRepository = new UserMealsRepository();

        //Food GetFood(MealTimes mealTime)
        //{
        //    userMealsRepository.
        //}
    }
}
