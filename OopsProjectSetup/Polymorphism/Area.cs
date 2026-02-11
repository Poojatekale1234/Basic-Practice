using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class Area
    {
        //Assignment 
        //3. Overload a method Area() to calculate: (Area of square, Area of rectangle)
        public static int AreaSquare(int side)
        {
            Console.WriteLine("Area of Square");
            return side * side;
        }

        public static int AreaReactangle(int length, int width)
        {
            Console.WriteLine("Area of Reactangle");
            return length * width;
        }

    }
}
