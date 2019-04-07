using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLSample.Core.Models;

namespace GraphQLSample.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();

        Task<List<Product>> GetProductsWithByCategoryId(int categoryId);

        Task<Product> GetProduct(int id);
    }
}
