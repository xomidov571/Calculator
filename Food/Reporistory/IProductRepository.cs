using Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Reporistory
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> CreateProduct(Product newproduct);
        Task<Product> UpdateProduct(Product product);
        Task<bool> RemoveProduct(int id);
    }
}
