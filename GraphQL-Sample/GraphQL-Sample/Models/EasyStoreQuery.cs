using System;
using GraphQL.Types;
using GraphQLSample.Core.Interfaces;
using GraphQLSample.Models.Types;

namespace GraphQLSample.Models
{
    public class EasyStoreQuery : ObjectGraphType
    {
        public EasyStoreQuery(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            Field<CategoryType>(
                "category",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Category id" }
                ),
                resolve: context => categoryRepository.GetCategory(context.GetArgument<int>("id")).Result
            );

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Product id" }
                ),
                resolve: context => productRepository.GetProduct(context.GetArgument<int>("id")).Result
            );
        }
    }
}
