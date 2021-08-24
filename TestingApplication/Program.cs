using System;

namespace TestingApplication
{
    class Program
    {

     
        static void Main(string[] args)
        {
       

            Calculator Cal = new Calculator();
            var addResult = Cal.Add(10, 2);
            var subResult = Cal.Sub(100, 35);
            var mulResult = Cal.Multiplication(23, 6);
            var divResult = Cal.Division(32, 2);


            Console.WriteLine(addResult);
            Console.WriteLine(subResult);
            Console.WriteLine(mulResult);
            Console.WriteLine(divResult);


            Student InfoStd = new Student();
            var showFirstName = InfoStd.FirsttName;
            var showLastName = InfoStd.LastName;
            var showFatherName = InfoStd.FatherName;
            var showCNIC = InfoStd.CNIC;
            var showCell = InfoStd.Cell;
            var showInstitute = InfoStd.Institute;
            var showAddress = InfoStd.Address;

            Console.WriteLine(showFirstName);
            Console.WriteLine(showLastName);
            Console.WriteLine(showFatherName);
            Console.WriteLine(showCNIC);
            Console.WriteLine(showCell);
            Console.WriteLine(showInstitute);
            Console.WriteLine(showAddress);



        }
    }
}

