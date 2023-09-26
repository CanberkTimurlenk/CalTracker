using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserVerification : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public string Verification { get; set; }
        public User User { get; set; }
    }
}
