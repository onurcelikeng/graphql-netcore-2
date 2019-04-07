using System;
using System.Collections.Generic;

namespace GraphQLSample.Core.Models
{
    public sealed class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        List<Product> Products { get; set; }
    }
}
