using System;

class Program
{
    static void Main(string[] args)
    {   //Day 1 - Set ups

        Console.WriteLine("Manaz");

        // Day 2 - Variables and Methods
        Task1();
        Task2();
        Task3Sum();
        Task4SalaryGRowthCalculator();
        yearlySalary();
        SalaryCalculator();
    }

    static void SalaryCalculator()
    {
        Console.WriteLine("Previous Monthly Salary : ");
        double previousMonthlySalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Hike Amount:");
        double hikeAmount = Convert.ToDouble(Console.ReadLine());

        double newMonthlySalary = previousMonthlySalary + hikeAmount;
        double newYearlySalary = newMonthlySalary * 12;

        Console.WriteLine($"New monthly Salary : {newMonthlySalary} \nNew yearly Salary : {newYearlySalary}");
        Console.WriteLine($"Hike Amount: {hikeAmount}");

    }

    static void yearlySalary()
    {
        Console.WriteLine("Enter Monthly Salary:");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your yearly Salary: {salary*12}");

    }

    static void Task4SalaryGRowthCalculator()
    {
        Console.WriteLine("Enter Current Salary:");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Expected hike % :");
        int percent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"New Salary : {salary + (salary*percent/100)}");

    }

   static void Task1()
    {
        Console.WriteLine("Name : Manaz");
        Console.WriteLine("CS : 80000");
        Console.WriteLine("TS : 700000");
    }

    static void Task2()
    {
        Console.WriteLine("Please Enter Name :");
        string Name = Console.ReadLine();

        Console.WriteLine("Please Enter Age :");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter City :");
        string city = Console.ReadLine();

        Console.WriteLine($"hi {Name} \nYou are {age} years old \nYou live in {city}");
    }

    static void Task3Sum()
    {
        Console.WriteLine("Enter First Number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum of both numbers : {a + b}");
    }
}