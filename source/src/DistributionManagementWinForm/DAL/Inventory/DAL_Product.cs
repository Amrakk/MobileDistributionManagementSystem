using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inventory
{
    public class DAL_Product
    {
        private Product product;
        public DAL_Product(int id, string name, string model, string description, int price, int quantity)
        {
            product = new Product(id, name, model, description, price, quantity);
        }

        public void addQuery()
        {
            string sql = $"INSERT INTO Product (product_name, model, product_description, product_price, product_quantity) VALUES " +
                                             $"('{ product.Name }', " +
                                             $"'{ product.Model }', " +
                                             $"'{ product.Description }', " +
                                             $"{ product.Price }, " +
                                             $"{ product.Quantity })";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = $"UPDATE Product SET product_name = '{product.Name}', " +
                                            $"model = '{product.Model}', " +
                                            $"product_description = '{product.Description}', " +
                                            $"product_price = {product.Price}, " +
                                            $"product_quantity = {product.Quantity} " +
                                            $"WHERE product_id = {product.Id}";
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = $"DELETE FROM Product WHERE product_id = {product.Id}";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}
