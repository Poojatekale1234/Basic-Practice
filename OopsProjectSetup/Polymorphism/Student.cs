using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProjectSetup.Polymorphism
{
    public class StudentInfo
    {
        //6.Create a class Student and overload a method GetResult(): (Accept total marks, Accept marks of 3 subjects separately)
        public static string GetResult(int totalMarks) => ((totalMarks / 3) > 35) ? "Pass" : "Fails";
        public static string GetResult(int sub1, int sub2, int sub3) => (sub1 >= 35 && sub2 >= 35 && sub3 >= 35) ? "Pass" : "Fails";

 

        //    public static void GetResult(int subject1, int subject2, int subject3)
        //    {
        //        int total = subject1 + subject2 + subject3;
        //        double percentage = (double)total / 300 * 100;
        //        Console.WriteLine($"Total Marks: {total}, Percentage: {percentage}%");
        //}
    }
}
