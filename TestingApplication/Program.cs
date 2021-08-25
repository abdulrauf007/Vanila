using System;

namespace TestingApplication
{
    class Program
    {


        static void Main(string[] args)
        {


            Calculator Cal = new Calculator();
            var addResultInt = Cal.Add(10, 2);
            var addResultDouble = Cal.Add(2.0,3.0);
            var addResultFloat = Cal.Add(32.2f, 31.3f);
            var addResultDecimal = Cal.Add(2.2m, 21.3m);
            var addResultLong = Cal.Add(9223372036854, 111111111111);

            var subResultInt = Cal.Sub(100, 35);
            var subResultDouble = Cal.Sub(10.1, 9.3);
            var subResultFloat = Cal.Sub(10.4f, 93.1f);
            var subResultDecimal = Cal.Sub(10.4m, 93.1m);
            var subResultLong = Cal.Sub(922337203436854, 112221111111);


            var mulResultInt = Cal.Multiplication(23, 6);
            var mulResultDouble = Cal.Multiplication(33.4, 22.4);
            var mulResultFloat = Cal.Multiplication(223f, 6f);
            var mulResultDecimal = Cal.Multiplication(223m, 6m);
            var mulResultLong = Cal.Multiplication(922337203436854, 1123333111111);

            var divResultInt = Cal.Division(32, 2);
            var divResultDouble = Cal.Division(34.2, 2.1);
            var divResultFloat = Cal.Multiplication(223f, 6f);
            var divResultDecimal = Cal.Multiplication(223m, 6m);
            var divResultLong = Cal.Multiplication(922337203436854, 1123333111111);


            Console.WriteLine("Add");
            Console.WriteLine(addResultInt);
            Console.WriteLine(addResultDouble);
            Console.WriteLine(addResultFloat);
            Console.WriteLine(addResultDecimal);
            Console.WriteLine(addResultLong);

            Console.WriteLine("Sub");
            Console.WriteLine(subResultInt);
            Console.WriteLine(subResultDouble);
            Console.WriteLine(subResultFloat);
            Console.WriteLine(subResultDecimal);
            Console.WriteLine(subResultLong);

            Console.WriteLine("Multiplication");
            Console.WriteLine(mulResultInt);
            Console.WriteLine(mulResultDouble);
            Console.WriteLine(mulResultFloat);
            Console.WriteLine(mulResultDecimal);
            Console.WriteLine(mulResultLong);

            Console.WriteLine("Division");
            Console.WriteLine(divResultInt);
            Console.WriteLine(divResultDouble);
            Console.WriteLine(divResultFloat);
            Console.WriteLine(divResultDecimal);
            Console.WriteLine(divResultLong);

         

            Console.WriteLine(" Please Enter Student Information");
            Console.WriteLine("Enter Your First Name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter Your Father Name");
            var fatherName = Console.ReadLine();

            Console.WriteLine("Enter Your CNIC Number");
            var cnic = Console.ReadLine();

            Console.WriteLine("Enter Your Phone Number");
            var cell = Console.ReadLine();

            Console.WriteLine("Enter Your Address");
            var address = Console.ReadLine();

            Console.WriteLine("Enter Your Institiution Name");
            var institute = Console.ReadLine();

            Student infoStd = new Student
            {
                FirsttName = firstName,
                LastName = lastName,
                FatherName = fatherName,
                CNIC = cnic,
                Address = address,
                Cell = cell,
                Institute = institute

            };

            StudentInformation stdInfo = new StudentInformation();
            var StudentModel = stdInfo.GetStudentinfo(infoStd);


            Console.WriteLine(" Please Enter Teacher Information");
            Console.WriteLine("Enter Your Good Name");
            var teacherName = Console.ReadLine();

            Console.WriteLine("Enter Your Father Name");
            var fName = Console.ReadLine();

            Console.WriteLine("Enter Your Qualification");
            var qualification = Console.ReadLine();

            Console.WriteLine("Enter Your Graduation School Name");
            var graduationSchool = Console.ReadLine();

            Console.WriteLine("Enter Your Subjects");
            var subjects = Console.ReadLine();

            Console.WriteLine("Enter Your Contact Number");
            var cellNo = Console.ReadLine();

            Console.WriteLine("Enter Your CNIC Number");
            var cnicNo = Console.ReadLine();

            Console.WriteLine("Enter Your Address");
            var addres = Console.ReadLine();

            Teacher teacherInfo = new Teacher
            {
                TeacherName = teacherName,
                FatherName = fName,
                Qualification = qualification,
                GraduationSchool = graduationSchool,
                Subjects = subjects,
                CellNo = cellNo,
                CNICNo = cnicNo,
                Address = addres
            };

            TeacherInformation instructorInfo = new TeacherInformation();
            var TeacherModel = instructorInfo.GetTeacherInfo(teacherInfo);

        }
    }
}

