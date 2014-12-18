using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.DLL.DAO;

namespace POSManagementApp.DLL.GateWay
{
    class ProductGateway
    {
        SqlConnection aConnection = new SqlConnection();
        public ProductGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentDBConnectionStr"].ConnectionString;
            //aConnection.ConnectionString = connectionString;
            aConnection.ConnectionString = connectionString;
        }

        public bool Save(Product aProduct)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_product VALUES('{0}','{1}','{2}')", aProduct.ProductCode, aProduct.ProductName, aProduct.ProductQuantity);
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

        public bool HashThisProductNameAlreadySystem(string productName)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product WHERE product_name='{0}'", productName);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public bool HashThisProductCodeAlreadySystem(string productCode)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product WHERE product_code='{0}'", productCode);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public List<Product> ShowAllProduct()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.ProductID = (int)aReader[0];
                    aProduct.ProductCode = aReader[1].ToString();
                    aProduct.ProductName = aReader[2].ToString();
                    aProduct.ProductQuantity = aReader[3].ToString();
                    products.Add(aProduct);
                }
            }
            aConnection.Close();
            return products;
        }

        public int GetTotal()
        {
            aConnection.Open();
            string query = string.Format("SELECT SUM(product_quantity) FROM t_product");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();

            int msg = Convert.ToInt32(aReader.HasRows);
            //bool msg = aReader.HasRows;
            //int sum = 0;
            //if (true)
            //{
            //    while (aReader.Read())
            //    {
            //        sum +=(int) aReader[3];
            //    }
                
            //}
           aConnection.Close();
            return msg;

        }

     
    }
}
