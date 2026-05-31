using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Car
    {
        public string CarName { get; set; }

        public string Model { get; set; }

        public string Speed { get; set; }

        public void DisplayCarInfo()
        {
             Console.WriteLine($"Car Name : {CarName} | Model : {Model} | Top Speed : {Speed}\n");
        }
    }
}
