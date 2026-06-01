using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation 
{
    internal class CarV2 : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Driving a {Brand}");
        }
    }
}
