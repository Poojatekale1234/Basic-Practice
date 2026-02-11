using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    public class printDetsills
    {
        //4.Create a method PrintDetails() that takes: (name, name and age)
        public static void PrintDetails(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        public static void PrintDetails(int age,string name)
        {
            Console.WriteLine($"Age : {age}, Name : {name}");
        }


        
    }
}
