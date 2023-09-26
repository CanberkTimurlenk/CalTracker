using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserVerification
    {
        public int UserId { get; set; }
        public string Verification { get; set; }
        public User User { get; set; }
    }
}
