using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLSample.Core.Models;
using GraphQLSample.Core.Interfaces;

namespace GraphQLSample.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;


        public ProductRepository()
        {
            _products = new List<Product>{
                new Product()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Samsung S9+",
                    Price = 599
                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "iPhone 7+",
                    Price = 699
                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Nokia 930",
                    Price = 499
                }
            };
        }


        public Task<Product> GetProduct(int id)
        {
            return Task.FromResult(_products.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Product>> GetProducts()
        {
            return Task.FromResult(_products);
        }

        public Task<List<Product>> GetProductsWithByCategoryId(int categoryId)
        {
            return Task.FromResult(_products.Where(x => x.CategoryId == categoryId).ToList());
        }
    }
}