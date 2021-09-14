using System;
using System.Collections.Generic;

namespace TestingApplication
{
    class Program
    {

        public string ValueReplace(string str)
        {
           var result =  str.Length > 1 ? str.Substring(0, 1) + str.Substring(str.Length - 1) + str.Substring(2, str.Length - 3) + str.Substring(1, 1) : str;
            return result;
        }

        public string FirstLastValueReplace (string vReplace)
        {
            var result = vReplace.Length > 1 ?
            vReplace.Substring(vReplace.Length - 1) + vReplace.Substring(1, vReplace.Length - 2) + vReplace.Substring(0, 1) : vReplace;

            return result;
        }
        static void Main(string[] args)
        {

            //UserInform
            //ation userInfo = new UserInformation();
            //var Infouser = userInfo.AddUser(new Users 
            //{
            //    Id = 01,
            //  Name = "John",
            //  FatherName = "Mark",
            //  Address = "USA",
            //});

            //var GetInfo = userInfo.GetAllUSerInfo(new List<Users>
            //{ 
            //    new Users
            //    {
            //        Id = 01,
            //        Name = "Maxwell",
            //        FatherName = "Jackson",
            //        Address = "USA"
            //    },
            //     new Users
            //     {
            //         Id = 02,
            //         Name = "Nelson",
            //         FatherName = "Cerk",
            //         Address = "USA"
            //     }

            //});

            //for (int i = 0; i < GetInfo.Count; i++)
            //{
            //    Console.WriteLine("Id:{0}, Name:{1}, Father Name: {2}, Addres: {3}", GetInfo[i].Id,
            //        GetInfo[i].Name, GetInfo[i].FatherName, GetInfo[i].Address);
            //}

            //// example 1 : Write a C# Sharp program to print Hello and your name in a separate line. 

            //Console.WriteLine("Hello World");
            //Console.WriteLine("My Name Is Abdul Rauf Siddiqui");

            //// Example 2: Write a C# Sharp program to print the sum of two numbers

            //Console.WriteLine(2+1);

            ////Example 3 : Write a C# Sharp program to print the result of dividing two numbers

            //Console.WriteLine(8/2);

            ////Example 4 : Write a C# Sharp program to print the result of the specified operations.

            //Console.WriteLine(-1+4*3);
            //Console.WriteLine((3+4)*10);
            //Console.WriteLine((3-2)*(34+2));
            //Console.WriteLine(14+-3*5+2);
            //Console.WriteLine(33-3/332);

            ////Example 5: Write a C# Sharp program to swap two numbers. First Method

            ////var FirstNumbr = Console.ReadLine();
            ////var SecondNumber  = Console.ReadLine();

            ////Console.WriteLine("First Number"+SecondNumber);
            ////Console.WriteLine("Second Number"+FirstNumbr);

            ////Example 5: Write a C# Sharp program to swap two numbers. second Method

            //int num1, num2, temp;

            //Console.WriteLine("Enter First Number");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second Number");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //temp  = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine("First Number Is: "+ num1);
            //Console.WriteLine("Second Number Is:" +num2);


            //Example 6 Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

            //int value1, value2, value3;

            //Console.WriteLine("Please Enter First Number");
            //value1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Second Number");
            //value2 =Convert.ToInt32  (Console.ReadLine());

            //Console.WriteLine("Please Enter Third Number");
            //value3 =Convert.ToInt32 (Console.ReadLine());

            //var result = value1 * value2 * value3;

            //Console.WriteLine( "Result : {0}X{1}X{2}={3}", value1, value2, value3 , result);

            //Example 7 : Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.

            //int val1, val2;

            //Console.WriteLine("Please Enter First Value");
            //val1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Second Value");
            //val2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Add: {0} + {1} = {2}",val1,val2 , val1+val2);
            //Console.WriteLine("Subtract: {0} - {1} = {2}", val1, val2, val1 - val2);
            //Console.WriteLine("Multiply: {0} * {1} = {2}", val1, val2, val1 * val2);
            //Console.WriteLine("Division: {0} ? {1} = {2}", val1, val2, val1/ val2);

            // Example 8: Write a C# Sharp program that takes a number as input and print its multiplication table.

            //int vol;
            //int result;

            //Console.WriteLine("Enter Your Value");
            //vol = Convert.ToInt32(Console.ReadLine());

            //result = 1 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol,1,result);

            //result = 2 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 2, result);

            //result = 3 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 3, result);

            //result = 4 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 4, result);

            //result = 5 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 5, result);

            //result = 6 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 6, result);

            //result = 7 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 7, result);

            //result = 8 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 8, result);

            //result = 9 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 9, result);

            //result = 10 * vol;
            //Console.WriteLine("{0} x {1} ={2}", vol, 10, result);

            // Example 09 Write a C# Sharp program that takes four numbers as input to calculate and print the average

            //int a, b, c, d;
            //int result;

            //Console.WriteLine("Please Enter the First Value");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter the Second Value");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter the Third Value");
            //c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter the Fourth Value");
            //d = Convert.ToInt32(Console.ReadLine());

            //result = (a + b + c + d) / 4;

            //Console.WriteLine( "Average Vlaue : {0},{1},{2},{3}={4}",a,b,c,d,result);


            // Example 10 Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z

            //int x, y, z;

            //int result1;
            //int result2;

            //Console.WriteLine("Please Enter The Value of X");
            //x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter The Value of Y");
            //y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter The Value of Z");
            //z = Convert.ToInt32(Console.ReadLine());

            //result1 = (x + y) * z;
            //result2 = x * y + y * z;

            //Console.WriteLine(" (x + y) * z: X={0},Y={1},Z{2}={3}", x,y,z,result1);
            //Console.WriteLine("(x * y)+(y * z): X={0},Y={1},Z={2}={3}", x, y, z, result2);

            //Example 11  Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"

            //int a;


            //Console.WriteLine("Enter Your Age");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("You Look Older than{0}", a);

            //Example 12  Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}

            //int a;

            //Console.WriteLine("Enter The Value");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} {0} {0} {0}",a);
            //Console.WriteLine("{0}{0}{0}{0}",a);

            //Example 13 Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

            //int a;
            //int result1;
            //int result2;

            //Console.WriteLine("Enter the Value");
            //a = Convert.ToInt32(Console.ReadLine());

            //result1 = (9 / 5 * a) + 32;
            //result2 = (5 /9) *(a - 32);
            //Console.WriteLine("value: {0}",result1);
            //Console.WriteLine("value: {0}", result2);

            // Example 14 Write a C# program remove specified a character from a non-empty string using index of a character

            //Console.WriteLine("Enter the Starting Position");
            //var a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the Number of Length");
            //var b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the String");
            //var input = (Console.ReadLine());

            //Program Ctr = new Program();
            //var ip = Ctr.remove(a, b, input);

            //Console.WriteLine(ip);

            // Example 16  Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor
            Console.WriteLine("2nd and 2nd Last Value Replace");
            Console.WriteLine("Enter a string");
            var result = Console.ReadLine();
            Program replaceValue = new Program();
            var vReplace = replaceValue.ValueReplace(result);
            Console.WriteLine(vReplace);


            Console.WriteLine("1st and Last Value Replace");
            Console.WriteLine( "Enter string");
            var output = Console.ReadLine();
            Program firstValueReplace = new Program();
            var Rvalue = firstValueReplace.FirstLastValueReplace(output);
            Console.WriteLine(Rvalue);

        }


    }
}

