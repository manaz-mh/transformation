using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class CircleV2 : ShapeBase
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
