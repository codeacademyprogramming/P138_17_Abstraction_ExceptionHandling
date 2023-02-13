using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Bicycle:IVehicle
    {
        public double Mileage { get; set; }
        public void Drive(double km)
        {
            Mileage += km;
        }
    }
}
