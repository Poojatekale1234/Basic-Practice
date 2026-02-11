using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class OverloadAdd
    {

        //7.Overload a method Add() for: (int, double, decimal)
        public static decimal Add(int a, double b, decimal c)
        {
            return a + (decimal)b + c;   //Explicite type casting
        }

    }
}
