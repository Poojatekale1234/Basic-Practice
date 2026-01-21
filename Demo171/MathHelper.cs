using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Text;

namespace Demo171
{
    public class MathHelper
    {
        //1.Max number
        /*public static int GetAddition(int a, int b, int c)
        {
            int res = (a > b && a > c) ? a : (b > a && b > c) ? b : (c > a && c > b) ? c : 0;
            return res;
        }*/

        //2.Addition upto nth number
        /*public static int sumNum(int n)
        {
            int sum=0;
            for(int i=1;i<=n;i++)
            {
                sum+=i;
            }
            return sum;
        }*/


        //3.145 is a Strong number
        /*public static int fact(int n)
        {
            int sum = 0;

            while(n!=0)
            {
                int d = n % 10;
                int fact = 1;

                for(int i=1;i<=d;i++)
                {
                    fact *= i;
                }
                sum += fact;
                n /= 10;
            }
            return sum;
        }*/

        //4.even or odd
        /*public static int EvenOdd(int n)
        {


            int res = (n % 2 == 0) ? 1 : 0;
            return res;
        }*/

        /*public static string EvenOdd(int n)
        {
            if(n%2==0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }*/

        //5.Positive and negative

        /*public static String PosNeg(int n)
        {
            String res = (n > 0) ? "Positive Number" : (n < 0) ? "Negative" : "Zero";

            return res;

        }*/

        //6.The Year is a Leap or Not
        /*public static String leap(int n)
        {
            String res = (n % 4 == 0) ? "Leap Year" : "Not leap Year";
            return res;
        }*/

        //7.The Ch is Vowel or Constant  ==>Isssues 

        /*public static char Vowel(char ch)
        {
            
            char res=(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U');
            ?'V':'C';

            return res;
        }*/

        //8.Eligible for vote or not

        /*public static String Vote(int n)
        {
            String res = (n >= 18) ? "Eligible" : "Not Eligible";
            return res;
        }*/

        //9.Divisible by 5 and 11

        /*public static String divisible(int n)
        {
            String res = (n % 5 == 0 && n % 11 == 0) ? "Divisible by both" : "Not divisible";
            return res;
        }*/

        //10.Three Digit or Not
        /*public static int digit(int n)
        {
            int res = (99 > n) ? 0:1;
                return res;
        }*/

        //11.Senoir Citizen or not
        /*public static String citizen(int n)
        {
           
           if(n>=60)
            {
                return "Senoir Citizen";
            }
           else
            {
                return "Not Senoir Citizen";
            }
                
        }*/

        //12.UpperCase or LowerCase  ==>Issues
        /*public static bool UpperLower(char c)
        {
            bool res = (c >= 'a' && c <= 'z' || c >= 'A' && c >= 'Z');
                return res;
        }
        */

        //13.Prime number
        //public static bool PrimeNo(int n)
        //{
        //    int coun = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        { coun++; }

        //        if (coun == 2)
        //        {
        //            return true;
        //        }
        //    }
        //}
    }
}
