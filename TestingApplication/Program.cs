using System;
using System.Collections.Generic;

namespace TestingApplication
{
    class Program
    {


        static void Main(string[] args)
        {

            //Console.WriteLine("Please Enter Book Information");
            //Console.WriteLine("Please Eneter Book Name");
            //var bookName = Console.ReadLine();

            //Console.WriteLine("Please Eneter Author Name");
            //var authorName = Console.ReadLine();

            //Console.WriteLine("Please Eneter Contributer Name");
            //var contributerName = Console.ReadLine();

            //Console.WriteLine("Please Eneter Publisher Name");
            //var publisherName = Console.ReadLine();

            //Console.WriteLine("How many number of pages in this book");
            //var numberofPager = Console.ReadLine();

            //Console.WriteLine("Please Eneter Published date and Time");
            //DateTime pDateTime = Convert.ToDateTime(Console.ReadLine());


            //Books bookInfo = new Books


            //{
            //    BookName = bookName,
            //    AuthorName = authorName,
            //    PublisherName = publisherName,
            //    ContributerName = contributerName,
            //    NumberofPages = numberofPager,
            //    PDateTime = pDateTime
            //};

            //BooksInformation infoBooks = new BooksInformation();
            //var booksHub = infoBooks.GetBookInfo(bookInfo);

            //Console.WriteLine("Book Name {0} Author name {1} Publisher name {2} Contributer name {3} Number of pages {4} Publish Date and Time {5}",
            //    booksHub.BookName, booksHub.AuthorName, booksHub.PublisherName, booksHub.ContributerName, booksHub.NumberofPages, booksHub.PDateTime);


            //var students = new List<Student>()
            //{
            //    new Student
            //    {
            //        FirsttName = "Rauf",
            //    },
            //    new Student
            //    {
            //        FirsttName = "Yasir"
            //    },
            //    new Student
            //    {
            //        FirsttName = "Danish"
            //    }
            //};

            //StudentInformation stdInfo = new StudentInformation();
            //var listOfStudent = stdInfo.GetStudentinfos(students);


            var students = new List<Student>()
            {
                new Student
                {
                    FirsttName = "Abdul",
                    LastName = "Rauf",
                    FatherName ="Nehal",
                    CNIC ="00000",
                    Cell = "090078601",
                    Institute = "NHU",
                    Address = "KHI"

                },

                new Student
                {
                    FirsttName = "John",
                    LastName = "Stephen",
                    FatherName ="Louis",
                    CNIC ="09878",
                    Cell = "09576575",
                    Institute = "NHU",
                    Address = "KHI"

                },
                 new Student
                {
                    FirsttName = "Yasir",
                    LastName = "khan",
                    FatherName ="Shahzaib",
                    CNIC ="098434378",
                    Cell = "0957343436575",
                    Institute = "NHU",
                    Address = "KHI"

                },

                 new Student
                {
                    FirsttName = "Arsalan",
                    LastName = "khan",
                    FatherName ="Hassan",
                    CNIC ="0984345558",
                    Cell = "03439986575",
                    Institute = "NHU",
                    Address = "KHI"

                }
            };

            StudentInformation StdInfo = new StudentInformation();
            var ListOfInformation = StdInfo.GetStudentsInfo(students);

            //Console.WriteLine("Please Enter Shelf Information");
            //Console.WriteLine("How many number of Rows in this Shelf");
            //var nRows = Console.ReadLine();

            //Console.WriteLine("How many number of columns in this Shelf");
            //var nColumn = Console.ReadLine();

            //Console.WriteLine("Please enter catagory of shelf");
            //var catagory  = Console.ReadLine();

            //Console.WriteLine("Please enter type of shelf");
            //var type = Console.ReadLine();

            //Console.WriteLine("How many number of book shelve");
            //var nBooks = Console.ReadLine();

            //Shelf shelfInfo = new Shelf
            //{
            //    NoOfRows = nRows,
            //    NoofColumns = nColumn,
            //    CatagoryOfShelf = catagory,
            //    TypeofShelf = type,
            //    NoofBooks = nBooks

            //};

            //shelfInformation infoShelf = new shelfInformation();
            //var shelfHub = infoShelf.GetShelfInformation(shelfInfo);

            //Console.Write("No. of Rows: {0} No. of Columns:{2} Shelf Catagory: {2} shelf Type {3} No of Books {4}",
            //   shelfHub.NoOfRows, shelfHub.NoofColumns, shelfHub.CatagoryOfShelf, shelfHub.TypeofShelf, shelfHub.NoofBooks);



            //Console.WriteLine("Author name {0}", booksHub.AuthorName);
            //Console.WriteLine("Publisher name {0}", booksHub.PublisherName);
            //Console.WriteLine("Contributer name {0}", booksHub.ContributerName);
            //Console.WriteLine("Number of pages {0}", booksHub.NumberofPages);
            //Console.WriteLine("Publish Date and Time {0}", booksHub.PDateTime);

            //    Calculator Cal = new Calculator();
            //    var addResultInt = Cal.Add(10, 2);
            //    var addResultDouble = Cal.Add(2.0,3.0);
            //    var addResultFloat = Cal.Add(32.2f, 31.3f);
            //    var addResultDecimal = Cal.Add(2.2m, 21.3m);
            //    var addResultLong = Cal.Add(9223372036854, 111111111111);

            //    var subResultInt = Cal.Sub(100, 35);
            //    var subResultDouble = Cal.Sub(10.1, 9.3);
            //    var subResultFloat = Cal.Sub(10.4f, 93.1f);
            //    var subResultDecimal = Cal.Sub(10.4m, 93.1m);
            //    var subResultLong = Cal.Sub(922337203436854, 112221111111);


            //    var mulResultInt = Cal.Multiplication(23, 6);
            //    var mulResultDouble = Cal.Multiplication(33.4, 22.4);
            //    var mulResultFloat = Cal.Multiplication(223f, 6f);
            //    var mulResultDecimal = Cal.Multiplication(223m, 6m);
            //    var mulResultLong = Cal.Multiplication(922337203436854, 1123333111111);

            //    var divResultInt = Cal.Division(32, 2);
            //    var divResultDouble = Cal.Division(34.2, 2.1);
            //    var divResultFloat = Cal.Multiplication(223f, 6f);
            //    var divResultDecimal = Cal.Multiplication(223m, 6m);
            //    var divResultLong = Cal.Multiplication(922337203436854, 1123333111111);


            //    Console.WriteLine("Add");
            //    Console.WriteLine(addResultInt);
            //    Console.WriteLine(addResultDouble);
            //    Console.WriteLine(addResultFloat);
            //    Console.WriteLine(addResultDecimal);
            //    Console.WriteLine(addResultLong);

            //    Console.WriteLine("Sub");
            //    Console.WriteLine(subResultInt);
            //    Console.WriteLine(subResultDouble);
            //    Console.WriteLine(subResultFloat);
            //    Console.WriteLine(subResultDecimal);
            //    Console.WriteLine(subResultLong);

            //    Console.WriteLine("Multiplication");
            //    Console.WriteLine(mulResultInt);
            //    Console.WriteLine(mulResultDouble);
            //    Console.WriteLine(mulResultFloat);
            //    Console.WriteLine(mulResultDecimal);
            //    Console.WriteLine(mulResultLong);

            //    Console.WriteLine("Division");
            //    Console.WriteLine(divResultInt);
            //    Console.WriteLine(divResultDouble);
            //    Console.WriteLine(divResultFloat);
            //    Console.WriteLine(divResultDecimal);
            //    Console.WriteLine(divResultLong);



            //    Console.WriteLine(" Please Enter Student Information");
            //    Console.WriteLine("Enter Your First Name");
            //    var firstName = Console.ReadLine();

            //    Console.WriteLine("Enter Your Last Name");
            //    var lastName = Console.ReadLine();

            //    Console.WriteLine("Enter Your Father Name");
            //    var fatherName = Console.ReadLine();

            //    Console.WriteLine("Enter Your CNIC Number");
            //    var cnic = Console.ReadLine();

            //    Console.WriteLine("Enter Your Phone Number");
            //    var cell = Console.ReadLine();

            //    Console.WriteLine("Enter Your Address");
            //    var address = Console.ReadLine();

            //    Console.WriteLine("Enter Your Institiution Name");
            //    var institute = Console.ReadLine();

            //    Student infoStd = new Student
            //    {
            //        FirsttName = firstName,
            //        LastName = lastName,
            //        FatherName = fatherName,
            //        CNIC = cnic,
            //        Address = address,
            //        Cell = cell,
            //        Institute = institute

            //    };

            //    StudentInformation stdInfo = new StudentInformation();
            //    var StudentModel = stdInfo.GetStudentinfo(infoStd);


            //    Console.WriteLine(" Please Enter Teacher Information");
            //    Console.WriteLine("Enter Your Good Name");
            //    var teacherName = Console.ReadLine();

            //    Console.WriteLine("Enter Your Father Name");
            //    var fName = Console.ReadLine();

            //    Console.WriteLine("Enter Your Qualification");
            //    var qualification = Console.ReadLine();

            //    Console.WriteLine("Enter Your Graduation School Name");
            //    var graduationSchool = Console.ReadLine();

            //    Console.WriteLine("Enter Your Subjects");
            //    var subjects = Console.ReadLine();

            //    Console.WriteLine("Enter Your Contact Number");
            //    var cellNo = Console.ReadLine();

            //    Console.WriteLine("Enter Your CNIC Number");
            //    var cnicNo = Console.ReadLine();

            //    Console.WriteLine("Enter Your Address");
            //    var addres = Console.ReadLine();

            //    Teacher teacherInfo = new Teacher
            //    {
            //        TeacherName = teacherName,
            //        FatherName = fName,
            //        Qualification = qualification,
            //        GraduationSchool = graduationSchool,
            //        Subjects = subjects,
            //        CellNo = cellNo,
            //        CNICNo = cnicNo,
            //        Address = addres
            //    };

            //    TeacherInformation instructorInfo = new TeacherInformation();
            //    var TeacherModel = instructorInfo.GetTeacherInfo(teacherInfo);

        }
    }
}

