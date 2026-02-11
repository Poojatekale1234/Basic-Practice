using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class CheckOverloading
    {
        //5.Is method overloading possible by changing only return type? Explain with code.INTERMEDIATE LEVEL
       
        public static string overloadingCheck(string name)
        {
            return $"Name : {name}";
        }

        //public static void overloadingCheck(string name):this(name)
        //{
        //    Console.WriteLine($"Name : {name}");
          
        //}

        //No- even return type is diffrent but sigature is same so that's why Error is occuredand and method overloading is not  possible by chainging

    }
}
