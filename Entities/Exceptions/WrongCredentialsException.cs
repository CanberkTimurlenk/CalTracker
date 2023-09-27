using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class WrongCredentialsException : Exception
    {
        public WrongCredentialsException(string email) : base($"Credentials was wrong for {email}")
        {

        }
    }
}
