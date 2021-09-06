using System;
using System.Collections.Generic;

namespace TestingApplication
{
    class Program
    {


        static void Main(string[] args)
        {


            //StudentInformation defaultStdList = new StudentInformation();
            //var defaultList = defaultStdList.defaultStd();


            //StudentInformation singleStudentInfo = new StudentInformation();
            //var singleStd = singleStudentInfo.singleStudent();

            //StudentInformation MultiStudentInfo = new StudentInformation(new List<Student>
            //{
            //    new Student
            //    {
            //        FirsttName = "lee",
            //        LastName = "Suu",
            //        Address = "KHI"

            //    }
            //});

            //var multistd = MultiStudentInfo.GetlistOfStudent();


            /////////// Teacher List Using Constructor ////////////

            //TeacherInformation defaultTeacherInfo = new TeacherInformation();
            //var deftechInfo = defaultTeacherInfo.defaultTeacherValue();

            //TeacherInformation singleTecher = new TeacherInformation();
            //var teachersingle = singleTecher.Singleteacher();

            //TeacherInformation multiTeacher = new TeacherInformation(new List<Teacher>
            //{
            //    new Teacher
            //    {
            //        TeacherName ="John",
            //        FatherName = "Lee",
            //        CNICNo = "0909",
            //        CellNo = "08988",
            //        Address = "KHI",
            //        Qualification = "BS",
            //        Subjects = "CS",
            //        GraduationSchool = "NHU"
            //    }
            //});


            //teacher getTeacher = new teacher 
            //{ 
            //    TeacherName = "Lee",
            //    FName = "Jhon",
            //    Qulification = "CS",
            //    CreateDateTime = Convert.ToDateTime("20/5/2021")

            //};
            //getTeacher.TeacherName = "";
            //getTeacher.

            A extendA = new A();
            var extA = extendA.Sum(2,1);

            B extendB = new B();
            var extB = extendB.Multipication(3, 8);

            C extendC = new C();
            var extC = extendC.Subtract(4, 7);

            Console.WriteLine(extA);
            Console.WriteLine(extB);
            Console.WriteLine(extC);


            EmployeeInformation defaultemp = new EmployeeInformation();
            var defEmp = defaultemp.defaultEmp();

            EmployeeInformation singleEMP = new EmployeeInformation(new Employee
            {
                Name = "Mark",
                FatherName = "Jason",
                Qulification = "BSCS",
                Institute = "UOK",
                CellNo = 08080,
                Address = "Pakistan"
            });
            var empSingle = singleEMP.singleEmployee();
            Console.WriteLine("Name: {0}, FatherName: {1}, Qualification: {2}, Institute: {3}, Cell NO: {4}, Address: {5}",
                 empSingle.Name, empSingle.FatherName, empSingle.Qulification, empSingle.Institute, empSingle.CellNo,
                 empSingle.Address);


            EmployeeInformation multiEMP = new EmployeeInformation(new List<Employee>
            {
                new Employee
                {
                    Name = "Louis",
                    FatherName ="John",
                    Qulification  = "BSCS",
                    Institute = "NHU",
                    CellNo = 09008,
                    Address = "Pakistan"
                },
                new Employee
                {
                    Name = "II Louis",
                    FatherName ="MJ John",
                    Qulification  = "BSCS",
                    Institute = "NHU",
                    CellNo = 390,
                    Address = "Pakistan"
                }
            });

            var empMulti = multiEMP.MultiEmployee();
            for (int i = 0; i < empMulti.Count; i++) 
            {
                Console.WriteLine("Name: {0}, FatherName: {1}, Qualification: {2},Institute: {3},Cell NO: {4}, Address: {5}",
                 empMulti[i].Name,empMulti[i].FatherName, empMulti[i].Qulification, empMulti[i].Institute, empMulti[i].CellNo,
                 empMulti[i].Address);
            }


        }


    }
}

