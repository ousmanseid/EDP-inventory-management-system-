using System;
using System.Collections.Generic;
using InventorySystem.Models;
using InventorySystem.Storage;

namespace InventorySystem.Services
{
    public class StockService
    {
        private ProductService _productService;

        public StockService()
        {
            _productService = new ProductService();
        }

        public bool RecordTransaction(string productId, int quantity, string type)
        {
            Product p = _productService.GetProductById(productId);
            if (p == null) return false;

            if (type.Equals("ADD", StringComparison.OrdinalIgnoreCase))
            {
                p.Quantity += quantity;
            }
            else if (type.Equals("REMOVE", StringComparison.OrdinalIgnoreCase))
            {
                if (p.Quantity < quantity)
                    return false; // Not enough stock

                p.Quantity -= quantity;
            }
            else
            {
                return false;
            }

            // Log transaction
            StockTransaction transaction = new StockTransaction(
                Guid.NewGuid().ToString(),
                productId,
                quantity,
                DateTime.Now,
                type.ToUpper()
            );
            MemoryStorage.Transactions.Add(transaction);

            return true;
        }

        public List<StockTransaction> GetAllTransactions()
        {
            return MemoryStorage.Transactions;
        }

        public void ClearAllTransactions()
        {
            MemoryStorage.Transactions.Clear();
        }
    }
}
