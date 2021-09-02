using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    class Base
    {
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        private String Createdby { get; set; }
        private String updatedby { get; set; }
    }

    class student : Base
    {
        public String StdName { get; set; }
        public String FName { get; set; }
        public String School { get; set; }
    }

    class teacher : Base
    {
        public String TeacherName { get; set; }
        public String FName { get; set; }
        public String Qulification { get; set; }

       
        
    }

     
}
