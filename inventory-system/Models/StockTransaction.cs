// StockTransaction entity
using System;

namespace InventorySystem.Models
{
    public class StockTransaction
    {
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // ADD / REMOVE

        public StockTransaction() { }

        public StockTransaction(string transactionId, string productId, int quantity, DateTime date, string type)
        {
            TransactionId = transactionId;
            ProductId = productId;
            Quantity = quantity;
            Date = date;
            Type = type;
        }
    }
}
