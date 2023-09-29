using Entities.Concrete;
using Repository.Abstract;
using Repository.Concrete.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AimManager : IAimService 
    {
        private readonly IAimRepository _aimRepository = new AimRepository();

        public IEnumerable<Aim> GetAll()
        {
            return _aimRepository.GetAll();
        }
    }
}
