using GraphQL.Types;
using GraphQLSample.Core.Models;
using GraphQLSample.Core.Interfaces;

namespace GraphQLSample.Models.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ICategoryRepository categoryRepository)
        {
            Field(x => x.Id).Description("Product Id.");
            Field(x => x.Name).Description("Product Name.");
            Field(x => x.Price).Description("Product Price.");

            Field<CategoryType>(
                "category",
                resolve: context => categoryRepository.GetCategory(context.Source.CategoryId).Result
             );
        }
    }
}
