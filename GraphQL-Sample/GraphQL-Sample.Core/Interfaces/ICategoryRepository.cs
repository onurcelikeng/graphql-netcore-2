using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLSample.Core.Models;

namespace GraphQLSample.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategory(int id);
    }
}
