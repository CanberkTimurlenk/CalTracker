﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Aim : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
