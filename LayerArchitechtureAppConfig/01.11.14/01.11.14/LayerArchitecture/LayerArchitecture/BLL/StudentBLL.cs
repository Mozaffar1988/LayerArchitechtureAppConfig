using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerArchitecture.DLL.DAO;
using LayerArchitecture.DLL.GATEWAY;

namespace LayerArchitecture.BLL
{
    class StudentBLL
    {
        private StudentGateWay aStudentGateWay;

        public StudentBLL()
        {
            aStudentGateWay = new StudentGateWay();
        }

    

        public string Save(Student aStudent)
        {
            if (aStudent.RegNo =="" || aStudent.StudentName == "" || aStudent.StudentEmail == "" )
            {
                string info = "";
                if (aStudent.RegNo == "")
                {
                    info += "Student RegNo Missing\n";
                }
                if (aStudent.StudentName == "")
                {
                    info += "Student Name Missing\n";
                }
                if (aStudent.StudentEmail == "")
                {
                    info += "Student Email Missing\n";
                }
                
                return info;
            }
            else
            {
                 aStudentGateWay = new StudentGateWay();
                if (aStudentGateWay.SaveData(aStudent))
                {
                    return "Insert Data Succed";
                }
                else
                {
                    return "Not Insert Succed";
                }
            }

           
        }


      
    }
}
