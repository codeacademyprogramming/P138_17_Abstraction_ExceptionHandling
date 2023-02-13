using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Dog dog = new Dog();

            Sheep sheep = new Sheep();


            cat.MakeSound();
            dog.MakeSound();
            sheep.MakeSound();

        }
    }
}
