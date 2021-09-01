using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    class TeacherInformation
    {
        private List<Teacher> _defaultTeacherList;
        private Teacher _singleTeacher;
        private List<Teacher> _multiTeacher;

        public TeacherInformation()
        {
            _defaultTeacherList = new List<Teacher>
            {
                new Teacher
                {
                    TeacherName ="John",
                    FatherName = "Lee",
                    CNICNo = "0909",
                    CellNo = "08988",
                    Address = "KHI",
                    Qualification = "BS",
                    Subjects = "CS",
                    GraduationSchool = "NHU"
                    
                }
            };
        }
        public TeacherInformation(Teacher teacher)
        {
            _singleTeacher = teacher;
        }

        public TeacherInformation(List<Teacher> tech)
        {
            _multiTeacher = tech;

        }

        public List<Teacher> defaultTeacherValue()
        {
            return _defaultTeacherList;
        }

        public Teacher Singleteacher()
        {
            return _singleTeacher;
        }

        public List<Teacher> MultiteacherList()
        {
            return _multiTeacher;
        }

    } 

}
