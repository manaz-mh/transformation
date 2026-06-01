using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class EmployeeSalary
    {
        private double _salary;

        public void SetSalary(double amount)
        {
            if (amount > 0)
            {
                _salary = amount;
            }
            else {
                Console.WriteLine("Invalid Entry");
            }
        }

        public void GetSalary()
        {
            Console.WriteLine($"Employee Salary : {_salary}");
        }

        public void ApplyHike(double hike)
        {
            if (hike > 0) {
                _salary += (_salary * hike / 100);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
