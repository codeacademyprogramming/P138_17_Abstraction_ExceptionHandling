using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Ak47 :Gun, IGun, IFireable
    {
        public Ak47(string country):base(country)
        {

        }
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine { get; set; }

        public void Fire()
        {
            if (CurrentMagazine > 1)
                CurrentMagazine -= 2;
        }

        public void ReloadMagazine()
        {
            CurrentMagazine = MagazineCapacity;
        }
    }
}
