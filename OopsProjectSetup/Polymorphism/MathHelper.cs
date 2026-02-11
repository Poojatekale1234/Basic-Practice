using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class MathHelper
    {
        //ASSIGNMENTS   
        //1.Create a class Calculator and overload a method Multiply(): (Two integers, Three integers)

        public static int Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication of two integers:");
            return a * b;
        }

        public static int Multiply(int a, int b, int c)
        {
            Console.WriteLine("Multiplication of three integers:");
            return a * b * c;
        }

        //2.Create a method Display() that accepts: (int, string)
        public static void Display(int number, string message)
        {
            Console.WriteLine($"Display Method called it:{number}{message}");
        }
    }


}
