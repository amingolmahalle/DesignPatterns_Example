using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteQueryBuilder concreteQueryBuilder = new ConcreteQueryBuilder();

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