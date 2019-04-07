using System;
using GraphQL.Types;

namespace GraphQLSample.Models
{
    public class EasyStoreSchema : Schema
    {
        [Obsolete]
        public EasyStoreSchema(Func<Type, GraphType> resolveType) : base(resolveType)
        {
            Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        }
    }
}
