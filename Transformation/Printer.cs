using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }
}
