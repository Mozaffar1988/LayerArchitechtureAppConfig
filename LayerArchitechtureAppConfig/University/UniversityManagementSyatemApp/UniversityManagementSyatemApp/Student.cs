using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSyatemApp
{
    class Student
    {
        //Using Autoproperty
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail  { get; set; }
        public string StudentAddress { get; set; }


        //Using Constractor
        //public Student(string studentEmail, string studentName, string studentAddress)
        //{

        //    StudentEmail = studentEmail;
        //    StudentName = studentName;
        //    StudentAddress = studentAddress;
        //}
    }
}
