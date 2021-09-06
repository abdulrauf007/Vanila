using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    class EmployeeInformation
    {
        public List<Employee> _defaultEmloyee;
        public Employee _employee;
        public List<Employee> _empoyeeList;

        public EmployeeInformation(Employee emp)
        {
            _employee = emp;
        }

        public EmployeeInformation ()
        {
            _defaultEmloyee = new List<Employee>
            {
                new Employee
                {
                    Name ="John",
                    FatherName = "Stephen",
                    Qulification = "Software Engineer",
                    Institute = "Middle East University",
                    CellNo = 090078601,
                    Address = "USA"
                },

                 new Employee
                {
                    Name ="Philps",
                    FatherName = "Jhons",
                    Qulification = "Software Engineer",
                    Institute = "Middle East University",
                    CellNo = 9898,
                    Address = "USA"
                }

            };

        }
        public EmployeeInformation(List<Employee> empList)
        {
            _empoyeeList = empList;

        }

        public Employee singleEmployee()
        {
            return _employee;
        }

        public List<Employee> defaultEmp ()
        {
            return _defaultEmloyee;
        }

        public List<Employee> MultiEmployee()
        {
            return _empoyeeList;
        }

    }
}
