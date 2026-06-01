using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Bike : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine($"Ridding a {Brand}");
        }
    }
}
