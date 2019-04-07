using System.Linq;
using GraphQL.Types;
using GraphQLSample.Core.Models;
using GraphQLSample.Core.Interfaces;

namespace GraphQLSample.Models.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IProductRepository productRepository)
        {
            Field(x => x.Id).Description("Category Id.");
            Field(x => x.Name, nullable: true).Description("Category Name.");

            Field<ListGraphType<ProductType>>(
                "products", 
                resolve: context => productRepository.GetProductsWithByCategoryId(context.Source.Id).Result.ToList()
            );
        }
    }
}
