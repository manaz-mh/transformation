using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Transformation
{
    internal class DeveloperV2 : EmployeeAbstract
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} is coding");
        }
    }
}
