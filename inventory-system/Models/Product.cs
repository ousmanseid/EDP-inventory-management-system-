// Product entity
using System;

namespace InventorySystem.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(string productId, string name, string category, double price, int quantity)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        // Used for display in ComboBoxes
        public override string ToString()
        {
            return Name;
        }
    }
}
