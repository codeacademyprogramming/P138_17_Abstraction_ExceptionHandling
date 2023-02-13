using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal interface IGun
    {
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine { get; set; }
        public void ReloadMagazine();
    }
}
