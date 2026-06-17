using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class CreditCardPayment: IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }
}
