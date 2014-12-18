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

namespace DepartmentApp
{
    public partial class DepertmentUI : Form
    {
        private DepartmentGateWay aDepertmentGateWay;

        public DepertmentUI()
        {
            InitializeComponent();
            aDepertmentGateWay = new DepartmentGateWay();
            ShowGridView();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.DeptmentName = deptNameTextBox.Text;
            aDepartment.DeptmentCode = deptCodeTextBox.Text;
            deptNameTextBox.Text = "";
            deptCodeTextBox.Text = "";
            string msg = aDepertmentGateWay.Save(aDepartment);

            MessageBox.Show(msg);
          
            ShowGridView();
        }

        private void ShowGridView()
        {
            showdataGridView.DataSource = aDepertmentGateWay.GetAllDepartments();
        }
    }
}
