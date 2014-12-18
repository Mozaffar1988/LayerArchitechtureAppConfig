using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerArchitecture.DLL.DAO;

namespace LayerArchitecture.DLL.GATEWAY
{
    class StudentGateWay
    {
        private SqlConnection aConnection;

        public StudentGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT;database=LayerArchitecture;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public bool SaveData(Student aStudent)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_student VALUES('{0}','{1}','{2}','{3}')",aStudent.RegNo, aStudent.StudentName, aStudent.StudentEmail,aStudent.DepartmentID );
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

     
    }
}
