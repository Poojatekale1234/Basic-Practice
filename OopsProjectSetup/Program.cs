using OopsProjectSetup.Oops;
using System.Runtime.InteropServices;
using static OopsProjectSetup.Oops.oops;

public class Program
{
    public static void Main(string[] args)
    {
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

            public class Sample1
    {
        private static int instanceVar = 10;    

        public static void Show()
        {
            Sample1 obj = new Sample1();
            Console.WriteLine(instanceVar);
        }

    }



}


