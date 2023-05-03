using DAL.Inventory;
using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Inventory
{
    public class BUS_Product
    {
        private DAL_Product DProduct;

        public BUS_Product(int productId, string productName, string model, string productDescription, int productPrice, int productQuantity)
        {
            DProduct = new DAL_Product(productId, productName, model, productDescription, productPrice, productQuantity);
        }

        public void addProduct()
        {
            DProduct.addQuery();
        }

        public void updateProduct()
        {
            DProduct.updateQuery();
        }

        public void DeleteProduct()
        {
            DProduct.deleteQuery();
        }

        public DataTable selectProducts(string query)
        {
            return DProduct.selectQuery(query);
        }
    }
}
