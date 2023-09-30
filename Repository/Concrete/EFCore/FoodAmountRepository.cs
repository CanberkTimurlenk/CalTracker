using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;

namespace Repository.Concrete.EFCore
{
    public class FoodAmountRepository : BaseRepository<FoodAmount>, IFoodAmountRepository
    {
    }
}
