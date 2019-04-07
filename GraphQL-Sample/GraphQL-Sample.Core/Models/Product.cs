using System;
namespace GraphQLSample.Core.Models
{
    public sealed class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

    }
}
