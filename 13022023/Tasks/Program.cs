using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.Drive(10);
            bicycle.Drive(4);
            bicycle.Drive(3);

            Console.WriteLine(bicycle.Mileage);


            Car car = new Car();
            car.FuelFor1Km = 0.5;
            car.CurrentFuel = 25;

            car.Drive(10);
            car.Drive(20);
            car.Drive(100);

            Console.WriteLine(car.Mileage);



        }
    }
}
