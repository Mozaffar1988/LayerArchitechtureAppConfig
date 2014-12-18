using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.DLL.DAO;
using POSManagementApp.DLL.GateWay;

namespace POSManagementApp.BLL
{
    internal class ProductBLL

    {
        private ProductGateway aProductGateway;

        public ProductBLL()
        {
            aProductGateway = new ProductGateway();
        }

        public string Save(Product aProduct)
        {
            if ((aProduct.ProductCode.Length > 3 || aProduct.ProductCode.Length < 3) ||
                (aProduct.ProductName.Length < 5 || aProduct.ProductName.Length > 10) ||
                (aProduct.ProductQuantity == ""))
            {
                string info = "";
                if (aProduct.ProductCode.Length > 3 || aProduct.ProductCode.Length < 3)
                {
                    info += "You can input 3 digit Code\n";
                }
                if (aProduct.ProductName.Length < 5 || aProduct.ProductName.Length > 10)
                {
                    info += "Product Name Only 5-10 Character\n";
                }
                if (aProduct.ProductQuantity == "")
                {
                    info += "Your quantity firld is blank";
                }
                return info;
            }
            else
            {
                if (HashThisProductCodeAlreadySystem(aProduct.ProductCode) ||
                    HashThisProductNameAlreadySystem(aProduct.ProductName))
                {
                    string msg = "";
                    if (HashThisProductCodeAlreadySystem(aProduct.ProductCode))
                    {
                        msg += "This Product Code Already Input";
                    }
                    if (HashThisProductNameAlreadySystem(aProduct.ProductName))
                    {
                        msg += "This Product Name Already Input";
                    }
                    return msg;
                }
                else
                {
                    if (aProductGateway.Save(aProduct))
                    {
                        return "Product Insert Success Fully";
                    }
                    return "Not Insert";
                }

            }
        }

        private bool HashThisProductNameAlreadySystem(string productName)
        {
            return aProductGateway.HashThisProductNameAlreadySystem(productName);
        }

        private bool HashThisProductCodeAlreadySystem(string productCode)
        {
            return aProductGateway.HashThisProductCodeAlreadySystem(productCode);
        }


        public List<Product> ShowAllProduct()
        {
            return aProductGateway.ShowAllProduct();
        }

        public string GetTotal()
        {
            return aProductGateway.GetTotal().ToString();
        }
    }
}
