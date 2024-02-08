using SalesWindow.Dtos;
using SalesWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWindow.Servises
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> CreateProduct(CreateProductDto newProduct);
        Task<(double salesProduct, int quantity)> SalesProduct(int id, int quartity);
        Task<List<Product>> GetCategoryProduct(string categoy);
    }
}
