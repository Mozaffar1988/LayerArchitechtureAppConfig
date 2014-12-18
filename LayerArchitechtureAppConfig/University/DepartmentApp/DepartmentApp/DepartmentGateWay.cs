using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentApp
{
    class DepartmentGateWay

    {
        private SqlConnection aConnection;

        public DepartmentGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT;database=UniversityManagementSystem;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }
        public string Save(Department aDepartment)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_depertment VALUES('{0}','{1}')", aDepartment.DeptmentName, aDepartment.DeptmentCode);
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();

            if (total > 0)
            {
                return "Save Succed";
            }
            else
            {
                return "Some Problem Occured";
            }
          
        }

        public List<Department> GetAllDepartments()
        {
            aConnection.Open();
            string quary = "SELECT * FROM t_depertment";
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.DeptmentId = (int)aReader[0];
                    aDepartment.DeptmentName = aReader[1].ToString();
                    aDepartment.DeptmentCode = aReader[2].ToString();
                    departments.Add(aDepartment);
                }
            }
            aConnection.Close();
            return departments;
        }
    }
}
