//using System;
//CIRCLE RADIUS
//namespace Demo171
//{
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            int r = 10;
//            double pi = 3.14;
//            double area = pi * r * r;

//            Console.WriteLine("Area od circle radius " +r+ "=="+area);
//            //Console.WriteLine($"Area of circle with radius {r} == {area}");
//        }

//    }
//}


//CUBE
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 5;
//            int cube = a * a * a;

//            Console.WriteLine("The cube is " + a + "==" + cube);
//        }
//    }
//}


//SQUARE
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[]args)
//        {
//            int a = 5;
//            int square = a * a;
//            Console.WriteLine("The square is " + a + "==" + square);
//        }
//    }
//}


//Area of Triangle
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int b = 10;
//            int h = 5;
//            double area = 0.5 * b * h;
//            Console.WriteLine("The area of trianlge is" + b + h + "==" + area);
//        }
//    }
//}

//Factorial
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {

//        }
//    }
//}

//1.Positive & negative
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter a Number:");
//            num=int.Parse(Console.ReadLine());

//            if(num>=0)
//            {
//                Console.WriteLine("Number is Posititve:");
//            }
//            else
//            {
//                Console.WriteLine("Number is Negative:");
//            }
//        }
//    }
//}


//2.Even or Odd
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter a Number:");
//            num = int.Parse(Console.ReadLine());

//            if (num % 2 == 0)
//            {
//                Console.WriteLine("The Number is Even");
//            }
//            else
//            {
//                Console.WriteLine("The Number is Odd");
//            }
//        }
//    }
//}


//3.Leap Year or NOT

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter a Number:");
//            num = int.Parse(Console.ReadLine());

//            if (num % 4 == 0 && num % 400 == 0)
//            {
//                Console.WriteLine("This is Leap Year:");
//            }
//            else
//            {
//                Console.WriteLine("This is Not Leap Year:");
//            }
//        }
//    }
//}

//4.Check the person is senoir citizen or NOt
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int age;
//            Console.WriteLine("Enter a age:");
//            age=int.Parse(Console.ReadLine());

//            if (age > 59)
//            {
//                Console.WriteLine("This person is  Senoir citizen:");
//            }

//            else {
//                Console.WriteLine("This person is junior citizen:");
//            }
//        }
//    }
//}

//5.The number is divisible by 5&11

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter the number:");
//            num = int.Parse(Console.ReadLine());

//            if (num % 5 == 0 && num % 11 == 0)
//            {
//                Console.WriteLine("This num. is divisible 5 & 11");
//            }
//            else
//            {
//                Console.WriteLine("This num. is not divisible by 5&11");
//            }
//        }
//    }
//}


//6.Vowels

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char c;
//            Console.WriteLine("Enter the Vowels:");
//            c=char.Parse(Console.ReadLine());
//            if(c =='a' ||  c =='e' || c=='i' || c=='o' || c=='u' ||  c=='A' || c=='E' || c=='I' || c=='O' || c=='U')
//            {
//                Console.WriteLine("This is Vowel");
//            }
//            else
//            {
//                Console.WriteLine("This is Not vowel");
//            }
//        }
//    }
//}


//7.Eligible for Vote or Not

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int age;
//            Console.WriteLine("Enter the age:");
//            age = int.Parse(Console.ReadLine());
//            if (age > 17)
//            {
//                Console.WriteLine("Eligible for Vote:");
//            }
//            else
//            {
//                Console.WriteLine("Not Eligible for vote:");
//            }
//        }
//    }
//}


//8.WAP to check whether a number is three digit or not?

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter the Number:");
//            num=int.Parse(Console.ReadLine());
//            if((num>=100 && num<=999) ||(num>=-100 && num<=-999))
//                    {
//                Console.WriteLine("This number is three digit number:");
//            }
//            else
//            {
//                Console.WriteLine("This number is not is in three digit:");
//            }
//        }
//    }
//}


//9.Upper Case & LowerCase

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char ch;
//            Console.WriteLine("Enter the albahbet:");
//            ch =char.Parse(Console.ReadLine());
//            if (ch >= 'A' && ch <= 'Z')
//            {
//                Console.WriteLine("This is Uppercase:");
//            }
//            else if (ch >= 'a' && ch <= 'z')
//            {
//                Console.WriteLine("This is LowerCase");
//            }
//            else {
//                Console.WriteLine("This is not Alphabtes ");
//            }
//        }
//    }
//}


//switch Case
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int op;
//            Console.WriteLine("Enter Day Which you want...!:");
//            op=Convert.ToInt32(Console.ReadLine());
//            string res = op switch
//            {
//                1 => "Sunday",
//                2 => "Monday",
//                3 => "tuesday",
//                4 => "Wensday",
//                5 => "Thursday",
//                6 => "Friday",
//                7 => "Saturday",
//                _=>"Invalid Choice"
//            };
//            Console.WriteLine(res);
//        }
//    }
//}




//EXCERSIZE
//1.WAP to find the maximum between two numbers.
//First take
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n1,n2;
//            Console.WriteLine("Enter a N1");
//            n1=Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter a N2");
//            n2 = Convert.ToInt32(Console.ReadLine());

//            string res = (n1 > n2, n1 < n2) switch
//            {

//                //1 => "Maximum number is n1",
//                // 2 => "Maximum number is n2",

//                (true, false) => "Maximum number is n1",
//                (false, true) => "Maximum number is n2",
//                _ => "Invalid choice"
//            };
//            Console.WriteLine(res);
//        }
//    }
//}

//Second take== Some error  in this

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num1, num2;
//            Console.WriteLine("Enter any two number to find greatest :\n");
//            int num1 = Convert.ToInt32(Console.ReadLine());
//            int num2 = Convert.ToInt32(Console.ReadLine());
//            bool result = (num1 > num2);
//            int greater = result switch
//            {
//                true => num1,
//                false => num2
//            };
//            Console.WriteLine("Maximum  number is :" + greater);
//        }
//    }
//}


//2.WAP to find maximum betwwen three numbers

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n1, n2, n3;
//            Console.WriteLine("Enter a n1");
//            n1 =int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter a n2");
//            n2 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter a n3");
//            n3 = int.Parse(Console.ReadLine());

//            string res = (n1 > n2 && n1 > n3,
//              n2 > n1 && n2 > n3) switch
//            {
//                (true, false) => "n1 is greater",
//                (false, true) => "n2 is greater",
//                _ => "n3 is greater"
//            };

//            Console.WriteLine(res);

//        }
//    }
//}


//3.WAP to checke number is positive,negative or Zero

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter a Number:");
//            n=int.Parse(Console.ReadLine());

//            string res = (n > 0, n < 0) switch
//            {

//                (true, false) => "number is Postive",
//                (false, true) => "number is negative",
//                _ => "Number is zero"

//            };
//            Console.WriteLine(res); 
//        }
//    }
//}

//4.WAP the number is divisible 5 & 11

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter a Number");
//            n=int.Parse(Console.ReadLine());

//            string res = (n % 5 == 0 , n % 11 == 0) switch
//            {
//                (true,true)=>"The number is divisible by both",
//                (true, false) => "This number is divisible by only 5",
//                (false, true) => "This numbr is not divisble by only 11",
//                _ => "Number is not divisble atlaest One"
//            };
//            Console.WriteLine(res);
//        }
//    }
//}

//5.WAP to check number is Even or odd

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter a Number:");
//            n=int.Parse(Console.ReadLine());

//            string res = (n % 2 == 0) switch
//            {
//                true => "The number is EVEN",
//                false => "The number is NEGATIVE",
//            };
//            Console.WriteLine(res);
//        }
//    }
//}

//6.WAP to cehck Leap Year or Not

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter a Number:");
//            n = int.Parse(Console.ReadLine());

//            string res = (n % 4 == 0) switch
//            {
//                true => "This is leap Year",
//                false => "This is not Leap Year",
//            };
//            Console.WriteLine(res);
//        }
//    }
//}

//7.WAP to check aphaber or Not

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char ch;
//            Console.WriteLine("Enter a character:");
//            ch = char.Parse(Console.ReadLine());

//            string res = (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z') switch
//            {
//                true=>"This is Aplhabet",
//                false=>"This is Not Alphabet"
//            };
//            Console.WriteLine(res);

//        }
//    }
//}

//8.WAP to check Vowels or Not

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char c;
//            Console.WriteLine("Enter a Character:");
//            c = char.Parse(Console.ReadLine());

//            string res = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') switch
//            {
//                true => "This is Vowel",
//                false => "This is Not Vowel"
//            };
//            Console.WriteLine(res);

//        }
//    }
//}

//9.WAP to check aphabet, digit or special charcter

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char c;
//            Console.WriteLine("Enter a Number:");
//            c = char.Parse(Console.ReadLine());

//            bool isAlpha = (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
//            bool isDigit = (c >= '0' && c <= '9');

//            string res = (isAlpha, isDigit) switch
//            {
//                (true, false) => "This is Alphabet",
//                (false, true) => "This is Digit",
//                _ => "This is Special Character"
//            };

//            Console.WriteLine(res);
//        }
//    }
//}

//10.WAP input week number and print week day

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int weekNo;
//            Console.WriteLine("Enter a Week Number:");
//            weekNo=int.Parse(Console.ReadLine());
//            //weekNo = 1;

//            string res = weekNo switch
//            {
//                1 => "Monday",
//                2 => "Tuesday",
//                3 => "Wensday",
//                4 => "Thursday",
//                5 => "Friday",
//                6 => "Saturday",
//                7 => "Sunday",
//                _=>"Invalid choice",
//            };
//            Console.WriteLine(res);
//        }
//    }
//}


//11.WAP input month number and print the number of days in that

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int monNo;
//            Console.WriteLine("Enter a month No.:");
//            monNo=int.Parse(Console.ReadLine());

//            string res = monNo switch
//            {
//                1 => "31 Days(Jan)",
//                2 => "28/29 Days(feb)",
//                3 => "31 Days(mar)",
//                4 => "30 Days(Apr)",
//                5 => "31 Days(may)",
//                6 => "30Days (June)",
//                7 => "31 Days (July)",
//                8 => "31 Days (Aug)",
//                9 => "30 Days (Sept)",
//                10 => "31 Days (Oct)",
//                11 => "30 Days (Nov)",
//                12 => "31 Days (Dec)",

//            };
//            Console.WriteLine(res);
//                }
//    }
//}


//12.WAP to count total number of notes in given amount
//Using If-Else
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int amount;


//            Console.WriteLine("Enter the amount");
//            amount = int.Parse(Console.ReadLine());
//            int notes = 0;


//            if (amount >= 500)
//            {
//                notes = amount / 500;
//                Console.WriteLine("500 notes ==> " + notes);
//                amount = amount % 500;
//            }

//            if (amount >= 200)
//            {
//                notes = amount / 200;
//                Console.WriteLine("200 notes ==>" + notes);
//                amount = amount % 200;
//            }

//            if (amount >= 100)
//            {
//                notes = amount / 100;
//                Console.WriteLine("100 notes ==>" + notes);
//                amount = amount % 100;
//            }

//            if (amount >= 50)
//            {
//                notes = amount / 50;
//                Console.WriteLine("50 notes==>" + notes);
//                amount = amount % 50;
//            }

//            if (amount >= 10)
//            {
//                notes = amount / 10;
//                Console.WriteLine("10 notes ==>" + notes);
//                amount = amount % 10;
//            }

//            if (amount >= 5)
//            {
//                notes = amount / 5;
//                Console.WriteLine("5 notes ==>" + notes);
//                amount = amount % 5;
//            }

//            if (amount >= 2)
//            {
//                notes = amount / 2;
//                Console.WriteLine("2 notes ==> " + notes);
//                amount = amount % 2;
//            }

//            if (amount >= 1)
//            {
//                notes = amount / 1;
//                Console.WriteLine("1 notes ==>" + notes);
//                amount = amount % 1;
//            }
//        }
//    }
//}


//13.WAP to input angels of a triangle and check wheter traingle is valid or not

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int angle;
//            Console.WriteLine("Enter a Number:");
//            angle = int.Parse(Console.ReadLine());

//            bool ang= angle == 180;

//            string res = ang switch
//            {
//                true => "This is valid Triangle",
//                false => "This is Invalid Traingle",
//                //_=>"This is not traingle",

//            };
//            Console.WriteLine(res);
//        }
//    }
//}


//14.WAP check the traingle is equilateral, isoScales or scalene traingle


//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int A, B, C, ang;
//            Console.WriteLine("Enter a A:");
//            A = int.Parse(Console.ReadLine());
//            ang = 1;

//            Console.WriteLine("Enter a B:");
//            B = int.Parse(Console.ReadLine());
//            ang = 2;

//            Console.WriteLine("Enter a C:");
//            C = int.Parse(Console.ReadLine());
//            ang = 3;


//            //bool equilateral = (A + A + A == 180);
//            //bool isoScale = (A + A + B == 180);
//            //bool scalene = (A + B + C == 180);

//            if (A + B + C != 180)
//                ang = 0;           
//            else if (A == B && B == C)
//                ang = 1;           
//            else if (A == B || B == C || A == C)
//                ang = 2;           
//            else
//                ang = 3;

//            //string res = (equilateral || isoScale || scalene) switch

//            string res = ang switch
//            {
//               1 => "this is equlatral triangel",
//                2 => "this is isoscale traingle",
//                3 => "this is scalene traigle",
//                _=> "This is invalid traingle",
//            };

//            Console.WriteLine(res);
//        }
//    }
//}

//15.WAP input marks of five subjects physics,chemistry,biology,mathematics and computer, calculate percentage and grade


//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int m1, m2, m3,m4,m5;
//            Console.WriteLine("Enter your five subject names:");
//            m1=int.Parse(Console.ReadLine());
//            m2=int.Parse(Console.ReadLine());
//            m3=int.Parse(Console.ReadLine());
//            m4 = int.Parse(Console.ReadLine());
//            m5 = int.Parse(Console.ReadLine());



//            float per = ((m1 + m2 + m3 + m4 + m5) * 100) / 500;
//            if(per>34)
//            {
//                if(per>=90)
//                {
//                    Console.WriteLine("Pass with A Grade");
//                }
//                else if(per>=80)
//                {
//                    Console.WriteLine("Pass with B Grade");
//                }

//                else if(per>=70)
//                {
//                    Console.WriteLine("Pass with C Grade");
//                }

//                else if(per>=60)
//                {
//                    Console.WriteLine("Pass with D Grade");
//                }

//                else if(per>=35)
//                {
//                   Console.WriteLine("Pass with Grade");
//                }

//                else
//                 {
//                    Console.WriteLine("Fail with No Grades");
//                 }

//            }
//        }
//    }
//}


//16.WAP to print the day of week name using switch case using If-Else

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int day;
//            Console.WriteLine("Enter the 1-7 number");
//            day = int.Parse(Console.ReadLine());

//            if (day == 1)
//            {
//                Console.WriteLine("Monday");
//            }

//            else if (day == 2)
//            {
//                Console.WriteLine("Tuesday");
//            }

//            else if (day == 3)
//            {
//                Console.WriteLine("Wensday");
//            }

//            else if (day == 4)
//            {
//                Console.WriteLine("Thursday");
//            }

//            else if (day == 5)
//            {
//                Console.WriteLine("Friday");
//            }

//            else if (day == 6)
//            {
//                Console.WriteLine("Saturday");
//            }

//            else if (day == 7)
//            {
//                Console.WriteLine("Sunday");
//            }

//            else
//            {
//                Console.WriteLine("Invalid day:");
//            }

//        }
//    }
//}


//17.WAP print the total number of days in month using If-Else

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int month;
//            Console.WriteLine("Enter the 1-12 days");
//            month=int.Parse(Console.ReadLine());

//            if(month==1 || month ==3 || month==5|| month==7|| month==8 || month ==10 || month==12)
//            {
//                Console.WriteLine("31 days");
//            }

//            else if(month ==4 || month ==6|| month==9 ||month==11)
//            {
//                Console.WriteLine("30 days");
//            }

//            else if(month==2)
//            {
//                Console.WriteLine("28 days");
//            }

//            else
//            {
//                Console.WriteLine("Invalid Month");
//            }
//        }
//    }
//}

//18.WAP the alphabet is Vowel or Constant Using If-Else

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char ch;
//            Console.WriteLine("Enter a alphabet:");
//            ch = char.Parse(Console.ReadLine());

//            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//            {
//                Console.WriteLine("This is Vowel");
//            }
//            else
//            {
//                Console.WriteLine("This is Conatant");
//            }

//        }
//    }
//}


//19.WAP to find maximum between two numbers using If-Else

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int n1, n2;
//            Console.WriteLine("Enter a two Numbers:");
//            n1=int.Parse(Console.ReadLine());
//            n2=int.Parse(Console.ReadLine());

//            if(n1>n2)
//            {
//                Console.WriteLine("N1 is greater");
//            }
//            else
//            {
//                Console.WriteLine("N2 is greater");
//            }

//        }
//    }
//}

//20.WAP Check program is Evne or Odd using If-Else

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num;
//            Console.WriteLine("Enter a Number:");
//            num=int.Parse(Console.ReadLine());

//            if (num > 0)
//            {
//                Console.WriteLine("The Number is Even");
//            }
//            else if (num < 0)
//            {
//                Console.WriteLine("The Number is Odd");
//            }
//            else
//            {
//                Console.WriteLine("The Number is Zero");
//            }
//        }
//    }
//}


//21.WAP to create a Simple Calculator using Switch Case

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int num1,num2;
//            char op;
//            Console.WriteLine("Enter a First Number for Calculate");
//            num1=int.Parse(Console.ReadLine());

//            Console.WriteLine("ENter a Second Number for Calculate");
//            num2=int.Parse(Console.ReadLine());


//            Console.WriteLine("Enter a Operatoe(+,-,*,/,%)");
//            op= char.Parse(Console.ReadLine());

//            string res = op switch
//            {
//               '+'=>"Resulr =" +(num1+num2),
//               '-'=>"Result = "+(num1-num2),
//               '*'=>"Result ="+(num1*num2),  
//               '/' => num2 != 0
//                ? "Result = " + (num1 / num2)
//                 : "Division by zero is not allowed",
//                 '%'=>"Result =" +(num1%num2),
//                 _=>"Invalid Operator"
//            };
//            Console.WriteLine(res);
//        }
//    }
//}


//SCENARIO BASED PRACTICE QUESTION

//REAL LIFE SCENARIO

//1.A User enter age.  Display child,adult or senoir citizen

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int age;
//            Console.WriteLine("Enter a User Age");
//            age=int.Parse(Console.ReadLine());

//            if(age<18)
//            {
//                Console.WriteLine("This User is Child");
//            }

//            else if(age<60)
//            {
//                Console.WriteLine("This User is Adult");
//            }

//            else if(age>=60)
//            {
//                Console.WriteLine("This User is Senior Ctizien");
//            }

//            else
//            {
//                Console.WriteLine("Invali User");
//            }
//        }
//}
//}

//2.A Student Enters Marks. Display Pass or Fail

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int mark;
//            Console.WriteLine("Enter a Marks:");
//            mark = int.Parse(Console.ReadLine());

//            if (mark >= 35 && mark<=100)
//            {
//                Console.WriteLine("Student is Pass");
//            }

//            else if(mark<35)
//            {
//                Console.WriteLine("Student is Fail");
//            }

//            else
//            {
//                Console.WriteLine("Invalid marks");
//            }
//        }
//    }
//}

//3.A Coustomer Enter Purchase amount. if amount is more than 5000, apply discount

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            double amount, discount = 0, finalAmount;
//            Console.WriteLine("Enter Your Amount");
//            amount=double.Parse(Console.ReadLine());

//            if(amount>5000)
//            {
//                discount = amount * 0.10;
//            }
//            finalAmount = amount - discount;

//            Console.WriteLine("Discount =" +discount);
//            Console.WriteLine("finalAmount to pay ="+finalAmount);
//        }
//    }
//}


//4.A user enters temperature.Display cold,Normal or Hot

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int temp;
//            Console.WriteLine("Enter a Temperatur:");
//            temp = int.Parse(Console.ReadLine());

//            if (temp >0 && temp < 20)
//            {
//                Console.WriteLine("The Temperature is Cold");
//            }

//            else if (temp >= 20 && temp < 30)
//            {
//                Console.WriteLine("The Temperature is Normal");
//            }
//            else
//            {
//                Console.WriteLine("The temperature is Hot");
//            }
//        }
//    }
//}

//5.A user Enters Login status (true/false). Display login sucessful or login failed

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            bool loginStatus;
//            Console.WriteLine("Enter Your LoginStatus");
//            loginStatus = bool.Parse(Console.ReadLine());

//            if (loginStatus == true)
//            {
//                Console.WriteLine("Login Successful");
//            }
//            else
//            {
//                Console.WriteLine("Login Failed");
//            }
//        }

//    }
//}


//BUSSINESS SCENARIO (ELSE IF)

//6.Employee Salary Calculation based on experience years

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            double salary, updateSalary;
//            int experience;

//            Console.WriteLine("Enter the Salary:");
//            salary = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the experience:");
//            experience = int.Parse(Console.ReadLine());

//            if (experience <= 2)
//            {
//                updateSalary = salary;
//            }

//            else if (experience > 2 && experience < 5)
//            {
//                updateSalary = salary +(salary * 0.10);
//            }
//            else
//            {
//                updateSalary = salary +(salary * 0.10);
//            }


//            Console.WriteLine("The FinalSalary is=" +updateSalary);
//        }
//    }
//}

//7.Electricity bill calculation using units consumed

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int units;
//            double bill;

//            Console.WriteLine("Enter a Units");
//            units=int.Parse(Console.ReadLine());

//if (units == 0 && units <= 100)
//{
//    bill = units * 2;
//}
//else if (units > 100 && units <= 200)
//{
//    bill = (units * 2) + (units * 3);
//}

//else if (units > 200 && units <= 300)
//{
//    bill = (units * 2) + (units * 3) + (units * 4);
//}
//else
//{
//    bill = (units * 2) + (units * 3) + (units * 4) + (units * 5);
//}

//            if (units <= 100)
//            {
//                bill = units * 2;
//            }
//            else if (units <= 200)
//            {
//                bill = (100 * 2) + (units - 100) * 3;
//            }
//            else if (units <= 300)
//            {
//                bill = (100 * 2) + (100 * 3) + (units - 200) * 4;
//            }
//            else
//            {
//                bill = (100 * 2) + (100 * 3) + (100 * 4) + (units - 300) * 5;
//            }


//            Console.WriteLine("The bill is =" +bill);
//        }
//    }
//}

//8.incomTax Calculation based on salary slab

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            double salary, tax = 0,finalSalary;
//            Console.WriteLine("Enter a Salary:");
//            salary=double.Parse(Console.ReadLine());

//            if (salary == 250000)
//            {
//                tax = 0;
//            }

//            else if(salary >250000 && salary <=500000)
//            {
//                tax = (salary * 5) / 100;
//            }

//            else if(salary >500000 && salary <=1000000)
//            {
//                tax=(salary * 10) /100;
//            }

//            else if(salary >1000000)
//            {
//                tax =(salary * 30) /100;
//            }

//            Console.WriteLine("The tax + Final Amount=" +tax);
//        }
//    }
//}


//9.Student grading system based on percentage.

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int m1,m2,m3;
//            Console.WriteLine("Enter the marks:");
//            m1=int.Parse(Console.ReadLine());
//            m2 = int.Parse(Console.ReadLine());
//            m3 = int.Parse(Console.ReadLine());

//            float per = (m1 + m2 + m3) * 100 / 300;

//            if(per>34)
//            {
//                if(per>=75)
//                {
//                    Console.WriteLine("Pass with A Grade");
//                }

//                else if(per>=60)
//                {
//                    Console.WriteLine("Pass With B Grade");
//                }

//                else if(per>=50)
//                {
//                    Console.WriteLine("Pass with C Grade");
//                }

//                else
//                {
//                    Console.WriteLine("Pass with D Grade");
//                }
//            }

//            else
//            {
//                Console.WriteLine("Fail");
//            }
//        }
//    }
//}


//10.Shipping charge calculation based on deleivery distance
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int dist;
//            Console.WriteLine("Enter a Distance");
//            dist = int.Parse(Console.ReadLine());

//            if (dist <= 5)
//            {
//                Console.WriteLine("Shipping charges is 30$");
//            }

//            else if (dist >= 6 && dist <= 10)
//            {
//                Console.WriteLine("Shipping charges is 50$");
//            }
//            else if (dist >= 11 && dist <= 20)
//            {
//                Console.WriteLine("Shipping charges is 80$");
//            }

//            else
//            {
//                Console.WriteLine("Shipping charges is 120$");
//            }
//        }
//    }
//}


//MENU BASIC SCENARIOS
//11.ATM Menu: 1.Balnce 2.Withdraw 3.Deposite 4.Exit Using Switch Case

//12.Restaurant menu selection using item number.
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int menu;

//            Console.WriteLine("-----Reastaurent Menu------");
//            Console.WriteLine("1. Veg Burger -Rs.120\n 2.Pizza -Rs.250\n 3.pasta -Rs.180\n 4.Sandwich -Rs100\n 5.Exit\n");

//            Console.WriteLine("The Number is:");
//            menu=int.Parse(Console.ReadLine());

//            switch(menu)
//            {
//                case 1:
//                    Console.WriteLine("You selected the veg Burgrr");
//                    Console.WriteLine("The price is:120Rs");
//                    break;

//                case 2:
//                    Console.WriteLine("You selected the Pizza");
//                    Console.WriteLine("The price is:250Rs");
//                    break;

//                case 3:
//                    Console.WriteLine("You selected the pasta");
//                    Console.WriteLine("The price is:180Rs");
//                    break;

//                case 4:
//                    Console.WriteLine("You selected the Sandwich");
//                    Console.WriteLine("The price is:100Rs");
//                    break;


//                case 5:
//                    Console.WriteLine("Thank you! Visit Again");
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;


//            }

//        }
//}
//}


//13.Calculator menu using switch
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int choice;
//            int num1,num2;


//            Console.WriteLine("----Calculator Menu------");
//            Console.WriteLine("1.addtion\n 2.Substraction\n 3.Multiplication\n 4.Division\n 5.Modulud\n 6.Exit\n");
//            choice=int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter a Num1");
//            num1=int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter a Num2");
//            num2=int.Parse(Console.ReadLine());

//            switch(choice)

//            {
//                case 1:
//                    Console.WriteLine("The addition is :" + (num1 + num2));
//                    break;

//                case 2:
//                    Console.WriteLine("The Subtraction is :" + (num1 - num2));
//                    break;

//                case 3:
//                    Console.WriteLine("The Multiplication is :" + (num1 * num2));
//                    break;

//                case 4:
//                    Console.WriteLine("The add is :" + (num1 / num2));
//                    break;

//                case 5:
//                    Console.WriteLine("The add is :" + (num1 % num2));
//                    break;

//                case 6:
//                    Console.WriteLine("Thnak You! visit again");
//                    break;

//                default:
//                    Console.WriteLine("Invalid Choice:");
//                    break;


//            }

//        }
//    }
//}


//14.Language selection

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int langChoice;

//            Console.WriteLine("----Language Selection-----");
//            Console.WriteLine("1.English\n 2.Hindi\n 3.Marathi\n 4.Exit\n");

//            Console.WriteLine("Lanuage number wich you want");
//            langChoice = int.Parse(Console.ReadLine());

//            switch (langChoice)
//            {
//                case 1:
//                    Console.WriteLine("You select the English Language");
//                    break;

//                case 2:
//                    Console.WriteLine("You select the Hindi Language(आपने हिंदी चुनी है)");
//                    break;

//                case 3:
//                    Console.WriteLine("You select the Marathi Language(तुम्ही मराठी निवडली आहे)");
//                    break;

//                default:
//                    Console.WriteLine("Invliad choice:");
//                    break;
//            }
//        }
//    }
//}


//15.Role Based Access.- Admin\USer\Guest

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int choice;

//            Console.WriteLine("--Enter Your ROLE--");
//            Console.WriteLine("1.Admin\n 2.User\n 3.Guest\n");

//            Console.WriteLine("Enter Your choice:");
//            choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("You are Admin");
//                    Console.WriteLine("Permission:Add, Edit, Delete, View");
//                    break;

//                case 2:
//                    Console.WriteLine("You are User");
//                    Console.WriteLine("Permission:Edit, View");
//                    break;

//                case 3:
//                    Console.WriteLine("You are Guest");
//                    Console.WriteLine("Permission:View Only");
//                    break;

//                default:
//                    Console.WriteLine("Invalid Choice");
//                    break;

//            }
//        }
//    }
//}

//SHORT LOGIC SCENARIOS (TERNARY)

//16.User is Active or Inactive

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int status;
//            Console.WriteLine("Enter User status(active=1 or inactive=0)");
//            status=int.Parse(Console.ReadLine());

//            string result =
//                (status == 1) ? "User is Active" : "User is Inactive";

//            Console.WriteLine(result);
//        }
//    }
//}

////17.Display result based on attendence percent

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            double attendence;
//            Console.WriteLine("Enter attendence percent:");
//            attendence=double.Parse(Console.ReadLine());

//            string result =
//                (attendence >= 75) ? "Eligible for Exam" :
//                (attendence >= 60) ? "Allowed with warnimg" :
//                "Not Eligible";

//            Console.WriteLine(result);
//        }
//    }
//}

//18.Chekc staok Availability

//Using System.Diagnostics.SymbolStore;

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int stock;
//            Console.WriteLine("Enter a Stock in Number:");
//            stock=int.Parse(Console.ReadLine());

//            string result=
//                (stock>0)?"In Stock":
//                (stock==0)?"Out Of stock":
//                "Invalid stock";

//            Console.WriteLine(result);
//        }
//    }
//}

//19.Display success or Error Message

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int msg;
//            Console.WriteLine("Enter a Status(succesful=1 or error=0");
//            msg=int.Parse(Console.ReadLine());

//            string result =
//                (msg == 1) ? "Sucess" : "404 Error";

//            Console.WriteLine(result);

//        }
//    }
//}

//20.Password is Valid or Not

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string password;

//            Console.WriteLine("Enter a Password");
//            password = Console.ReadLine(); //Password is already String

//            string result =
//                (password.Length >= 8) ? "Password is Valid" : "Invalid Password";
//            Console.WriteLine(result);

//        }
//    }
//}

//ADVANCED SWITCH SCENARIOS

//21.Return discount percentage based on purchase amount

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int amount;
//            Console.WriteLine("Enter a Amount:");
//            amount=int.Parse(Console.ReadLine());

//            int discount = amount switch
//            {
//                >= 10000 => 20,
//                >= 5000 => 10,
//                >= 2000 => 5,
//                _=>0,
//            };
//            Console.WriteLine(discount);

//        }
//    }
//}



//23.Return USer Message Based On Role

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args) 
//            {
//            string role;
//            Console.WriteLine("Enter you Role:");
//            role = Console.ReadLine();

//            string result = role switch
//            {
//                "Admin" => "Welcome teacher, manage course",
//                "Student" => "Welcome Student, Acces your dashboard",
//                _ => "Invalid Role",
//            };
//            Console.WriteLine(result);
//            }
//    }
//}


//24.Return grade based on marks
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args) 
//            {
//            int marks;
//            Console.WriteLine("Enter a MArks:");
//            marks=int.Parse(Console.ReadLine());

//            string result = marks switch
//            {
//                >= 80 => "Pass with A Grade",
//                >= 75 => "Pass with B Grade",
//                >= 60 => "Pass woth C Grade",
//                >= 35 => "Pass with D Grade",
//                _=>"Fail",

//            };
//            Console.WriteLine(result);
//            }
//    }
//}

//25.Return salary bonus based on perfermonace rating

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int salary, bonus = 0;
//            char performance;

//            Console.WriteLine("Enter a Salary:");
//            salary=int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter a Performance:");
//            //performance=char.Parse(Console.ReadLine());
//            performance = Console.ReadLine().Trim()[0];


//            string result = performance switch
//            {
//                'E' or 'e' => $"Bonus = {bonus = salary * 20 / 100}",
//                'G' or 'g' => $"Bonus = {bonus = salary * 10 / 100}",
//                'A' or 'a' => $"Bonus = {bonus = salary * 5 / 100}",
//               _ => "No Bonus"  
//            };
//            Console.WriteLine(result);
//        }
//    }
//}


//Sum of Even number using for Loop
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n, sum = 0;

//            Console.WriteLine("Enter Number");
//            n = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 2 == 0)
//                    sum += i;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}


//WAP to print the fibonacci number
//namespace Demo171
//{
//    public class Program
//{
//    public static void Main(string[] args)
//    {
//        int a = 0, b = 1, n = 20,c;
//        Console.WriteLine($"{a}\n ,{b}\n");

//        for (int i = 3; i < n; i++)
//        {
//            c = a + b;
//            Console.WriteLine($"{c}");
//            a = b;
//            b = c;
//        }
//    }
//}
//}


//WAP to print a to z using for loop

//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            char c;

//            for (char i = 'a'; i < 'z'; i++)
//            {
//               Console.WriteLine("\n" +i); 
//            }
//        }
//    }
//}

//WAP to print the prime Number using For-Loop

//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Enter a Number");
//            n=int.Parse(Console.ReadLine());

//            Console.WriteLine("Prime Numbers are:");

//            for(int i=2;i<=n; i++)
//            {
//                int count = 0;

//                for(int j=1;j<=i;j++)
//                {
//                    if(i%j ==0)
//                    {
//                        count++;
//                    }
//                }
//                if(count==2)
//                {
//                    Console.WriteLine(i + " ");
//                }
//            }
//        }
//    }
//}

//FUNCTION OR METHOD CALL BY VALUE

/*namespace Demo171
{
    class Program
    {
        public static int GetCube(int num)
            {
            int res = num * num * num;
            return res; 
            }
        public static void Main(string[] args)
        {
            int a = 10;

            int result= Program.GetCube(a);
            Console.WriteLine("Square = " + result);
        }
    }
}*/


/*namespace Demo171
{
    class Program
    {
        public static int GetAdd(int a,int b,int c)
        {
            int res =a + b + c;
            return res;
        }

        public static void Main(String[] args)
        {
            int a = 10, b = 20, c = 30;

            int result = Program.GetAdd(a, b, c);
            Console.WriteLine("Addtion ="+ result);
        }
    }
}*/


//namespace Demo171
//{
//    class Program
//    {
//        public static int GetCube(int num)
//        {
//            int res = num * num * num;
//            return res;
//        }
//        public static void Main(string[] args)
//        {
//            int a = 10,b=20,c=30;

//            //int result = Program.GetCube(a);
//            //Console.WriteLine("Square = " + result);
//            Console.WriteLine("Cube of a = " + GetCube(a));
//            Console.WriteLine("Cube of b = " + GetCube(b));
//            Console.WriteLine("Cube of c = " + GetCube(c));
//        }
//    }
//}

//-----------FUNCTION OR METHOD-----------
/*namespace Demo171
{
    class program
    {
        public static void Main(string[] args)
        {*/
//1.Max Number
/*int a = 1, b = 6, c = 3;
int res = MathHelper.GetAddition(a, b, c);
Console.WriteLine("The max number is is =>" + res);*/


//2.Addtion Upto nth number
/*int n = 6;
int res = MathHelper.sumNum(n);
Console.WriteLine("The addition is=>"+res);*/


//3.145 is a Strong number
/*int n = 145;
int res = MathHelper.fact(n);
Console.WriteLine("it is a Strong number:"+res);*/

//4.even or odd
/*int n = 6;
string res = MathHelper.EvenOdd(n);
Console.WriteLine(res);*/

//5.Positive and Negative
/*int n = 2;
String res=MathHelper.PosNeg(n);
Console.WriteLine(res);*/

//6.The Year is a Leap or Not
/*int n = 2020;
String res = MathHelper.leap(n);
Console.WriteLine(res);*/

//7.The Ch is Vowel or Constant   //Issues
/*char ch = 'a';
Char res = MathHelper.Vowel(ch);
Console.WriteLine(res);*/

//8.Eligible for vote or not
/*int n = 12;
string res = MathHelper.Vote(n);
Console.WriteLine(res);*/

//9.Divisible by 5 and 11
/*int n = 55;
String res = MathHelper.divisible(n);
Console.WriteLine(res);*/

//10.Three Digit or Not
/*int n = 9;
int res=MathHelper.digit(n); 
Console.WriteLine(res);*/

//11.Senoir Citizen or not
/*int n = 55;
String res=MathHelper.citizen(n);
Console.WriteLine(res);*/

//12.UpperCase or LowerCase  //Issues
/*char c= 'A';
bool res=MathHelper.UpperLower(c);
Console.WriteLine(res);*/

//13.
/*}
}
}*/

//------PASS BY VALUE [Function]------





//------PASS BY REFERENCE [Function]------
/*namespace Demo171
{
    public class Program
    {
        public static int swap(ref int n1, ref int n2, out int sub)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine($"After swapping: n1={n1}, n2={n2}");
            sub = n1 - n2;
            return n1 + n2;
                }

        public static void Main( string[] args )
        {
            int a = 10, b = 20;
            int add=swap(ref a, ref b, out a);

        }
    }
}*/


//-----PREDICATE-----

/*namespace Demo171
{
    public static void Prime(int n)
    {
        String res=MathHelper.PrimeNo()
            Console.Write(res);

    }
    public static void Main( string[] args )
    {
        Predicate<int> check = PrimeNo;
        Console.WriteLine($"The Number is:{check(2)}");
    }
}*/

//.Class madhil example

/*using System;
namespace Demo171
{
    delegate void demo(string name);

    class Program
    {
        public static void saybyy(string name = "Mahi")
        {
            Console.WriteLine($"Byy {name}");
        }

        public static void Sayhello(string name = "iman")
        {
            Console.WriteLine($"Hello {name}");
        }

        public static bool CheckEvenOrOdd(int n = 5)
        {

            return n % 2 == 0;
        }

        public static void Main(string[] args)
        {
            demo cal = new demo(saybyy);
            cal("Pooja");

            bool res = CheckEvenOrOdd(10);
            Console.WriteLine(res);
        }
    }
}*/

//-------EXERSIZE-------
//1.Define a custom delegate that takes two integers and returns their difference. Write code to use it.

/*using System;

namespace Demo171
{

    public class Program
    {
        //Function declare
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        //Delegate delcare
        delegate void operation(int x, int y);

        //Main Method
        public static void Main(string[] args)
        {
            operation calc = new operation(sub);

            calc(40, 20);
        }

    }
}*/

//using System;

//namespace Demo171
//{

//    delegate void operation(int x, int y);

//    class program
//    {
//        public static void sub(int a, int b)
//        {
//            Console.WriteLine(a - b);
//        }
//        public static void Main(string[] args)
//        {
//            operation calc = new operation(sub);

//            calc(40, 20);
//        }

//    }
//}


//2.Create a method Calculate that accepts a delegate and two integers, then executes the delegate.
/*using System;
namespace Demo171
{
    delegate int Operation(int x, int y);
     class program
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


//3.Write a program where a delegate is used to switch between addition, subtraction, multiplication, and division dynamically.

/*using System;
namespace Demo171
{
    //delegate delcare
    delegate int operation(int x, int y);

    public class program
    {
        //Function declare
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;

        }

        public static int mul(int a, int b)
        {
            return a * b;

        }

        public static int div(int a, int b)
        {
            return a / b;

        }


        public static void Main(string[] args)
        {
            operation op;

            Console.WriteLine("Chhoose operation : + - * /");
            char choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '+':
                    op = add;
                    break;

                case '-':
                    op = sub;
                    break;

                case '*':
                    op = mul;
                    break;

                case '/':
                    op = div;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            int result = op(20, 10);
            Console.WriteLine("Result ="+result);
        }
    }
}*/

//4.Implement a delegate to handle string operations (e.g., uppercase, lowercase, reverse). 

/*using System;

namespace Demo171
{
    //delegate declare
    delegate char stringOpration(string input);

    class program
    {
        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string ToLowerCase(string text)
        {
            return text.ToLower();
        }

        public static string ResverseString(string text)
        {
            char[] chars = text.ToCharAraay();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static void Main(string[] args)
        {
            stringOpration op;

            Console.WriteLine("Choose Operation: upper/lower/reverse");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter a String:");
            string input = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "upper":
                    op = ToUpperCase;
                    break;

                case "lower":
                    op = ToLowerCase;
                    break;

                case "reverse":
                    op = ReverseString;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            string result = op(input);
            Console.WriteLine("Result:" + result);
        }
    }
}*/

//5. Use a Func<int, int, int> to implement multiplication.

//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<int, int, int> multiply = (a, b) => a*b;
//            int result = multiply(4, 5);
//            Console.WriteLine(result);
//        }
//    }
//}

//6.Write a Func<string, int> that returns the length of a string.
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<string,int>getLength=s=>s.Length;
//            int result = getLength("Hello world");
//            Console.WriteLine(result);
//        }
//    }
//}

//7.Use a Func<int, bool> to check if a number is prime.
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<int, bool> isPrime = n =>
//            {
//                if (n <= 1)
//                    return false;

//                for (int i = 2; i <= Math.Sqrt(n); i++)
//                {
//                    if (n % i == 0)
//                        return false;
//                }
//                return true;
//            };
//            Console.WriteLine(isPrime(7));
//            Console.WriteLine(isPrime(8));
//        }
//    }
//}

//8. Apply a Func<string, string> to transform a list of names into uppercase    --issue--
/*using System;
using System.Collections.Generic;
using System.Linq;
namespace Demo171
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List of names
            List<string> names = new List<string>
            {
                "Pooja",
                "Pragati",
                "Ankita",
                "Rohini"
            };

            //Func to convert string to upeercase
            Func<string, string> uppercase = name => name.ToUpper();

            //Apply func using LINQ                
            List<string> upperNames = names.Select(toUpperCase).ToList();

            //Print result
            foreach (var name in upperNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}*/



//9.Create an Action<string> that prints a message to the console.
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Action<string> printMessage = Message =>
//            {
//                Console.WriteLine(Message);
//            };
//            printMessage("Hello! this is Action Delegate");
//        }
//    }
//}


//10. Write an Action<int> that prints whether a number is positive, negative, or zero.
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Action<int> CheckNumber = n =>
//            {
//                if (n > 0)
//                {
//                    Console.WriteLine("The number is Positve");
//                }
//                else if (n < 0)
//                {
//                    Console.WriteLine("The number is Negative");
//                }
//                else
//                {
//                    Console.WriteLine("number is Zero");
//                }
//            };

//                CheckNumber(10);
//                CheckNumber(-6);
//                CheckNumber(009);

//        }
//    }
//}

//11.Use an Action<string, int> to display a name and age together.

/*using System;
namespace Demo171
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Action wiht two parameters
            Action<string, int> displayPerson = (name, age) =>
            {
                Console.WriteLine($"Name:{name},Age: {age}");
            };

            //Calling Action
            displayPerson("Pooja", 21);
            displayPerson("Pragati", 22);
        }
    }
}*/

//12.Chain multiple Action delegates to log a message and then print its length.
/*using System;
namespace Demo171
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string> logMessage = msg =>
            {
                Console.WriteLine(msg);
            };

            Action<string> printLength = msg =>
            {
                Console.WriteLine("lenght: "+msg.Length); 
            };

            //Chain the Actions
            Action<string> CombinedAction = logMessage + printLength;

            //Execute chained action
            CombinedAction("Hello wrold");
        }
    }
}*/

//13.Write a predicate<int> that checks if a number is even
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Predicate<int> isEven = n => n % 2 == 0;

//            Console.WriteLine(isEven(10));
//            Console.WriteLine(isEven(7));
//        }
//    }
//}

//14.Use a Preidcate <string> to check if a string starts with the letter "A"
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Predicate<string> StartsWithA = s => s.StartsWith("A");

//            Console.WriteLine(StartsWithA("Apple"));
//            Console.WriteLine(StartsWithA("Kiwi"));

//        }
//    }
//}

////15.Create a predicate <person> to check if a person is older than 18
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            //            Predicate<int> isEven = n => n % 2 == 0;
//            Predicate<int> isOlder = n => n >= 18;
//            Console.WriteLine($"The person is older or not\n" +isOlder(18));
//        }
//    }
//}
//-------ARRAY-------
//Normal Array Writting--
//using System;
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 10, 20, 30, 40, 50 };
//            Console.WriteLine(arr[0]);
//        }
//    }

//}

//Another way writing array with array length--
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] cars = new string[5] { "BMW", "FORD", "BUGATI", "MARUTI", "SUZUKI" };
//            //Console.WriteLine(cars.Length);
//            Console.WriteLine(cars[4]);
//        }
//    }
//}

//array with for loop--
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] cars = { "BMW", "FORD", "BUGATI", "MARUTI", "SUZUKI" };
//            for(int i=0;i<cars.Length;i++)
//            {
//                Console.WriteLine(cars[i]);
//            }
//        }
//    }
//}

//array with for each loop--
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] cars = new string[5] { "BMW", "FORD", "BUGATI", "MARUTI", "SUZUKI" };
//            foreach(string x in cars)
//                {
//                Console.WriteLine(x);
//            }
//        }
//    }
//}


//Array with sorting

//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] num = new int[5] { 1, 2, 3, 4, 5 };
//            Array.Sort(num);

//            foreach(int i in num)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//linq
//using System;
//namespace Demo171
//{
//    public class program
//    {
//        public static void Main(string[] args)
//        {
//            string[] city = new string[4] { "Solapur", "pune", "Kop", "Mumbai" };
//            Console.WriteLine(city.Max());
//        }
//    }
//}


//------Generic Method------
//{
//    public class Display<T>
//    {
//        public static void Show(T [] arr)
//        {
//            for(int i=0;i<arr.Length;i++)
//            {
//                Console.Write($"{arr[i]}  ");
//            }
//        }
//    }
//    public class Program
//    {
//        public static void Main(String[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };
//            string[] names = { "Maithili", "Pooja", "Gayatri", "Snehal" };
//            double[] salary = { 56000.3, 80000.456, 567678.67 };
//            Console.WriteLine("\n This is int array call by using generic method :");
//            Display< int >.Show(arr);
//            Console.WriteLine("\n This is string array call by using generic method :");
//            Display<string>.Show(names);
//            Console.WriteLine("\n  This is Double array call by using generic method :");
//            Display<double>.Show(salary);
//        }
//    }

//
//    public class Program
//    {
//        public static void Show(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    Console.Write($"{arr[i]}  ");
//                }
//            }
//        }
//        public static void Main(String[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 35 };

//            Console.WriteLine("\n This is int array call by using generic method :");
//            Show(arr);

//        }


//    }
//}


//using System;
//namespace Demo171
//{
//	public class Display<T>
//{
//    public static void Show(T[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}

//    public class Program
//    {
//        public static void Main(String[] args)
//        {
//            int[] arr = { 4, 5, 7, 2, 45 };
//            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
//            Display<int>.Show(arr);

//            double[] num = { 76543, 23456, 9876543, 2356 };
//            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
//            Display<double>.Show(num);

//            double[] marks = { 56.7, 222.4, 89.7, 65.3 };
//            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
//            Display<double>.Show(marks);
//        }
//    }
//}

//using System;

//namespace Demo171
//{
//    public class Program
//    {
//        static void Swap<T>(ref T a, ref T b)
//        {
//            T temp = a;
//            a = b;
//            b = temp;
//        }
//        public static void main(string[] args)
//        {

//            int x = 10, y = 20;
//            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
//            Swap<int>(ref x, ref y);
//            Console.WriteLine($"After Swap: x = {x}, y = {y}");
//        }
//    }
//}

//using System;
//namespace Demo171
//{
//    public class Display<T>
//    {
//        public static void Show(T[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] age = { 1, 2, 3, 4, 5, 6, 7, 8 };
//            Display<int>.Show(age);
//        }
//    }
//}   


//return ssme value

//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void Show<T>(T[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//                Console.WriteLine(arr[i]);
//        }

//        public static void Main(String[] args)
//        {
//            int[] age = { 22, 45, 34, 76, 77 };
//            Console.WriteLine("+++The age is +++");
//            Show(age);
//        }
//    }
//}

//Return the Same value  ---Issues---

//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static T GetValue<T>(T[] value)
//        {
//            return value;
//        }

//        public static void Main(String[] args)
//        {
//            int res = GetValue(100);
//            Console.WriteLine(res);
//        }
//    }
//}


//Swap two Values 
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void swap<T>(ref T a,ref T b)
//        {
//            T item = a;
//            a = b;
//            b = item;
//        }

//        public static void Main(String[] args)
//        {
//            int a = 10, b = 20;
//            Console.WriteLine($"before Swaping x:{a}, y:{b}");

//            swap(ref a, ref b);
//            Console.WriteLine($"After swaping x:{a}, y:{b}");
//        }

//    }
//}

//Create a generic method that compares two values and returns true if they are equal, otherwise false.
//---ISUUES---
//using System;
//namespace Demo171
//{
//    public class Program
//    {
//        public static void show<T>(ref T a, ref T b)
//        {
//            if (a >= b)
//            {
//                Console.WriteLine("A is big");
//            }
//            else
//            {
//                Console.WriteLine("B is big");
//            }
//        }
//    }
//}

/*using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace Demo171
{
    public class display<T>
    {
        public void show(T obj)
        {
            Console.WriteLine(obj);
            //Console.WriteLine(nameof(obj));
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            display<string> ob = new display<string>();
            
            ob.show("hii");
            
        }
    }
}*/


//LINQ
//first

//int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];

//var result = arr.First(n=> n>4);
//Console.WriteLine(result);

//FirstOrDefault

//int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
//var result = arr.FirstOrDefault(n=> n>4);
//Console.WriteLine(result);

//Single
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var result = arr.Single(n => n > 7);
//Console.WriteLine(result);  

//SingOrDefault

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var result = arr.SingleOrDefault(n=> n==2);
//Console.WriteLine(result);

//last
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var result = arr.Last(n => n > 4);
//Console.WriteLine(result);

//lastOrDefault
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var result = arr.LastOrDefault(n => n > 2 );
//Console.WriteLine($"SingleOrDefault with no match : {result}");


//Where
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var result = arr.Where(n => n > 4);

//foreach(var items in result)
//{
//    Console.WriteLine(items);
//}


//where using querySyntax
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//var querySyntax = (from n in arr where n>4 select n).ToList();

//foreach(var items in querySyntax)
//{
//    Console.WriteLine(items);
//}

//orderby()

//int[] data = { 345, 87, 45, 221, 34556, 788, 54, 1 };

//Console.WriteLine("Data before sort");

//foreach (var items in data)
//{
//    Console.WriteLine(items);
//}

//Console.WriteLine("Data after sort");

//var res = data.OrderBy(n => n);

//foreach(var items in res)
//{
//    Console.WriteLine(items);
//}

//OrderByDecending

//int[] data = { 13, 233, 389, 84, 55, 36, 74, 855, 96 };
//var res = data.OrderByDescending(n => n);

////using query syntax
//var ress = (from n in data orderby n descending select n ).ToList();


//foreach(var i in ress)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("After");


//ofType
//List <object> data= new List<object>() {"John",22,13,"Bhim","Johny",56,"Bob",76,29};
//var result=data.OfType<int>().ToList();


//----------HOMEWORK-----------
//1. Create an integer array of 10 elements and print all elements.

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8,9, 10 };

//for(int i=0; i<arr.Length;i++)
//{
//    Console.WriteLine(arr[i]);
//}


//2. Find the sum of all elements in an integer array.
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int sum = 0;

//for(int i=0;i<arr.Length;i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);

//3.Find the maximum and minimum value from an array.

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int max = arr.Max();
//int min = arr.Min();

//Console.WriteLine("the max value is"+ max);
//Console.WriteLine("the min value is"+ min);

//4.Count how many even and odd numbers are present in an array.

//using System.Linq;
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int evenNO = arr.Count(n => n % 2 == 0);
//Console.WriteLine($"the even number is:{evenNO}");

//int oddNo = arr.Count(n => n % 2 != 0);
//Console.WriteLine($"the odd number is:{oddNo}");

//5.Reverse an array without using built-in reverse methods.
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] reversed = new int[arr.Length];

//int j = 0;
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    reversed[j] = arr[i];
//    j++;
//}

//foreach (var item in reversed)
//{
//    Console.WriteLine(item);
//}

//6. Sort an array in ascending order.
/*int[] arr3 = { 10, 7, 3, 8, 1, 4, 5, 6, 9, 2 };
var res = arr3.OrderBy(e=>e).ToArray();
foreach(var i in res)
{
    Console.WriteLine(i);
}*/

//7. Search for a given element in an array and print its index.
/*int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int searchElemenet = 2;
int index=Array.IndexOf(arr2, searchElemenet);

if(index !=-1)
{
    Console.WriteLine($"Element is found {index}");
}
else
{
    Console.WriteLine("Element is NOt Found");
}*/


//8. Remove duplicate elements from an array.
/*int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 5, 12, 7, 4, 2, 9, 11};
var res=arr3.Distinct().ToArray();
foreach(var i in res)
{
    Console.WriteLine(i);
}*/


//9. Find the second largest number in an array.
/*int[] arr4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
arr4.Sort((a, b) => b - a);
Console.WriteLine(arr4[1]);*/

//10.Merge two arrays into a single array.

/*using System;
using System.Linq;
namespace Demo171
{
    public class program
    {
        public static void Main(string[] args)
        {
            //10.Merge two arrays into a single array.
            int[] arr5 = { 1, 2, 3, 4, 5, 6 };
            int[] arra6 = {7, 8, 9, 10 };
            int [] mergedArray = arr5.Concat(arra6).ToArray();
            //Console.WriteLine(mergedArray);  *WRONG*
            Console.WriteLine(string.Join(", ", mergedArray));
        
        }
    }
}*/

//11. Use LINQ to find all even numbers from an integer array.
/*int[] arr = { 1, 2, 3, 4, 56, 7, 8, 9, 10 };
var res = arr.Where(n => n % 2 == 0);
foreach(var item in res)
{
    Console.WriteLine(item);
}*/


//12.Use LINQ to find all numbers greater than 50 from an array.
/*int[] arr = { 1, 2, 3, 4, 56, 7, 8, 9, 10 };

var res = arr.Where(n => n > 50);

foreach(int i in res)
{
    Console.WriteLine(i);
}*/

//13.Use LINQ to calculate the sum and average of array elements.
/*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = arr.Sum();
double avg = arr.Average();

Console.WriteLine("The sum is "+sum);
Console.WriteLine("The avg. is "+arr.Average());*/

//14.Find the maximum and minimum value using LINQ.
/*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int max = arr.Max();
int min = arr.Min();

Console.WriteLine("The max Num is "+max);
Console.WriteLine("The min Num is "+min);*/

//15.Sort an array in descending order using LINQ.
/*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] res=arr.OrderByDescending(n=>n).ToArray();

foreach(int i in res)
{
    Console.WriteLine(i);
}*/

//16.Remove duplicate elements using LINQ.
/*int[] arr = { 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10 };

int[]res=arr.Distinct().ToArray();

foreach(int i in res)
{
    Console.WriteLine(i);
}*/

//17.Find the top 3 largest numbers using LINQ.
/*int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 23, 5, 66 };

var top3= arr.OrderByDescending(x => x).Take(3).ToList();  //n=>n sorting the largest to lowest and then take 3 largest number

foreach(var i in top3)
{
    Console.WriteLine(i);
}*/

//18. Count how many elements are greater than the average value.
/*int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 23, 5, 66 };

double avg = arr.Average();
int count = arr.Count(n =>n> avg);

Console.WriteLine("the AVG is:" +avg);
Console.WriteLine("the Count is:" +count);*/

//19. Convert an array of strings into uppercase using LINQ.
/*string[] arr = {"pooja", "maithili" , "pragati"};

var upperNames = arr.Select(n=>n.ToUpper());

foreach(string name in upperNames)
{
    Console.WriteLine(name);
}*/

//20. Group numbers by even and odd using LINQ.
/*int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 23, 5, 66 };

var res = arr.GroupBy(n => n % 2 == 0 ? "Even Numbers" : "Odd NUmbers");

foreach(var group in res)
{ 
    Console.WriteLine(group + " Numbers:");
    foreach(var item in group)
    {
        Console.WriteLine(item); 
    }
}*/

//21. Given an array of integers, use LINQ to find the first number greater than 100. If none exists, return -1.
/*int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 150, 200, 250, 300 };

int result = arr.FirstOrDefault(n => n > 100);

if(result == 0)
{
    result = -1;
}

Console.WriteLine(result);*/

//22.Find all numbers that are divisible by both 3 and 5.
/*int[] arr = { 5, 10, 15, 20, 25, 12, 30, 35, 22 };

var divisble = arr.Where(n => n % 3 == 0 && n % 5 == 0);

foreach(var i in divisble)
{
    Console.WriteLine(i);
}*/

////23. Find the count of prime numbers in an array using LINQ.
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var primeNo = arr.Where(n =>
//{
//    if (n <= 1) return false;
//    for (int i = 2; i <= Math.Sqrt(n); i++)
//        if (n % i == 0) return false;
//    return true;
//}).Count();

//Console.WriteLine(primeNo);

//24.Find the second smallest number using LINQ.
//int[] arr = { 5, 10, 15, 20, 25, 12, 30, 35, 22 };

//var res = arr.OrderBy(n => n).Take(1).ToArray();

//foreach(var item in res)
//{
//    Console.WriteLine("The Sammlest number is: "+item);
//}

//25. Find all distinct characters from a string using LINQ.
/*char[] arr = {'a' , 'b' , 'c' , 'd', 'e', 'a', 'c'};

var res = arr.Distinct();

foreach(char c in res)
{
    Console.WriteLine(c);
}*

//26.Find the longest string in a string array.
/*string[] words = {"Pooja", "Maithili", "Pragati", "Mariya", "Saniya"};

var longestWord= words.OrderByDescending(n=>n.Length).First();
Console.WriteLine(longestWord);*/

//27.Find words that start with a vowel using LINQ. 

/*string[] names = { "pooja", "maithili", "pragati", "gayatri", "sanika", "yogeshwari", "amruta" , "omega" };
var result = names.Where(n => n.First() == 'a' || n.First() == 'e' || n.First() == 'i' || n.First() == 'o' || n.First() == 'u').ToArray();
foreach (var n in result)
{
    Console.Write(n + "  ");
}*/

//28.Check if all elements are positive using LINQ.
/*int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, 10 };

var res = arr.Where(n => n > 0);

foreach (var i in res)
{
    Console.WriteLine(i);
}*/

//29. Check if any number is negative using LINQ.
/*int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, 10 };

var res = arr.Where(n => n < 0);

foreach(var item in res)
{
    Console.WriteLine(item);
}*/

//30. Create a dictionary from an array using LINQ.
/*int[] arr = { 5, 10, 15, 20, 25, 12, 30, 35, 22 };
var dict = arr.ToDictionary(n => n, n => n * n);

foreach (var kvp in dict)
{
    Console.WriteLine(kvp);
}*/

//31.Group numbers by their digit count using LINQ.  --ISSUES--

/*int[] arr = { 5, 10, 15, 20, 25, 12, 30, 35, 22 };

var groups = arr.GroupBy(n => n.ToString().Length);

foreach (var group in groups)
{
    Console.WriteLine($"Numbers with {group} digits:");
    foreach (var num in group)
    {
        Console.WriteLine(num);
    }
}*/