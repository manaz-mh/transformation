using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Developer : EmployeeBase
    {
        public void Code()
        {
            Console.WriteLine($"{Name} is coding.");
        }
    }
}
