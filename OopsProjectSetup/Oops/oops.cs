using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OopsProjectSetup.Oops
{
    internal class oops
    {
        //1.Create a class AdminUSer with properties AdminId, Name, and isActive
        //The default constructor should set IsActive = true.
        //Create an object and print the IsActive value
    }
    public class AdminUser
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }

        public AdminUser()
        {
            AdminId = 1;
            Name = "Pooja";
            isActive = true;

        }
    }

    //2.Parameterized Constructor
    //Create a class LoginSeession with AdminId and Login Time.
    //Initilize values using parameterized constructor. and print the login details

    public class LoginSession
    {
        public int AdminId { get; set; }
        public int LoginTime { get; set; }


        public LoginSession(int adminId, int loginTime)
        {
            AdminId = adminId;
            LoginTime = loginTime;
        }

        public LoginSession()
        {
            AdminId = 1;
            LoginTime = 10;
        }
    }

    //3.Constructor Overloading
    //Create a class UserProfile with Name,age and Cityyy
    //create three co structors
    //1.NAme only
    //2.Name and Age
    //3.Name, Age, City
    //Create bjects using all constructors and prints details

    public class UserProfile
    {
        public String Name { get; set; }
        public int age { get; set; }
        public String City { get; set; }

        public UserProfile(String name)
        {
            Name = name;
        }

        public UserProfile(String city, int age)
        {
            City = city;
        }

        public UserProfile(String name, int age, String city)
        {
            Name = name;
            this.age = age;
            City = city;
        }

        //Use ToString() method to print object details
        public override string ToString()
        {
            return $"Name: {Name}, Age: {age}, City: {City}";
        }
    }

    //4.Constructor Chaining using this()
    //Modify UserProfile Constructor so that:
    //-Second Consructor call First Constructor using this()
    //-Third Constructor calls Second Constructor using this()
    //Avoid Duplicate code

    public class UserProfile1
    {
        public String Name { get; set; }
        public int age { get; set; }
        public String City { get; set; }

        public UserProfile1(String name)
        {
            Name = name;
        }

        public UserProfile1(String name, int age) : this(name)
        {
            this.age = age;
        }

        public UserProfile1(string name, int age, string city) : this(name, age)
        {
            City = city;
            Console.WriteLine("Constructor Chaining using this()");
        }

        //Use ToString() method to print object details
        public override string ToString()
        {
            return $"Name :{Name}, Age: {age}, City: {City}";
        }
    }

    //5..Constructor chainng using base
    //Create a base class Admin with constructor accepting Name
    //Create derived class SuperAdming with Construcotr accepting name and permissionLevel.
    //Use base keyword to call parent constructor and print detsils.



    //6.Private Constructor
    //Create a class AdminConfig with a provate Constructor and a static property AppName

    public class AdminConfig
    {
        public string AppName { get; set; }

        private AdminConfig()
        {
            AppName = "Facebook";
        }

        public static AdminConfig CreateObject()
        {
            return new AdminConfig();
        }
    }

    //7.constrocotr vs static construcotr
    //Create a class AppSettings with:
    //static construcotor intitializing Application Name
    //Normal Constructor initilizing Envorinmrnt
    //Print both values and explain execurtion order

    public class AppSettings
    {
        public static String ApplicationName { get; set; }
        public string Enviornment { get; set; }

        static AppSettings()
        {
            ApplicationName = "Facebbok";

        }

        public AppSettings()
        {
            Enviornment = "Nice";
        }

        public override string ToString()
        {
            return $"Application Name :{ApplicationName}  Enviornment:{Enviornment}";
        }
    }
}

//8.Singleone pattern using Construcotor
//Create a singleton class USing private constructor, static instance , and pub;ic static property
//Mention real-time use case (cache, configuration, logger)

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Staic method vs Instance method - exercise

//1.Idebtify static vs instance methods
//Given a calculator with add and multiply methods. Decide whteher these methods should be static or instance methods and explain why.

public class Calculator
{
    //Static method
    public static int perform(int a, int b)
    {
        return a + b;
        return a * b;
    }

    //Instance method
    public int perform1(int a, int b)
    {
        return a + b;
        return a * b;
    }

}

//2.A user class has a Name property. MOdify a stayic greeting method so that it uses the user's name.
//Decide whether the method should be static or instance

public class User
{
    public static String Name { get; set; }

    public static string Greet()
    {
        return $"Hello, {Name}!";
    }

}

//3.An EmailService class has methods for sending email and validating email format. Identify which
//method should be static and which should be instance, with reasoning.

public class Service
{
    public static bool ValidEmail(String email)
    {
        return email.Contains("@");
    }

    public void Sendemail(String email, String subject)
    {
        if (ValidEmail(email))
        {
            Console.WriteLine($"Sending email to {email} with subject {subject}");
        }
        else
        {
            Console.WriteLine("Invalid email address");
        }
    }
}


//4. class contains a static counter incremented in the constructor. Create multiple objects and predict the output.
public class Counter
{
    public static int count = 0;

    public Counter()
    {
        count++;
        Console.WriteLine("Counter value:" + count);
    }
}


//5.tatic method tries to access an instance variable. Identify the error and fix it using two different approaches.




//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------INHERITANCE-------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//1.Practice
public class P : Object
{
    public void M1()
    {
        Console.WriteLine("p");
    }
}

public class C : P
{
    public void M2()
    {
        Console.WriteLine("c");
    }

}


//2.
public class Bird : Object
{
    public Bird()
    {
        Console.WriteLine("Bird Constructor");
    }
}

public class sparrow : Bird
{
    public sparrow()
    {
        Console.WriteLine("Sparrow Constructor");

    }
}

public class sparrowChild : sparrow

{
    public sparrowChild()
    {
        Console.WriteLine("Sparrow Child Constructor");
    }
}

//3.Constructor chaining using base

public class Animal : Object
{
    public Animal()
    {
        Console.WriteLine("Animal Constructor");
    }
}

public class Tiger : Animal
{
    public Tiger(String name)
    {
        Console.WriteLine("Tiger Constructor");
    }
}

public class TigerChild : Tiger
{
    public TigerChild() : base("Hello")
    {
        Console.WriteLine("Tiger Child Constructor");
    }
}

//Example on constructor chainging

public class Birds : Object
{
    public Birds()
    {
        Console.WriteLine("Bird Constructor");
    }
}

public class Sparrows : Birds
{
    public Sparrows(int a)
    {
        Console.WriteLine("Sparrow Constructor");
    }
}

public class SparrowChilds : Sparrows
{
    public SparrowChilds() : base(1)
    {
        Console.WriteLine("Sparrow Child Constructor");
    }
}

//Inheritance Dia Assignment
//1.
public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Person(string name, string address)
    {
        this.Name = name;
        this.Address = address;
    }

    //public void SETaddress(string address)
    //{
    //    this.address = address;
    //}

    public override string ToString()
    {
        return $"Name: {Name}, Address: {Address}";
    }
}

public class Student : Person
{
    public string program { get; set; }
    public int year { get; set; }
    public double fee { get; set; }


    public Student(string name, string address, string program, int year, double fee) : base(name, address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }

    public override string ToString()
    {
        return $"name: {base.Name}, Address: {base.Address}, Program: {program}, Year: {year}, Fee: {fee}";
    }


}

public class Staff : Person
{
    public string school { get; set; }
    public double pay { get; set; }

    public Staff(string name, string address, string school, double pay) : base(name, address)
    {
        this.school = school;
        this.pay = pay;

    }
    public override string ToString()
    {
        return $"school: {school}, Pay: {pay}";
    }
}

//3.
public class point2D
{
    public int x { get; set; }
    public int y { get; set; }

    //Default constructor
    public point2D()
    {
        x = 0;
        y = 0;
    }

    //parametrized constructor
    public point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }


    public void XY(float x, float y)
    {
        x = x; y = y;
    }

    public float[] GETXY()
    {
        return new float[] { x, y };
    }

    public override string ToString()
    {
        return $"X: {x}, Y: {y}";
    }
}

public class point3D : point2D
{
    public int z { get; set; }

    //Default constructor
    public point3D() : base()
    {
        z = 0;
    }

    //Parametrized constructor
    public point3D(int x, int y, int z) : base(x, y)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //Array of XYZ
    public void XYZ(float x, float y, float z)
    {
        x = x; y = y; z = z;
    }

    //
    public float[] GETXYZ()
    {
        return new float[] { x, y, z };
    }

    public override string ToString()
    {
        return $"X: {base.x}, Y: {base.y}, Z: {z}";
    }
}

//--------------------------------------------------------------------------------------------------
//09-02-2026
//--------------------------------------------------------------------------------------------------
//1.Assignment 1:DRIVE EXAMPLE  (Weakly bond = = aggregation = loosly couple)

public class Author
{
    public string Name { get; set; }
    public string Email { get; set; }
    public char Gender { get; set; }

    public Author(string name, string email, char gender)
    {
        Name = name;
        Email = email;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"{Name} {(Gender)} {Email}";
    }
}

public class Book
{
    public string Name { get; set; }
    public Author Auther { get; set; }
    public double Price { get; set; }
    public int Qty { get; set; }

    public Book(string name, Author auther, double price, int qty)
    {
        Name = name;
        this.Auther = auther;
        Price = price;
        Qty = qty;
    }

    public override string ToString()
    {
        return $"{Name} by {Auther}";
    }
}


//2.ASSIGNMENT 2:DRIVE EXAMPLE

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }

    public Customer(int id, string name, char gender)
    {
        ID = id;
        Name = name;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"{Name} ({ID})";
    }

}

public class Account
{
    public int ID { get; set; }
    public Customer Customer { get; set; }
    public double Balance { get; set; }

    public Account(int id, Customer customer, double balance)
    {
        ID = id;
        Customer = customer;
        Balance = balance;
    }

    public override string ToString()
    {
        return $"{Customer.Name} {(ID)} balance = {Balance}";
    }

    public double Deposite(double amount)
    {
        return amount + Balance;
    }

    public double Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            return Balance - amount;
        }

        else
        {
            Console.WriteLine("Amount Withdraw");
            return Balance;
        }

    }

}

//3.ASSIGNMNET 3 : DRIVE EXAMPLE

public class CustomerApp
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Discount { get; set; }

    public CustomerApp(int id, string name, int discount)
    {
        ID = id;
        Name = name;
        Discount = discount;
    }

    public override string ToString()
    {
        return $"{Name} ({ID}) with discount {Discount}%";
    }

}

public class Invoice
{
    public int ID { get; set; }
    public CustomerApp Customer { get; set; }
    public double Amount { get; set; }

    public Invoice(int id, CustomerApp customer, double amount)
    {
        ID = id;
        Customer = customer;
        Amount = amount;
    }

    public double AfterAmountDiscount()
    {
        Amount = Amount - (Amount * (Customer.Discount / 100));
        return Amount;
    }

}

//Exercise 1 - person HAS-A Address

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Pincode { get; set; }

    public Address(string street, string city, string pincode)
    {
        Street = street;
        City = city;
        Pincode = pincode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {Pincode}";
    }
}

public class PersonAddress
{
    public string Name { get; set; } 
    public int Age { get; set; }
    public Address Address { get; set; }

    public PersonAddress(string name, int age, Address address)
    {
        Name = name;
        Age = age;  
        Address = address;
    }

    public override string ToString()
    {
        return $"{Name}, {Age}, {Address}";
    }
}

//Exercise 2 - Car HAS-A Engine
public class Engine
{
    public int CC { get; set; }
    public string FuelType { get; set; }

    public Engine (int cC, string fuelType)
    {
        CC = cC;
        FuelType = fuelType;
    }

    public void Start()
    {
        Console.WriteLine("Engine Started");
    }

    public void Stop()
    {
               Console.WriteLine("Engine Stopped");

    }

    public override string ToString()
    {
        return $"{CC}, {FuelType}";
    }
}

     public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public Car(string brand, string model, Engine engine)
    {
        Brand = brand;
        Model = model;
        Engine = engine;
    }

    public override string ToString()
    {
        return $"{Brand}, {Model}, {Engine}";
    }
}

//------------------------------------------------------------------------------------------
//Assignmetn 1 : Library Book System
//Create layered architecture for a library Controller  -> library Service -> Library Repository ->
//int [] bookPages Array : {120,450,300,700,150,90,500} Serive should calculate
//1) Total Books
//2) Average pages
//3) Biggest book
//4) Smallest book
//5) Books with more than 300 pages
//------------------------------------------------------------------------------------------
public class LibraryRepository
{
    public int[] _bookPages = { 120, 450, 300, 700, 150, 90, 500 };

    public int[] GetAllbookPages()
    {
        return _bookPages;
    }
}

//Service Layer

public class LibraryService
{
    private readonly LibraryRepository _repository;
    public LibraryService(LibraryRepository repository)
    {
        _repository = repository;
    }

        public int TotalBook()
        {           
        return _repository.GetAllbookPages().Length;
        }

        public double AveragePages()
        {
        return _repository.GetAllbookPages().Average();
        }

        public int BiggestBook()
        {
        return _repository.GetAllbookPages().Max();
        }

        public int SmallestBook()
        {
        return _repository.GetAllbookPages().Min();
        }

        public int BooksMoreThan300Pages()
        {
        return _repository.GetAllbookPages().Where(pages => pages > 300).Count();
        }
    
    }

        //Control layer
        public class LibraryController
    {
        private readonly LibraryService _service;

        public LibraryController(LibraryService service)
        {
            _service = service;
        }

        public void DisplayBook()
        {
        Console.WriteLine("1.Total Books: ");
        Console.WriteLine("2.Average Pages:");
        Console.WriteLine("3.Biggest Book:");
        Console.WriteLine("4.Smallest Book:");
        Console.WriteLine("5.books more han 300 Pages");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Total Books is:");
                Console.WriteLine(_service.TotalBook());
                break;

            case 2:
                Console.WriteLine("Average Pages is:");
                Console.WriteLine(_service.AveragePages());
                break;

            case 3:
                Console.WriteLine("Biggest Book has:");
                Console.WriteLine(_service.BiggestBook() + "pages");
                break;

            case 4:
                Console.WriteLine("Smallest Book has:");
                Console.WriteLine(_service.SmallestBook() + "Pages");
                break;

            case 5:
                Console.WriteLine("Books with more than 300 Pages is:");
                Console.WriteLine(_service.BooksMoreThan300Pages());
                break;
            default:
                Console.WriteLine("Invalid choice:");
                break;
        }

    }


    }



//--------------------------------------------------------------------------------------------------------------------
//Assingment 2 :Employee Saalary System
//Structure: Employee Controller -> EmployeeService - > EmployeeRepository ->
//int[] salaries Array: { 15000, 22000, 18000, 35000, 27000, 12000} 
//Calculate : 1)Total Salary Payout 2)Higest Salary 3)Lowest Salary 4)Employess earning > 20000 5)Salary range category
//--------------------------------------------------------------------------------------------------------------------

//Repository layer
public class EmployeeRepository
{
    private int[] salaries = {15000, 22000, 18000, 35000, 27000, 12000 };
    public int[] GetAllsalaries()
    {
               return salaries;
    }
}

//Service Layer
public class Employservice
{
    private readonly EmployeeRepository _repository;

    public Employservice(EmployeeRepository repository)
    {
        _repository = repository;
    }

    public int TotalPayout()
    {
        return _repository.GetAllsalaries().Sum();
    }

    public int HighestSalary()
    {
        return _repository.GetAllsalaries().Max();
    }

    public int LowestSalary()
    {
        return _repository.GetAllsalaries().Min();
    }

    public int EmployeEarning()
    {
        return _repository.GetAllsalaries().Where(salary => salary > 20000).Count();
    }

    public int salaryCategory()
    {
        return _repository.GetAllsalaries().Where(salary => salary >=18000 && salary <= 35000).Count();
    }
}

//Control Layer
public class EmployeeController
{
    private readonly Employservice _service;

    public EmployeeController(Employservice service)
    {
        _service = service;
    }


    public void DisplaySalary()
    {
        Console.WriteLine("1.Total Salary Payout:");
        Console.WriteLine("2.Highest Salary:");
        Console.WriteLine("3.Lowest Salary:");
        Console.WriteLine("4.Employees earning > 20000:");
        Console.WriteLine("5.Salary range category (18000-35000):");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Total Salary Payout is:");
                Console.WriteLine(_service.TotalPayout());
                break;

            case 2:
                Console.WriteLine("Highest Salary is:");
                Console.WriteLine(_service.HighestSalary());
                break;

            case 3:
                Console.WriteLine("Lowest Salary is:");
                Console.WriteLine(_service.LowestSalary());
                break;

            case 4:
                Console.WriteLine("Employees earning > 20000 is:");
                Console.WriteLine(_service.EmployeEarning());
                break;

            case 5:
                Console.WriteLine("Employees in salary range 18000-35000 is:");
                Console.WriteLine(_service.salaryCategory());
                break;

            default:
                Console.WriteLine("Invalid choice:");
                break;
        }
    }
}


//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Exercise 3 — Order System

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product (string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{ID},{Name}, {Price}";

    }
}

public class OrderItem
{
    public int Quantity { get; set; }
    public Product Product { get; set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal Total()
    {
        return Product.Price * Quantity;   //GET TOTAL PRICE
    }

    public override string ToString()
    {
        return $"{Product.Name} , {Quantity}, Total: {Total()}";
    }
}

public class CustomerProduct
{
    public int ID { get; set; }
    public string Name { get; set; }

    public CustomerProduct(string name)
    {
        Name = name;
    }   

    public override string ToString()
    {
        return $"{Name}";
    }
}

public class Order
{
    public int ID { get; set; }
    public CustomerProduct Customer { get; set; }

    private OrderItem[] items;   //Array of order item
    private int itemCount; // how many items in order

    //public Order()

}