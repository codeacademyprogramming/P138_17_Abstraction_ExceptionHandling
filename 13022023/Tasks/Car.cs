using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Car:IVehicle
    {
        public double Mileage { get; set; }
        public double CurrentFuel;
        public double FuelFor1Km;

        public void Drive(double km)
        {
            var neededFuel = km * FuelFor1Km;

            if(CurrentFuel>= neededFuel)
            {
                CurrentFuel -= neededFuel;
                Mileage += km;
            }
        }
    }
}
