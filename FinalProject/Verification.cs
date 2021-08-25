using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Verification
    {
        public bool verification(string login, string pass)
        {
            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pass))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
