using System;
using System.Collections.Generic;
using System.Text;

namespace Transformation
{
    internal class Person
    {
        public string Name { get; set; }

        private int Age { get; set; }

        public void SetAge(int age)
        {
            if (age >= 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

    }
}
