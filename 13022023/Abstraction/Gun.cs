using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal abstract class Gun
    {
        public Gun(string country)
        {
            Country = country;
        }
        public int Year;
        public string Country;
    }
}
