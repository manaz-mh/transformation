using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Manager : EmployeeBase
    {
        public void Manage()
        {
            Console.WriteLine($"{Name} is managing");
        }
    }
}
