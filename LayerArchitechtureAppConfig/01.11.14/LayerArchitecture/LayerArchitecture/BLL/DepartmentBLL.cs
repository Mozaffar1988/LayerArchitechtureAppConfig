using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayerArchitecture.DLL.DAO;
using LayerArchitecture.DLL.GATEWAY;

namespace LayerArchitecture.BLL
{
    class DepartmentBLL
    {
        private DepartmentGateWay aDepartmentGateWay;


        public DepartmentBLL()
        {
            aDepartmentGateWay = new DepartmentGateWay();
        }

        public string Save(Department aDepartment)
        {
            if ((aDepartment.DepartmentName =="") || (aDepartment.DepartmentCode ==""))
            {
                string info = "";
                if (aDepartment.DepartmentName == "")
                {
                    info += "Department Name missing\n";
                }
                if (aDepartment.DepartmentCode == "")
                {
                    info += "Department Code missing\n";
                }
                return info;
            }
            else
            {
               
                DepartmentGateWay aDepartmentGateWay = new DepartmentGateWay();

                if (aDepartmentGateWay.SaveData(aDepartment))
                {
                    return "Insert data Succed";
                }
                else
                {
                    return "Not Insert have a some problem";
                }
            }
            
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentGateWay.GetAllDepartments();
        }
    }
}
