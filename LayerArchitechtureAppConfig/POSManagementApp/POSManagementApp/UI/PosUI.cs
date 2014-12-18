using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSManagementApp.BLL;
using POSManagementApp.DLL.DAO;

namespace POSManagementApp
{
    public partial class PosUI : Form
    {
        public PosUI()
        {
            InitializeComponent();
            showDataGridView.DataSource = aProductBll.ShowAllProduct();
        }
        ProductBLL aProductBll = new ProductBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.ProductCode = CodeTextBox.Text;
            aProduct.ProductName = nameTextBox.Text;
            aProduct.ProductQuantity = quantityTextBox.Text;
            string msg = aProductBll.Save(aProduct);
            MessageBox.Show(msg);

            
            totalQuantityTextBox.Text = aProductBll.GetTotal().ToString();
            showDataGridView.DataSource = aProductBll.ShowAllProduct();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = aProductBll.ShowAllProduct();
        }
    }
}
