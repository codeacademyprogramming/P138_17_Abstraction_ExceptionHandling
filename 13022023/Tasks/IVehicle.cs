using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal interface IVehicle
    {
        double Mileage { get; set; }
        void Drive(double km);
    }
}
