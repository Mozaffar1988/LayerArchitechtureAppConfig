using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayerArchitecture.BLL;
using LayerArchitecture.DLL.DAO;

namespace LayerArchitecture.UI
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            PopulateStudentCombobox();
        }

        private void PopulateStudentCombobox()
        {            
            departmentComboBox.DisplayMember = "DepartmentCode";
            List<Department> departments = aDepartmentBll.GetAllDepartment();
            departmentComboBox.DataSource = departments; 
        }

        StudentBLL aStudentBll = new StudentBLL();
        DepartmentBLL aDepartmentBll = new DepartmentBLL();
        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = studentRegNoTextBox.Text;
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.StudentEmail = studentEmailTextBox.Text;
            //aStudent.StudentDept = studentDepartmentTextBox.Text;

            Department selecteDepartment = (Department) departmentComboBox.SelectedItem;
            aStudent.DepartmentID = selecteDepartment.DepartmentID;
           
            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
        }

    }
}
