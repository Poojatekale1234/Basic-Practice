using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using OopsProjectSetup.Oops;   //Path to access oops namespace

namespace OopsProjectSetup.Oops
{
    internal class oops
    {
        //1.Create a class AdminUSer with properties AdminId, Name, and isActive
        //The default constructor should set IsActive = true.
        //Create an object and print the IsActive value

        public class AdminUser
        {
            public int AdminId { get; set; }
            public string Name { get; set; }
            public bool isActive { get; set; }

            public AdminUser()
            {
                AdminId = 1;
                Name = "Pooja";
                isActive = true;

            }
        }

        //2.Parameterized Constructor
        //Create a class LoginSeession with AdminId and Login Time.
        //Initilize values using parameterized constructor. and print the login details

        public class LoginSession
        {
            public int AdminId { get; set; }
            public int LoginTime { get; set; }


            public LoginSession(int adminId, int loginTime)
            {
                AdminId = adminId;
                LoginTime = loginTime;
            }

            public LoginSession()
            {
                AdminId = 1;
                LoginTime = 10;
            }
        }

        //3.Constructor Overloading
        //Create a class UserProfile with Name,age and Cityyy
        //create three co structors
        //1.NAme only
        //2.Name and Age
        //3.Name, Age, City
        //Create bjects using all constructors and prints details

        public class UserProfile
        {
            public String Name { get; set; }
            public int age { get; set; }
            public String City { get; set; }

            public UserProfile(String name)
            {
                Name = name;
            }

            public UserProfile(String city,int age)
            {
                City = city;
            }

            public UserProfile(String name, int age, String city)
            {
                Name = name;
                this.age = age;
                City = city;
            }

            //Use ToString() method to print object details
            public override string ToString()
            {
                return $"Name: {Name}, Age: {age}, City: {City}";
            }
        }

        //4.Constructor Chaining using this()
        //Modify UserProfile Constructor so that:
        //-Second Consructor call First Constructor using this()
        //-Third Constructor calls Second Constructor using this()
        //Avoid Duplicate code

        public class UserProfile1
        {
            public String Name { get; set; }
            public int age { get; set; }
            public String City { get; set; }

            public UserProfile1(String name)
            {
                Name = name;
            }

            public UserProfile1(String name,int age):this(name)
            {
                this.age = age;
            }

            public UserProfile1(string name,int age,string city):this(name,age)
            {
                City = city;
                Console.WriteLine("Constructor Chaining using this()");
            }

            //Use ToString() method to print object details
            public override string ToString()
            {
                return $"Name :{Name}, Age: {age}, City: {City}";
            }
        }

        //5..Constructor chainng using base
        //Create a base class Admin with constructor accepting Name
        //Create derived class SuperAdming with Construcotr accepting name and permissionLevel.
        //Use base keyword to call parent constructor and print detsils.



        //6.Private Constructor
        //Create a class AdminConfig with a provate Constructor and a static property AppName
        
        public class AdminConfig
        {
            public string AppName { get; set; }

            private AdminConfig()
            {
                AppName = "Facebook";
            }

            public static AdminConfig CreateObject()
            {
                return new AdminConfig();
            }
        }

        //7.constrocotr vs static construcotr
        //Create a class AppSettings with:
        //static construcotor intitializing Application Name
        //Normal Constructor initilizing Envorinmrnt
        //Print both values and explain execurtion order

        public class AppSettings
        {
            public static String ApplicationName { get; set; }
            public string Enviornment { get; set; }

            static AppSettings()
            {
                ApplicationName = "Facebbok";

            }

            public AppSettings()
            {
                Enviornment = "Nice";
             }

            public override string ToString()
            {
                return $"Application Name :{ ApplicationName}  Enviornment:{Enviornment }";
            }
        }
            
        //8.Singleone pattern using Construcotor
        //Create a singleton class USing private constructor, static instance , and pub;ic static property
        //Mention real-time use case (cache, configuration, logger)


    }
}

