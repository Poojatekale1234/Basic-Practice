//1.Define a custom delegate that takes two integers and returns their difference. Write code to use it.
/*using System;

namespace Demo171
{

    delegate void subtract(int x, int y);

    class Function
    {
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        //public static void Main(string[] args)
        //{
        //    subtract calc = new subtract(sub);

        //    calc(40, 20);
        //}

    }
}*/


//2.Create a method Calculate that accepts a delegate and two integers, then executes the delegate.
/*using System;
namespace Demo171
{
    delegate int Operation(int x, int y);
     class function
    {
        public static int add(int a,int b)
        {
            return a + b;
        }

        public static int sub(int a,int b)
        {
            return a - b;
        }

        public static int mul(int a,int b)
        {
            return a * b;
        }

        public static int div(int a,int b)
        {
            return a / b;
        }

        public static void calculate(Operation op,int x,int y)
        {
            return op(x, y);
        }

        public static void Main(string[] args)
        {
         int res1 = Calculate(add, 5, 10);
            int res2 = Calculate(sub, 10, 5);
            int res3=Calculate(mul, 10, 5);
            int res4= Calculate(div, 10, 5);

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3); 
            Console.WriteLine(res4);
        }

    }
}*/