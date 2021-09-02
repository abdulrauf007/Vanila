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


            teacher getTeacher = new teacher 
            { 
                TeacherName = "Lee",
                FName = "Jhon",
                Qulification = "CS",
                CreateDateTime = Convert.ToDateTime("20/5/2021")

            };
            getTeacher.TeacherName = "";
            getTeacher.



        }


    }
}

