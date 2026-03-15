using System.Collections.Generic;
using System.Linq;
using InventorySystem.Models;
using InventorySystem.Storage;

namespace InventorySystem.Services
{
    public class ProductService
    {
        public void AddProduct(Product product)
        {
            MemoryStorage.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = MemoryStorage.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Category = product.Category;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }

        public void DeleteProduct(string productId)
        {
            var productToRemove = MemoryStorage.Products.FirstOrDefault(p => p.ProductId == productId);
            if (productToRemove != null)
            {
                MemoryStorage.Products.Remove(productToRemove);
            }
        }

        public List<Product> GetAllProducts()
        {
            return MemoryStorage.Products;
        }

        public Product GetProductById(string id)
        {
            return MemoryStorage.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public List<Product> SearchProducts(string name, string category)
        {
            return MemoryStorage.Products.Where(p =>
                (string.IsNullOrWhiteSpace(name) || p.Name.IndexOf(name, System.StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrWhiteSpace(category) || p.Category.IndexOf(category, System.StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();
        }

        public List<Product> GetLowStockProducts()
        {
            return MemoryStorage.Products.Where(p => p.Quantity < 5).ToList();
        }
    }
}
