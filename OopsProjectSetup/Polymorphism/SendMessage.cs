using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    internal class SendMessage
    {

        //9.Create a method SendMessage() that works for: (Mobile number, Email, Mobile number with country code)
        public static void sendMessage(int mobileNumber)
        {
            Console.WriteLine($"Sending message to mobile number : {mobileNumber}");
        }

        public static void sendMessage(string email, int countryCode)
        {
            Console.WriteLine($"Sending message to email : {email}");
            Console.WriteLine($"Mobile number with country code : {countryCode}");
        }
       
    }
}
