using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
    }
}
