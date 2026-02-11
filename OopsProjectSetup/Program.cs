using OopsProjectSetup.Oops;
using OopsProjectSetup.Polymorphism;
using OopsProjectSetup.Polymorphism;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//1.Default Constructor
//AdminUser user = new AdminUser();
//Console.WriteLine("IsActive: " + user.isActive);


//2.Parameterized Constructor
//LoginSession user1 = new LoginSession(2, 12);
//Console.WriteLine("AdminId: " + user.AdminId);


//3.Constructor Overloading
//UserProfile user2 = new UserProfile("Pooja",21,"Solapur");
//Console.WriteLine(user1);


//4.Constructor Chaining using this()
//UserProfile1 user3 = new UserProfile1("Maithili", 20, "Akluj");
//Console.WriteLine(user3);

//5..Constructor chainng using base


//6.Private constructor
//AdminConfig user5 = AdminConfig.CreateObject();
//Console.WriteLine(user5.AppName);

//7.constructor vs Static constructor
//AppSettings user6 = new AppSettings();
//Console.WriteLine(user6);
//Console.WriteLine("This is project");
//Console.WriteLine("This is solution explorer");


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//1.Idebtify static vs instance methods
//Given a calculator with add and multiply methods. Decide whteher these methods should be static or instance methods and explain why.

//Static Method
//int sum = Calculator.perform(5, 3);
//Console.WriteLine("the Addition is :" + sum);

//int multiply = Calculator.perform(2, 4);
//Console.WriteLine("The Multiply is :" +  multiply);

////Instance Method
//Calculator calc = new Calculator();
//int sum1 = calc.perform1(5, 5);
//Console.WriteLine("The Addition is:" + sum1);

//int multiply1 = calc.perform1(1, 4);
//Console.WriteLine("The multiply is :" + multiply1);

//2.
// User Name = "Maithili";
//Console.WriteLine(User.Greet("Maithili"));

//3.
//Service service = new Service();
//bool isValid = Service.ValidEmail("tekale16@gmail.com");
//Console.WriteLine("Is Valid Email: " + isValid);


//4.
// class contains a static counter incremented in the constructor. Create multiple objects and predict the output.

//Counter cnt = new Counter();
//Counter cnt1 = new Counter();   
//Counter cnt2 = new Counter();

//5.tatic method tries to access an instance variable. Identify the error and fix it using two different approaches.

//This approach is wrong beacause static method cannot access instance variable directly
// public class Sample
//{
//    public int instanceVar = 10;    //Instace var

//    public static void Show()
//    {
//        Console.WriteLine("instance value");
//    }

//}

//     public class Sample1
//{
//    private static int instanceVar = 10;   

//    public static void Show()
//    {
//        //Sample1 obj = new Sample1();
//        Console.WriteLine(instanceVar);
//    }

//}

//        public class Sample1
//{
//    private static int instanceVar = 10;    

//    public static void Show()
//    {
//        Sample1 obj = new Sample1();
//        Console.WriteLine(instanceVar);
//    }

//}





//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------INHERITANCE-------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//1.practice

//P obj = new C();
//obj.M1();

//2.
//Bird bird = new Bird();
//Bird bird1 = new sparrow();
//Bird bird2 = new sparrowChild();

//3.Constructor chaining example in inheritance
//Animal animal = new Animal();

//4.
//Bird obj = new sparrowChild();

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//    }

//}

//Inheritance Dia Assignment


//public class Program
//{

//    public static void Main(string[] args)
//    {
//2.INheritance Dia Assignment
//Student s = new Student("Pooja", "Pune", "BE", 4, 80000);
//Console.WriteLine(s);

//Staff s2 = new Staff("maithili","Solapur","xyz", 30000);
//Console.WriteLine(s2);

//3.
//point3D obj = new point3D();
//Console.WriteLine(obj);

//point3D d1 = new point3D(1, 1, 1);
//Console.WriteLine(d1);
//float[] xyz = d1.GETXYZ();
//foreach(var v in xyz)
//{
//    Console.WriteLine(v);
//}



// --------------------------------------------------------------------------------------------------
//09-02-2026
//--------------------------------------------------------------------------------------------------
//1.Assignment 1:DRIVE EXAMPLE

//Author auth = new Author("Maithili","@gamil.com",'F');
//Console.WriteLine(auth);
//Book book = new Book("secrets",auth,200,2);
//Console.WriteLine(book);


//2.Assignment 2 : DRIVE EXAMPLE
//Customer c1 = new Customer(101, "Maithili", 'F');
//Console.WriteLine(c1);

//Account acc = new Account(1, c1, 90000);
//Console.WriteLine(acc);


//3.Assignment 3: DRIVE EXAMPLE
//Customer1 cs = new Customer1(101,"Maithili",20);
//Console.WriteLine(cs);

//Invoice Inv  = new Invoice(1,cs,50000);
//Console.WriteLine("Amt. after discount = "+ Inv.AfterAmountDiscount());


//----------------------------------------------------------------
//Exercise 1 - Person HAS-A Address
//Address addr = new Address("Kumthekar road", "Pune", "413322");
//Console.WriteLine(addr);

//PersonAddress personadd = new PersonAddress("Maithili", 23, addr);
//Console.WriteLine(personadd);

//++++++++++++++++++++++++++++++++++++++++++++

//Exercise 2 - Car HAS-A Engine
//Engine engine = new Engine(150, "Petrol");
//Console.WriteLine(engine);

//Car vehical = new Car("MINI", "MINI Couper", engine);
//Console.WriteLine(vehical);

//HAS-A relationship Layered Architecture Example

//Assignmetn 1 : Library Book System
//Create layered architecture for a library Controller  -> library Service -> Library Repository ->
//int [] bookPages Array : {120,450,300,700,150,90,500} Serive should calculate
//1) Total Books
//2) Average pages
//3) Biggest book
//4) Smallest book
//5) Books with more than 300 pages


//LibraryRepository repo = new LibraryRepository();
//LibraryService service = new LibraryService(repo);
//LibraryController controoller = new LibraryController(service);
//controoller.DisplayBook();


//--------------------------------------------------------------------------------------------------------------------
//Assingment 2 :Employee Saalary System
//Structure: Employee Controller -> EmployeeService - > EmployeeRepository ->
//int[] salaries Array: { 15000, 22000, 18000, 35000, 27000, 12000} 
//Calculate : 1)Total Salary Payout 2)Higest Salary 3)Lowest Salary 4)Employess earning > 20000 5)Salary range category
//--------------------------------------------------------------------------------------------------------------------

//EmployeeRepository repo = new EmployeeRepository();
//Employservice service = new Employservice(repo);
//EmployeeController controller = new EmployeeController(service);
//controller.DisplaySalary();



//    }
//}

//=========================================================================================================================================================================================================
//POLYMORPHISM 
//=========================================================================================================================================================================================================
using System;  // import the namespace
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static OopsProjectSetup.Oops.oops;

public class Program
{
    public static void Main(string[] args)
    {

        //1.Create a class Calculator and overload a method Multiply(): (Two integers, Three integers)
        int result1 = MathHelper.Multiply(3, 1);  
        Console.WriteLine(result1);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

        int result2 = MathHelper.Multiply(2, 3, 1); 
        Console.WriteLine(result2);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

        //2. Create a method Display() that accepts: (int, string)
        display.Display(101 , "Hello worlds");
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //3. Overload a method Area() to calculate: (Area of square, Area of rectangle)
        int result3 = Area.AreaSquare(3);
        Console.WriteLine(result3);

        int result4 = Area.AreaReactangle(3, 4);
        Console.WriteLine(result4);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //4.Create a method PrintDetails() that takes: (name, name and age)
        printDetsills.PrintDetails("Maithili");
        printDetsills.PrintDetails(21, "Gayatri");
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //5.Is method overloading possible by changing only return type? Explain with code.INTERMEDIATE LEVEL


        //6.Create a class Student and overload a method GetResult(): (Accept total marks, Accept   marks of 3 subjects separately)
        Console.WriteLine("The Student is a:");
        Console.WriteLine(StudentInfo.GetResult(230));
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //7.Overload a method Add() for: (int, double, decimal)
        Console.WriteLine(OverloadAdd.Add(4, 5, 6));
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //8.Create overloaded methods where parameter order is different but types are same.
        ParameterDiffent.Paramter(21, "Maithili", 1);
        ParameterDiffent.Paramter("Pragati", 20, 1);
        ParameterDiffent.Paramter(1, 21,"Gayatri");
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //9.Create a method SendMessage() that works for: (Mobile number, Email, Mobile number with country code)
        SendMessage.sendMessage(786954032);
        SendMessage.sendMessage("@gmail.com", +91);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


        //11.Create a Payment class with overloaded Pay() methods for: (Cash, Card, UPI)
        Payment.Pay(345.8);
        Payment.Pay("6543", 123.5);
        Payment.Pay(345, "cash1223");
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");



    }
}

