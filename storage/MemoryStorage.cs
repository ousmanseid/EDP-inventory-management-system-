using System.Collections.Generic;
using InventorySystem.Models;

namespace InventorySystem.Storage
{
    public static class MemoryStorage
    {
        // In-memory lists for data storage
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Supplier> Suppliers { get; set; } = new List<Supplier>();
        public static List<StockTransaction> Transactions { get; set; } = new List<StockTransaction>();
        public static List<User> Users { get; set; } = new List<User>();

        // Static constructor to initialize dummy data
        static MemoryStorage()
        {
            // Initial Users for different roles
            Users.Add(new User("1", "superadmin", "superadmin", "SuperAdmin"));
            Users.Add(new User("2", "admin", "admin", "Admin"));
            Users.Add(new User("3", "staff", "staff", "Staff"));

            // Sample Products
            Products.Add(new Product("P1", "Laptop", "Electronics", 999.99, 10));
            Products.Add(new Product("P2", "Mouse", "Electronics", 25.50, 4)); // Low stock item

            // Sample Supplier
            Suppliers.Add(new Supplier("S1", "TechDistributors", "123-456-7890", "123 Tech Lane"));
        }
    }
}
