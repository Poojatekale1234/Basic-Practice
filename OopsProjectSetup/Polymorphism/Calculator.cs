using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class Calculator
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

    }
}
