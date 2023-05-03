using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Inventory
{
    public class Product
    {
        private int id;
        private string name;
        private string model;
        private string description;
        private int price;
        private int quantity;

        public Product(int id, string name, string model, string description, int price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.model = model;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
