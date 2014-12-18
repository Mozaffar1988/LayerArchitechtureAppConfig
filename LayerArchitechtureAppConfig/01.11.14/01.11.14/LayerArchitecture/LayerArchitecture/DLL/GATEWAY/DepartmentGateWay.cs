using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerArchitecture.DLL.DAO;

namespace LayerArchitecture.DLL.GATEWAY
{
    class DepartmentGateWay
    {
        private SqlConnection aConnection;

        public DepartmentGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT;database=LayerArchitecture;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public bool SaveData(Department aDepartment)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_department VALUES('{0}','{1}')", aDepartment.DepartmentName, aDepartment.DepartmentCode);
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();

            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Department> GetAllDepartments()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.DepartmentID = (int)aReader[0];
                    aDepartment.DepartmentName = aReader[1].ToString();
                    aDepartment.DepartmentCode = aReader[2].ToString();
                    departments.Add(aDepartment);
                }
            }
            aConnection.Close();
            return departments;
        }
    }
}
