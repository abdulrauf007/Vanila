using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    public class StudentInformation
    {
        private Student _student;
        public StudentInformation(Student std)
        {
            _student = std;
        }

        public StudentInformation(int a, int b , int c)
        {

        }
       public Student GetStudentinfo(Student student)
        {
            var data = _student;
            return student;
        }

        //public List<Student> GetStudentinfos(List<Student> students)
        //{
        //    return students;
        //}

        public List<Student> GetStudentinfos(List<Student> students)
        {
            return students;
        }
    }
}

