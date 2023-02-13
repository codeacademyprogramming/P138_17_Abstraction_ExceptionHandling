using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal abstract class Vehicle
    {
        public double Mileage { get; set; }
        public abstract void Drive(double km);
    }
}
