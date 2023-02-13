using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
