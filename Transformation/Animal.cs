using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}
