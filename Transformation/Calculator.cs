using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Calculator
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }
        public void Add()
        {
            int sum = Number1 + Number2;
            Console.WriteLine($"Sum : {sum}");
        }

        public void Subtract()
        {
            int difference = Number1 - Number2;
            Console.WriteLine($"Differnce : {difference}");
        }

        public void Multiply()
        {
            int product = Number1 * Number2;
            Console.WriteLine($"Product :{product}");
        }

        public void Divide()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                int quotient = Number1 / Number2;
                Console.WriteLine($"Quotient : {quotient}");
            }
        }
    }
}
