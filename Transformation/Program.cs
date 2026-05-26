using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {   // Day 1 - Set ups

        //Console.WriteLine("Manaz");

        // Day 2 - Variables and Methods
        //Task1();
        //Task2();
        //Task3Sum();
        //Task4SalaryGRowthCalculator();
        //yearlySalary();
        //SalaryCalculator();

        //Day 3 - Loops and Conditions
        CheckEvenOrOdd();
        VotingEligiblity();
        Multiplication();
        NumberSum();
        ATMMenu();
        Marks();
    }

    static void Marks()
    {
        Console.WriteLine("Enter your Mark:");
        double mark = Convert.ToDouble(Console.ReadLine());
        if (mark >= 0 && mark <= 100)
        {
            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Grade : A");
            else if (mark >= 70)
                Console.WriteLine("Grade : B");
            else if (mark >= 50)
                Console.WriteLine("Grade : C");
            else 
                Console.WriteLine("Fail");
        }
        else
            Console.WriteLine("Invalid Entry");
    }

    static void ATMMenu()
    {
        double balanceAmount = 20000000;
        bool isRunning = true;
        int number = 0;
        while (isRunning)
        {
            Console.WriteLine("1.Check Balance \n2.Deposit \n3.Withdraw \n4.Exit");
            Console.WriteLine("Please Choose above Banking options:");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"Balance : {balanceAmount}");
                    break;
                case 2:
                    Console.WriteLine("Please Enter the aoumnt you want to deposit");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    balanceAmount += depositAmount;
                    Console.WriteLine($"{depositAmount} is successfully deposited. \nBalance : ${balanceAmount}");
                    break;
                case 3:
                    Console.WriteLine("Please Enter the amount you want to withdraw");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (balanceAmount < withdrawAmount)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        balanceAmount -= withdrawAmount;
                        Console.WriteLine($"You have succeessfully withdrawn ${withdrawAmount}. \nBalance :{balanceAmount}");
                    }
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
    static void NumberSum()
    {
        int result = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}");
            if (i < 10)
                Console.Write("+");
            else
                Console.WriteLine("");
            result = result + i;
        }

        Console.WriteLine($"Final Sum: {result}");
    }

    static void Multiplication()
    {
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        for (int i = 1; i <= 10; i++)
        {
            result = i * number;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }

    static void VotingEligiblity()
    {
        Console.WriteLine("Enter your age :");

        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("You are eligible for voting");
        else
            Console.WriteLine("You are not eligible for voting");
    }

    static void CheckEvenOrOdd()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine($" {num} is Even number");
        else
            Console.WriteLine($"{num} is Odd number");
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

        Console.WriteLine($"Your yearly Salary: {salary * 12}");

    }

    static void Task4SalaryGRowthCalculator()
    {
        Console.WriteLine("Enter Current Salary:");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Expected hike % :");
        int percent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"New Salary : {salary + (salary * percent / 100)}");

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