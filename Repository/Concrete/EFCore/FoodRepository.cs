using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;
using Repository.Context;

namespace Repository.Concrete.EFCore
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        
    }
}
