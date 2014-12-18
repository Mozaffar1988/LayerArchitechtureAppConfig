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
    public partial class DepartmentUI : Form
    {
        public DepartmentUI()
        {
            InitializeComponent();
            GetAllDepartment();
        }
            private DepartmentBLL aDepartmentBll = new DepartmentBLL();
        private void saveDepartmentButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.DepartmentName = departmentNameTextBox.Text;
            aDepartment.DepartmentCode = departmentCodeTextBox.Text;
            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);
            GetAllDepartment();
        }

        private void GetAllDepartment()
        {
            departmentGridView.DataSource = aDepartmentBll.GetAllDepartment();
        }
    }
}
