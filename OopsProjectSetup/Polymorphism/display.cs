using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class display
    {
        //2.Create a method Display() that accepts: (int, string)
        public static void Display(int number, string message)
        {
            Console.WriteLine($"Display Method called it:{number}{message}");
        }

    }
}
