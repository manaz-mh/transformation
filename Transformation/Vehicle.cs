using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }
    }
}
