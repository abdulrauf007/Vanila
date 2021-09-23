using System;
using System.Collections.Generic;

namespace TestingApplication
{
    class Program

    {

        //public void CheckNumber(int a)
        //{
        //    int i;
        //    for (i = 2; i <= a - 1; i++)
        //    {
                
        //        if (a % i == 0)
        //        {
                    
        //        }

        //    }

        //    //if (a == 2)
        //    //{
        //    //    Console.WriteLine("Entered Value is Prime & Even");
        //    //}

        //     if (i == a)
        //    {
        //        Console.WriteLine("Entered Value is Prime and Odd");
        //    }


        //    //else if (a % 2 == 0)
        //    //{
        //    //    Console.WriteLine("Entered value is Even");
        //    //}

        //    //else
        //    //{
        //    //    Console.WriteLine("This Value is Odd");
        //    //}
        //}

        public bool checkEvenNumber (int EvenNumber)
        {
            if(EvenNumber % 2 ==0)
            {
                return true;
            }
            return false;

        }

        //public bool checkOddNumber (int oddNumber)
        //{
        //    for(oddNumber 2 ==0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
        public bool CheckPrimeNumber(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
        public string ValueReplace(string str)
        {
            var result = str.Length > 1 ? str.Substring(0, 1) + str.Substring(str.Length - 1) + str.Substring(2, str.Length - 3) + str.Substring(1, 1) : str;
            return result;
        }

        public string FirstLastValueReplace(string vReplace)
        {
            var result = vReplace.Length > 1 ?
            vReplace.Substring(vReplace.Length - 1) + vReplace.Substring(1, vReplace.Length - 2) + vReplace.Substring(0, 1) : vReplace;

            return result;
        }

        public string ThirdnthirdLastValueReplace(string thirdValueReplace)
        {
            var result = thirdValueReplace.Length > 6 ?
            thirdValueReplace.Substring(0, 2) +
            thirdValueReplace.Substring(thirdValueReplace.Length - 3, 1) +
            thirdValueReplace.Substring(3, thirdValueReplace.Length - 3 - 3) +
            thirdValueReplace.Substring(2, 1) +
            thirdValueReplace.Substring(thirdValueReplace.Length - 2, 2) : thirdValueReplace;

            return result;
        }

        public string AddingCharacterFnL(string valueAdd)
        {
            var result =
            valueAdd.Substring(0, 1) + valueAdd +
            valueAdd.Substring(0, 1);

            return result;
        }

        //ethod for Odd Even and Prime Number
        public int OddEvenPrime(int Value)
        {
            int i;

            for (i = 2; i <= Value - 1; i++)
            {
                if (Value % i == 0)
                {
                }
            }

            if (i == Value)
            {
                Console.WriteLine("Entered Value is Prime and Odd Number");
            }
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Value is Even");
            }

            else
            {
                Console.WriteLine("Entered Value is Odd");
            }


            return 0;
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
            //Console.WriteLine("2nd and 2nd Last Value Replace");
            //Console.WriteLine("Enter a string");
            //var result = Console.ReadLine();
            //Program replaceValue = new Program();
            //var vReplace = replaceValue.ValueReplace(result);
            //Console.WriteLine(vReplace);


            //Console.WriteLine("1st and Last Value Replace");
            //Console.WriteLine( "Enter string");
            //var output = Console.ReadLine();
            //Program firstValueReplace = new Program();
            //var Rvalue = firstValueReplace.FirstLastValueReplace(output);
            //Console.WriteLine(Rvalue);

            //Console.WriteLine("3rd and 3rd Last Value Replaced ");
            //Console.WriteLine("Enter String");
            //var outcome = Console.ReadLine();
            //Program thirdValueReplaced = new Program();
            //var thirdValues = thirdValueReplaced.ThirdnthirdLastValueReplace(outcome);
            //Console.WriteLine(thirdValues);

            //Example 17: Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.

            //Console.WriteLine("Enter String");
            //var result = Console.ReadLine();
            //Program addValue = new Program();
            //var ValueAd = addValue.AddingCharacterFnL(result);
            //Console.WriteLine(ValueAd);

            //Example 18: Write a C# program to check two given integers and return true if one is negative and one is positive.

            //Console.WriteLine("Please Enter First Value");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Second Value");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Checking Either Positive and Negative");
            //Console.WriteLine((-1<1 && 2>-1 )||(-2>1 && 2<-1));

            //AND & OR Operators

            // Example 1 OR: In this below condition; if the value1 is equal to value2 then it will print true otherwise it will print false.

            //Console.WriteLine("Enter the Value1");
            //int Value1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the Value1");
            //int Value2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Value1 == Value2 || Value1 >= Value2);

            // Example 2 OR: In this below condition; if the value is equal to other value it will print true, if the value1 is greaterthan value2 then also it will print true, otherwise it will print false.

            //Console.WriteLine("Enter The Number 1");
            //int Number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter The Number 2");
            //int Number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((Number1 == Number2) || (Number1 > Number2));

            //Example 3 AND:

            //Console.WriteLine("Enter you Your Desire Value1");
            //int Val1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter you Your Desire Value2");
            //int Val2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((Val1 < Val2) && (Val1 >= Val2));

            //Eample 4 AND confusion??

            ////Console.WriteLine("Enter the value of X");
            ////int x = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine("Enter the Value of Y");
            ////int y = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine((x == y) && (x <= y));

            //Example 5 AND and OR

            //Console.WriteLine("Are You Pakistani");
            //string Nationality = Console.ReadLine();

            //Console.WriteLine("Are You Muslim");
            //string Religion = Console.ReadLine();
            //if (Nationality == Religion)
            //{
            //    Console.WriteLine("Please Proceed for National ID Card");
            //}

            //if (Nationality != Religion)
            //{
            //    Console.WriteLine("Sorry! You are Not Eligible for ID Cars");
            //}

            ////Example 06 AND and OR

            //Console.WriteLine("Enter Your Age");
            //int YourAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Your Father Age");
            //int FatherAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Your Mother Age");
            //int MotherAge = Convert.ToInt32(Console.ReadLine());

            //if ((YourAge >= 18 && FatherAge >= 25) || (MotherAge >= 20))
            //{
            //    Console.WriteLine("Congratulation!! You are Eligible for National ID Card");
            //}

            //if ((YourAge < 18) && (FatherAge < 25) && (MotherAge < 20))
            //{
            //    Console.WriteLine("Sorry!! Your are Not Eligible for National Id Card");
            //}

            //IF Eles, Else If. Check Prime Number

            //Program pro = new Program();
            //var value = Convert.ToInt32(Console.ReadLine());
            //var result = pro.CheckPrimeNumber(value);
            //Console.WriteLine(result);

            // Check odd or even

            //Console.WriteLine("Enter Your Value");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result = a % 2;

            //if(result==0)
            //{
            //    Console.WriteLine("Entered Value is Even");
            //}

            //else
            //{
            //    Console.WriteLine("Entered Value is Odd");
            //}


            //Object 0dd even and Prime

            //Console.WriteLine("Enter Your Value");
            //var EnteredValue = Convert.ToInt32(Console.ReadLine());


            //Program PrimeNumber = new Program();
            //var result = PrimeNumber.OddEvenPrime(EnteredValue);

            // Another Try

            //    Console.WriteLine(" Enter Your Value");
            //    var a = Convert.ToInt32(Console.ReadLine());


            //    Program p = new Program();

            //    var isPrime = p.CheckPrimeNumber(a);
            //    if (a == 2)
            //    {
            //        Console.WriteLine("Prime and Event");
            //    }



            //    else if (isPrime)
            //    {
            //        Console.WriteLine("Yes this number is prime and odd");
            //    }

            //    else if (a % 2 == 0)
            //    {
            //        Console.WriteLine("Entered Value is Even Number");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Entered Value is Odd Number");
            //    }

            // ANOTHER FOR ODD EVEN PRIME
            //Console.WriteLine("enter Your Value");
            //var b = Convert.ToInt32(Console.ReadLine());
            //Program ValueCheck = new Program();
            //var isPrime = ValueCheck.CheckPrimeNumber(b);
            //ValueCheck.CheckNumber(b);

            Console.WriteLine("Enter Your Value");
            var Value = Convert.ToInt32(Console.ReadLine());

            Program CheckValue = new Program();
            var IsPrime = CheckValue.CheckPrimeNumber(Value);
            var IsEven = CheckValue.checkEvenNumber(Value);
            if (Value ==2)
            {
                Console.WriteLine("Eneter Value is Prime Number and Even Number");
            }
            else if (IsPrime)
            {
                Console.WriteLine("This is Prime Number and Odd Number ");
            }
            else if(IsEven)
            {
                Console.WriteLine("This Value is Even");

            }

            else
            {
                Console.WriteLine("Entered Value is odd");
            }
            
        }
    }
}

