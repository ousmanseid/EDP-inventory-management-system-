using System.Collections.Generic;
using System.Linq;
using InventorySystem.Models;
using InventorySystem.Storage;

namespace InventorySystem.Services
{
    public class SupplierService
    {
        public void AddSupplier(Supplier supplier)
        {
            MemoryStorage.Suppliers.Add(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = MemoryStorage.Suppliers.FirstOrDefault(s => s.SupplierId == supplier.SupplierId);
            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.Contact = supplier.Contact;
                existingSupplier.Address = supplier.Address;
            }
        }

        public void DeleteSupplier(string supplierId)
        {
            var supplierToRemove = MemoryStorage.Suppliers.FirstOrDefault(s => s.SupplierId == supplierId);
            if (supplierToRemove != null)
            {
                MemoryStorage.Suppliers.Remove(supplierToRemove);
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            return MemoryStorage.Suppliers;
        }
    }
}
