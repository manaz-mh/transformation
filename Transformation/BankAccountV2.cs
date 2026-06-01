using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class BankAccountV2
    {
        private double _balance;

        public void SetBalance(double balance)
        {
            if (balance > 0)
            {
                _balance = balance;
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Amount successefully Credited.");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= _balance)
                {
                    _balance -= amount;
                    Console.WriteLine($"Amount Successfully Debited.");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("invalid Entry");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance Amount : {_balance}");
        }
    }
}
