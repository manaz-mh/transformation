using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class MultiFunctionPrinter : IPrinter, IScan
    {
        public void Print()
        {
            Console.WriteLine("Printing.....");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning.....");
        }
    }
}
