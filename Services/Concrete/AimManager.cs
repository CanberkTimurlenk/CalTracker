﻿using Entities.Concrete;
using Repository.Abstract;
using Repository.Concrete.EFCore;
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
        private readonly IAimRepository _aimRepository = new AimRepository();

        public IEnumerable<Aim> GetAll()
        {
            return _aimRepository.GetAll();
        }
    }
}