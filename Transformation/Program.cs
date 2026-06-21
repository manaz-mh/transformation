using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Transactions;
using Transformation;

class Program
{
    static void Main(string[] args)
    {
        // Day 1 - Set ups
        //Console.WriteLine("Manaz");

        // Day 2 - Variables and Methods
        //Task1();
        //Task2();
        //Task3Sum();
        //Task4SalaryGRowthCalculator();
        //yearlySalary();
        //SalaryCalculator();

        //Day 3 - Loops, Conditions and Validations
        //CheckEvenOrOdd();
        //VotingEligiblity();
        //Multiplication();
        //NumberSum();
        //ATMMenu();
        //Marks();

        //Day 4 - Arrays and List
        //StudentNames();
        //SumOfArray();
        //LargestNumber();
        //EvenNumbers();
        //DynmicStudentLists();
        //HighestLowestAverage();

        //Day 5 - OOPs Concepts
        //EmployeeDetails();
        //StudentDetails();
        //BankOperations();
        //CarDetails();
        //Calculations();
        //ShoppingCart();

        //Day 6 – Encapsulation, Access Modifiers & Static
        //PersonDetails();
        //Banking();
        //SquareDemo();
        //CounterDemo();
        //EmployeeSalaryDetails();

        //Day 7 – Inheritance & Polymorphism
        //AnimalDemo();
        //EmployeeDemo();
        //ShapeDemo();
        //CalculatorDemo();
        //VehicleDemo();

        //Day 8 - Abstract Class & Interfaces
        //ShapeAreaDemo();
        //EmployeeWorkDemo();
        //PrinterDemo();
        //MultiFunctionDemo();
        //Payment();

        //Day 9 - Exception Handling & File Operations
        //DivideNumbers();
        //DivideNumbersV2();
        //FinallyDemo();
        //WriteFile();
        //ReadFile();
        //StudentFileManager();

        //Day 10 – Generics & Collections.
        //GenericMethodDemo();
        //GenericClassDemo();
        //DictionaryDemo();
        //QueueDemo();
        //StackDemo();
        EmployeeDirectory();
    }

    //Day 10 – Generics & Collections.

    static void EmployeeDirectory()
    {
        Dictionary<int, string> employeeDictionary = new();
        bool isRunning = true;
        try
        {
            while (isRunning)
            {
                Console.WriteLine("\n**********Employee Directory*************\n");
                Console.WriteLine("1.Add Employee\n2.Search Employee\n3.View Employee\n4.Exit\nPlease enter the Option number:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter Employee ID:");
                        int employeeID = Convert.ToInt32(Console.ReadLine());

                        if (!employeeDictionary.ContainsKey(employeeID))

                        {
                            Console.WriteLine("Please Enter Employee Name:");
                            string employeeName = Console.ReadLine();

                            employeeDictionary.Add(employeeID, employeeName);
                        }
                        else
                            Console.WriteLine("Entered EmployeeID already Exists.");
                        break;
                    case 2:
                        Console.WriteLine("Enter EmployeeID:");
                        int employeeID2 = Convert.ToInt32(Console.ReadLine());
                        if (employeeDictionary.ContainsKey(employeeID2))
                        {
                            Console.WriteLine($"Employee ID {employeeID2} exists.\nEmployeeN Name :{employeeDictionary[employeeID2]}");
                        }
                        else
                        {
                            Console.WriteLine($"Employee ID {employeeID2} does not exists.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Employee Details:");
                        if(employeeDictionary.Count > 0)
                        foreach(var employee in employeeDictionary)
                        {
                            Console.WriteLine($"{employee.Key} - {employee.Value}");
                        }
                        else
                            Console.WriteLine("No Employee Records Found.");
                        break;
                    case 4:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void StackDemo()
    {
        Stack<string> stack =
            new Stack<string>();

        stack.Push("Tony");
        stack.Push("Steve");
        stack.Push("Bruce");

        Console.WriteLine(stack.Pop());

        Console.WriteLine(stack.Peek());
    }

    static void QueueDemo()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Tony");
        queue.Enqueue("Steve");
        queue.Enqueue("Bruce");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Peek());
    }

    static void DictionaryDemo()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Tony");
        students.Add(102, "Steve");
        students.Add(103, "Bruce");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }
    }
    static void GenericClassDemo()
    {
        Box<int> box1 = new Box<int>();
        box1.Value = 100;
        Console.WriteLine(box1.Value);

        Box<string> box2 = new Box<string>();
        box2.Value = "Tony";
        Console.WriteLine(box2.Value);
    }

    static void GenericMethodDemo()
    {
        Utility.Display<int>(100);
        Utility.Display<string>("Hello");
        Utility.Display<double>(99.99);
    }

    //Day 9 - Exception Handling & File Operations

    static void StudentFileManager()
    {
        try
        {
            bool isRunning = true;
            string filePath = "StudentFileManager.txt";
            while (isRunning)
            {
                Console.WriteLine("Student File Manager\n1.Add Student\n2.View Student\n3.Exit\nPlease Enter the option number");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter Student Name:");
                        string studentName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(studentName))
                        {
                            if (!File.Exists(filePath))
                                File.WriteAllText(filePath, studentName);
                            else
                                File.AppendAllText(filePath, "\n" + studentName);

                            Console.WriteLine($"{studentName} added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid name");
                        }
                        break;
                    case 2:

                        if (File.Exists(filePath))
                        {
                            Console.WriteLine("Name of Students:");
                            string content = File.ReadAllText(filePath);
                            Console.WriteLine(content);
                        }
                        else
                            Console.WriteLine("No student records found.");
                        break;
                    case 3:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void ReadFile()
    {
        string path = "salary.txt";
        string content = File.ReadAllText(path);

        Console.WriteLine($"{content}");

    }

    static void WriteFile()
    {
        string path = "salary.txt";
        File.WriteAllText("salary.txt", "Monthly salary : 50000");
        Console.WriteLine("File created");
    }

    static void FinallyDemo()
    {
        try
        {
            Console.WriteLine("Processing...");
        }
        catch
        {
            Console.WriteLine("Error");
        }
        finally
        {
            Console.WriteLine("Program Finished");
        }
    }
    static void DivideNumbersV2()
    {
        try
        {
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result : {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please input valid numbers.");
        }
    }

    static void DivideNumbers()
    {
        try
        {
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine($"Resule: {result}");
        }
        catch
        {
            Console.WriteLine("Something went wrong.");
        }
    }

    //Day 8 - Abstract Class & Interfaces
    static void Payment()
    {
        IPayment payment1 = new CreditCardPayment();
        IPayment payment2 = new UPIPayment();

        payment1.Pay(500);
        payment2.Pay(500);
    }

    static void MultiFunctionDemo()
    {
        MultiFunctionPrinter device = new MultiFunctionPrinter();

        device.Scan();
        device.Print();
    }

    static void PrinterDemo()
    {
        Printer printer = new Printer();

        printer.Print();
    }

    static void EmployeeWorkDemo()
    {
        DeveloperV2 developer = new DeveloperV2();

        developer.Name = "Ted";

        developer.Work();
    }

    static void ShapeAreaDemo()
    {
        CircleV2 circle = new CircleV2();

        circle.Radius = 5;
        double area = circle.CalculateArea();

        Console.WriteLine($"Area : {area}");
    }

    //Day 7 – Inheritance & Polymorphism

    static void VehicleDemo()
    {
        CarV2 vehicle1 = new CarV2();
        Bike vehicle2 = new Bike();

        vehicle1.Brand = "BMW";
        vehicle2.Brand = "Yamaha";

        vehicle1.Start();
        vehicle1.Drive();

        vehicle2.Start();
        vehicle2.Ride();
    }
    static void CalculatorDemo()
    {
        CalculatorV2 cal = new CalculatorV2();

        int sum1 = cal.Sum(10, 20);
        int sum2 = cal.Sum(10, 20, 30);
        Console.WriteLine($"Sum1 : {sum1}\nSum2 : {sum2}");
    }

    static void ShapeDemo()
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();

        shape1.Draw();
        shape2.Draw();
    }

    static void EmployeeDemo()
    {
        Developer developer = new Developer();

        developer.Name = "Steve";
        developer.Work();
        developer.Code();

        Manager manager = new Manager();

        manager.Name = "Tim";
        manager.Work();
        manager.Manage();
    }

    static void AnimalDemo()
    {
        Dog dog = new Dog();

        dog.Name = "Coco";
        dog.Eat();
        dog.Bark();
    }


    //Day 6 – Encapsulation, Access Modifiers & Static

    static void EmployeeSalaryDetails()
    {
        EmployeeSalary salary = new EmployeeSalary();

        salary.SetSalary(50000);
        salary.ApplyHike(10);
        salary.GetSalary();
    }
    static void CounterDemo()
    {
        VisitorCounter v1 = new VisitorCounter();
        VisitorCounter v2 = new VisitorCounter();
        VisitorCounter v3 = new VisitorCounter();

        Console.WriteLine($"Count : {VisitorCounter.Count}");
    }

    static void SquareDemo()
    {
        int result = MathHelper.Square(5);
        Console.WriteLine($"Result : {result}");
    }

    static void Banking()
    {
        BankAccountV2 banking = new BankAccountV2();

        banking.SetBalance(100000);

        banking.Deposit(5000);
        banking.ShowBalance();
        banking.Withdraw(999);
        banking.ShowBalance();
    }

    static void PersonDetails()
    {
        Person person = new Person();

        person.Name = "Stark";
        //person.Age = 30;

        person.SetAge(30);

        person.DisplayPerson();
    }

    //Day 5 - OOPs Concepts

    static void ShoppingCart()
    {
        List<ShoppingCartProduct> objList = new List<ShoppingCartProduct>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Please Enter the Request:\n1.Add Product\n2.TotalPrice\n3.Exit");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    ShoppingCartProduct obj = new ShoppingCartProduct();
                    Console.WriteLine("Enter the Product Name:");
                    obj.Name = Console.ReadLine();

                    Console.WriteLine("Enter Product Price:");
                    obj.Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter number of Quantity:");
                    obj.Quantity = Convert.ToInt32(Console.ReadLine());

                    objList.Add(obj);
                    Console.WriteLine("Item added successfully");
                    break;

                case 2:
                    ShoppingCartProduct.TotalPrice(objList);
                    break;

                case 3:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
    static void Calculations()
    {
        Calculator objCalc = new Calculator();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Please Enter the operation: \n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");
            int number = Convert.ToInt32(Console.ReadLine());


            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter Number 1:");
                    objCalc.Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    objCalc.Number2 = Convert.ToInt32(Console.ReadLine());
                    objCalc.Add();
                    break;

                case 2:

                    Console.WriteLine("Enter Number 1:");
                    objCalc.Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    objCalc.Number2 = Convert.ToInt32(Console.ReadLine());
                    objCalc.Subtract();
                    break;
                case 3:

                    Console.WriteLine("Enter Number 1:");
                    objCalc.Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    objCalc.Number2 = Convert.ToInt32(Console.ReadLine());
                    objCalc.Multiply();
                    break;
                case 4:

                    Console.WriteLine("Enter Number 1:");
                    objCalc.Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    objCalc.Number2 = Convert.ToInt32(Console.ReadLine());
                    objCalc.Divide();
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;

            }
        }


    }
    static void CarDetails()
    {
        List<Car> carList = new List<Car>
        {
            new Car{CarName="BMW",Model="M4",Speed="400"},
            new Car{CarName="Audi",Model="RS5",Speed="350"},
            new Car{CarName="Mercedes",Model="AMG GT",Speed="380"}
        };

        foreach (Car car in carList)
            car.DisplayCarInfo();
    }

    static void BankOperations()
    {

        bool isRunning = true;

        BankAccount obj = new BankAccount();

        obj.AccountHolder = "Steve";
        obj.Balance = 1000000;

        while (isRunning)
        {
            Console.WriteLine("Please Enter The Option: \n1.Deposite\n2.Withdraw\n3.Transfer\n4.Exit");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Please Enter the Deposit Amount:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    obj.Deposit(depositAmount);
                    break;
                case 2:
                    Console.WriteLine("Please Enter the Withdraw Amount:");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    obj.Withdraw(withdrawAmount);
                    break;
                case 3:
                    BankAccount recipient = new BankAccount();
                    Console.WriteLine("Please Enter Recipient Name:");
                    recipient.AccountHolder = Console.ReadLine();

                    Console.WriteLine("Please Enter Recipient Account Number:");
                    recipient.AccountNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Enter the Amount to transfer:");
                    double Amount = Convert.ToDouble(Console.ReadLine());
                    recipient.Balance = 100;

                    obj.Transfer(recipient, Amount);
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


    static void StudentDetails()
    {
        Student obj = new Student("Ronaldo", 7);

        Console.WriteLine($"Student Name :{obj.Name}\nStudent Age:{obj.Age}");
    }

    static void EmployeeDetails()
    {
        Employee obj = new Employee();

        obj.Id = 1507;
        obj.Name = "Stark";
        obj.Salary = 2000000;
        Console.WriteLine($"Employee ID :{obj.Id}\nEmployee Name:{obj.Name}\nEmployee Salary :{obj.Salary}");
    }

    //Day 4 - Arrays and List
    static void HighestLowestAverage()
    {
        int[] array = new int[5];
        Console.WriteLine("Enter 5 numbers");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0, avg = 0, highestNumber = array[0], lowestNumber = array[0];

        foreach (int i in array)
        {
            sum = sum + i;

            if (highestNumber < i)
                highestNumber = i;

            if (lowestNumber > i)
                lowestNumber = i;

        }

        avg = sum / array.Length;

        Console.WriteLine($"Highest : {highestNumber} \nLowest : {lowestNumber} \nAverage : {avg}");
    }


    static void DynmicStudentLists()
    {
        List<string> studentList = new List<string>();
        bool isRunning = true;
        int menu = 0;
        while (isRunning)
        {
            Console.WriteLine("1.Add Student \n2.View Students\n3.Search Students\n4.Remove Student \n5.Exit");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter student name");
                    studentList.Add(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Student Names:");
                    foreach (var item in studentList)
                        Console.WriteLine(item);
                    break;
                case 3:
                    Console.WriteLine("Enter the name to find the student :");
                    string name = Console.ReadLine();
                    bool isfound = false;

                    foreach (string item in studentList)
                        if (item == name)
                        {
                            Console.WriteLine("Student found");
                            isfound = true;
                            break;
                        }
                    if (!isfound)
                        Console.WriteLine("Student not found");
                    break;


                case 4:
                    Console.WriteLine("Enter Student Name to remove :");
                    string studentname = Console.ReadLine();

                    bool status = studentList.Remove(studentname);

                    if (status)
                    {
                        Console.WriteLine($"{studentname} is removed successfully. \nStudent List:");
                        foreach (var item in studentList)
                            Console.WriteLine($"{item}");
                    }
                    else
                    {
                        Console.WriteLine($"{studentname} is not found");
                    }
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("invalid Entry");
                    break;

            }

        }
    }

    static void EvenNumbers()
    {
        int[] array = { 1, 2, 3, 6, 5, 11, 24, 38, 77 };

        foreach (int i in array)
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }


    }

    static void LargestNumber()
    {
        int[] array = { 10, 50, 20, 90, 40 };

        int largest = array[0];

        foreach (int i in array)
            if (largest < i)
                largest = i;

        Console.WriteLine($"Largest Number : {largest}");
    }

    static void SumOfArray()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int sum = 0;

        foreach (int i in array)
            sum = sum + i;

        Console.WriteLine($"Sum : {sum}");
    }

    static void StudentNames()
    {
        string[] students = { "John", "Wick", "Tony", "Stark", "Bruce" };

        Console.WriteLine("Using FOR Loop :");
        for (int i = 0; i <= students.Length - 1; i++)
        {
            Console.WriteLine(students[i]);
        }

        Console.WriteLine("Using FOREACH Loop :");
        foreach (var item in students)
            Console.WriteLine(item);
    }

    // Day 3 - Loops, Conditions and Validations
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

    // Day 2 - Variables and Methods
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