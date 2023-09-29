using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFoodService
    {
         IEnumerable<string> GetFoodNamesContains(string word);
         Food GetFoodsNameBy(string word);
    }
}
