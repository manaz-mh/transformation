using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class BankAccount
    {
        public string AccountHolder { get; set; }

        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public  void Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalide Deposit Amount");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Balance : {Balance}");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalide Amount Entered");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Balance : {Balance}");
            }
        }

        public void Transfer(BankAccount obj, double amount)
        {
            if (amount <= 0)
                Console.WriteLine("Invalid Entry");
            else if (Balance <= amount)
                Console.WriteLine("Insufficient Balance");
            else
            {
                Balance -= amount;
                obj.Balance += amount;
                Console.WriteLine($"Balance : {Balance} \n Amount {amount} successfully transferred");
            }

        }
    }
}
