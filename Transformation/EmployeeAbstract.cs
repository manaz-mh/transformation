using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal abstract class EmployeeAbstract
    {
        public string Name { get; set; }

        public abstract void Work();
    }
}
