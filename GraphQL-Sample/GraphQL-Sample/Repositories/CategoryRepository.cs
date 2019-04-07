using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLSample.Core.Interfaces;
using GraphQLSample.Core.Models;

namespace GraphQLSample.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;


        public CategoryRepository()
        {
            _categories = new List<Category>{
                new Category()
                {
                    Id = 1,
                    Name = "Category-1"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Category-2"
                }
            };
        }


        public Task<List<Category>> GetCategories()
        {
            return Task.FromResult(_categories);
        }

        public Task<Category> GetCategory(int id)
        {
            return Task.FromResult(_categories.FirstOrDefault(x => x.Id == id));
        }
    }
}
