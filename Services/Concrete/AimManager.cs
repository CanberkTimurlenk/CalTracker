using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class AimManager : IAimService
    {
        private readonly AimRepository _aimRepository = new AimRepository();

        public IEnumerable<Aim> GetAll()
        {
            return _aimRepository.GetAll();
        }
    }
}
