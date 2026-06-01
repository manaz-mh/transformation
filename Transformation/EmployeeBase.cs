using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class EmployeeBase
    {
        public string Name { get; set; }

        public void Work() { 
         Console.WriteLine($"{Name} is working.");         
       }
    }
}
