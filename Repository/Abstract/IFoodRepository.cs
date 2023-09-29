using Entities.Concrete;
using Repository.Abstract.Base;

namespace Repository.Abstract
{
    public interface IFoodRepository : IBaseRepository<Food>
    {
        public IEnumerable<string> GetFoodNamesContains(string word);
    }
}
