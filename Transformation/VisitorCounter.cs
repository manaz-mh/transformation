using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class VisitorCounter
    {
        public static int Count = 0;

        public VisitorCounter()
        {
            Count++;
        }
    }
}
