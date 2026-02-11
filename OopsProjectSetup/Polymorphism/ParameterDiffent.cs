using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class ParameterDiffent
    {
        //8.Create overloaded methods where parameter order is different but types are same.

        public static void Paramter(int age, string name, int num)
        {
            Console.WriteLine($"Age : {age}, Name : {name}, Num:{num}");
        }

        public static void Paramter(string name, int age, int num)
        {
            Console.WriteLine($"Name : {name}, Age : {age}, Num:{num}");
        }

        public static void Paramter(int num , int age,string name)
        {
            Console.WriteLine($"Num : {num}, Age:{age}, Name : {name}");
        }
    }
}
