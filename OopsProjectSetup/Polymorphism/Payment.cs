using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class Payment
    {
        //11.Create a Payment class with overloaded Pay() methods for: (Cash, Card, UPI)
        public static void Pay(double amount) 
        {
          
            Console.WriteLine($"The payment is done by the cash : {amount}");
        }

        public static void Pay(string CardNumber,double amount)
        {
            Console.WriteLine($"The payment is done by the Card : {CardNumber},Amount : {amount} ");
        }

        public static void Pay( double amount, string UPIID)
        {
            Console.WriteLine($"The payment is done by the UPI : {UPIID}, Amount : {amount}");
        }
            
    }
}
