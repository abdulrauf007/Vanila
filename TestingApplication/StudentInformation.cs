using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    public class StudentInformation
    {
        private Student _student;
        private List<Student> _defaultStduent;
        private List<Student> _listStudents;

        public StudentInformation(Student std)
        {
            _student = std;
        }

        public StudentInformation()
        {
            _defaultStduent = new List<Student>
           {
               new Student
               {
                FirsttName = "John",
                LastName = "Cena",
                FatherName = "Chris",
                Cell= "090078601",
                CNIC ="090909",
                Address = "USA",
                Institute ="NHU"
               }
           };
        }

        public StudentInformation(List<Student> listStd)
        {
            _listStudents = listStd;
        }

        
        public List<Student> defaultStd ()
        {
            return _defaultStduent;
        }

        public Student singleStudent()
        {
            return _student;
        }

        public List<Student> GetlistOfStudent ()
        {
            return _listStudents;
        }
    }
}

