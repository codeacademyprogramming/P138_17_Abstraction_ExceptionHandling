using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Makarov :Gun, IFireable,IGun
    {
        public Makarov(string country):base(country)
        {

        }
        private int _currentMagazine;
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine {
            get => _currentMagazine;
            set
            {
                if(value>=0 && value<=MagazineCapacity)
                {
                    _currentMagazine = value;
                }
            }
        }

        public void Fire()
        {
            if(CurrentMagazine>0)
                CurrentMagazine--;
        }

        public void ReloadMagazine()
        {
            CurrentMagazine = MagazineCapacity;
        }
    }
}
