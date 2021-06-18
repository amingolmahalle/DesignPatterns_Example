using System;
using Builder.ConcreteBuilders;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            QueryBuilderCreator concreteQueryBuilder = new QueryBuilderCreator();

            Console.WriteLine("SqlServer Query Builder:");

            concreteQueryBuilder
                .Construct(new SqlServerQueryBuilder())
                .Table("User")
                .Where("Id", "12")
                .Select(new[] {"Id", "Name", "Age"})
                .Limit(20)
                .Build();

            Console.WriteLine();

            Console.WriteLine("MySql Query Builder:");

            concreteQueryBuilder
                .Construct(new MySqlQueryBuilder())
                .Table("User")
                .Where("Id", "12")
                .Select(new[] {"Id", "Name", "Age"})
                .Limit(20)
                .Build();
        }
    }
}