using System;
using System.Collections.Generic;

namespace TestingApplication
{
    class Program
    {


        static void Main(string[] args)
        {


            StudentInformation defaultStdList = new StudentInformation();
            var defaultList = defaultStdList.defaultStd();


            StudentInformation singleStudentInfo = new StudentInformation();
            var singleStd = singleStudentInfo.singleStudent();

            StudentInformation MultiStudentInfo = new StudentInformation(new List<Student>
            {
                new Student
                {
                    FirsttName = "lee",
                    LastName = "Suu",
                    Address = "KHI"
                    
                }
            });

            var multistd = MultiStudentInfo.GetlistOfStudent();


        }


    }
}

