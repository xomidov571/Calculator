using SalesWindow.Dtos;
using SalesWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWindow.Servises
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Milliy cola",
                Price = 5000,
                Quantity = 100,
                Volume = 0.5,
                Made = "UZB",
                Category = "Gazli",
                CameDate = DateTime.UtcNow.AddHours(5)
            },
            new Product
            {
                Id = 2,
                Name = "Dena",
                Price = 12000,
                Quantity = 200,
                Volume = 1,
                Made = "UZB",
                Category = "Tabiiy",
                CameDate = DateTime.UtcNow.AddHours(5)
            },
            new Product
            {
                Id = 6,
                Name = "Family",
                Price = 3000,
                Quantity = 500,
                Volume = 0.5,
                Made = "UZB",
                Category = "Mineral",
                CameDate = DateTime.UtcNow.AddHours(5)
            }
        };
        public Task<Product> CreateProduct(CreateProductDto newProduct)
        {
            var product = new Product
            {
                Id = new Random().Next(0, 100),
                Name = newProduct.Name,
                Quantity = newProduct.Quantity,
                Price = newProduct.Price,
                Volume = newProduct.Volume,
                Made = newProduct.Made,
                Category = newProduct.Category,
                CameDate= DateTime.UtcNow.AddHours(5)
            };

            products.Add(product);
            return Task.FromResult(product);
        }

        public async Task<List<Product>> GetCategoryProduct(string categoy)
        {
            List<Product> categories = products.FindAll(p => p.Category == categoy);

            if (categories is null)
                return null;

            return await Task.FromResult(categories);
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);

            if (product is null)
                return null;

            return product;
        }

        public async Task<List<Product>> GetProducts()
            => await Task.FromResult(products);

        public async Task<(double salesProduct, int quantity)> SalesProduct(int id, int quantity)
        {
            var product = await GetProduct(id);

            if (product is null || product.Quantity < quantity)
                return (TotalPrice: 0, QuantitySold: 0);

            double totalPrice = product.Price * quantity;

            product.Quantity -= quantity;

            return (totalPrice: totalPrice, QuantitySold: quantity);
        }
    }
}
