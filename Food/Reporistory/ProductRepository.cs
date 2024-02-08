using Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Reporistory
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> product = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Kupen",
                Price = 8000,
                Made = "Uzb",
                CreateDate = DateTime.Now,
                EndDate = DateTime.Now,
            }
        };
        public Task<Product> CreateProduct(Product newproduct)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProduct(int id)
        {
            var productId = product.Find(p => p.Id == id);
            if(productId is null)
                return null;

            return productId;
        }

        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
