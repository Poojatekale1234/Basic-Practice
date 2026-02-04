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
        AppSettings user6 = new AppSettings();
        Console.WriteLine(user6);

    }
}

