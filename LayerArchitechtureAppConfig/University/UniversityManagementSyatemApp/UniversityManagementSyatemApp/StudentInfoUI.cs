using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSyatemApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
            ShowGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            //Using Constractor
           // Student aStudent = new Student(nameTextBox.Text,emailTextBox.Text,addressTextBox.Text);
            //Using Auto property
            Student aStudent = new Student();
            aStudent.StudentName = nameTextBox.Text;
            aStudent.StudentEmail = emailTextBox.Text;
            aStudent.StudentAddress = addressTextBox.Text;
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";


            string conn = @"server=WIN-APF1B7L3NAT;database=UniversityManagementSystem;integrated security=true";
            SqlConnection aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;

            aConnection.Open();

            string quary = String.Format("INSERT INTO t_student VALUES('{0}','{1}','{2}')", aStudent.StudentName, aStudent.StudentEmail, aStudent.StudentAddress);

            SqlCommand aCommand = new SqlCommand(quary,aConnection);
            int total = aCommand.ExecuteNonQuery();
            if (total > 0)
            {
                MessageBox.Show("Insert success");
            }
            else
            {
                MessageBox.Show("Some Error");
            }
            aConnection.Close();
            ShowGridView();
        }


        private void ShowGridView()
        {
            string conn = @"server=WIN-APF1B7L3NAT;database=UniversityManagementSystem;integrated security=true";
            SqlConnection aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;

            aConnection.Open();

            string quary = "SELECT * FROM t_student";
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Student> students = new List<Student>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    //Using Constractor
                   // Student aStudent = new Student(nameTextBox.Text,emailTextBox.Text,addressTextBox.Text);
                    //Using Autoproperty
                    Student btStudent = new Student();
                    
                    btStudent.StudentId = (int) aReader[0];
                    btStudent.StudentName = aReader[1].ToString();
                    btStudent.StudentEmail = aReader[2].ToString();
                    btStudent.StudentAddress = aReader[3].ToString();
                    //showGridView.Rows[0].Cells[0].Value = aStudent.StudentId;
                    
                    students.Add(btStudent);
                }
            }
            aConnection.Close();
           // showGridView.Sort(showGridView.Columns[1],ListSortDirection.Ascending);
            
            
            showGridView.DataSource = students;
            
        }
    }
}
