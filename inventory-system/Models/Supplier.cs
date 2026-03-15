// Supplier entity
using System;

namespace InventorySystem.Models
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        public Supplier() { }

        public Supplier(string supplierId, string name, string contact, string address)
        {
            SupplierId = supplierId;
            Name = name;
            Contact = contact;
            Address = address;
        }
    }
}
