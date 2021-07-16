using System;
using System.Linq;
using Builder.Sample1;
using Builder.Sample2;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Sample 1
            Console.WriteLine("Sample 1:");
            Console.WriteLine("SqlServer Query Builder:");

            new SqlServerQueryBuilder()
                .Table("User")
                .Where("Id", "12")
                .Select(new[] {"Id", "Name", "Age"})
                .Limit(20)
                .Build();

            Console.WriteLine();

            Console.WriteLine("MySql Query Builder:");

            new MySqlQueryBuilder()
                .Table("User")
                .Where("Id", "12")
                .Select(new[] {"Id", "Name", "Age"})
                .Limit(20)
                .Build();
            
            Console.WriteLine();
            Console.WriteLine("##------------------------##");
            Console.WriteLine();
            
            // Sample 2
            Console.WriteLine("Sample 2:");

            IArmyBuilder armyBuilder = WarUnitBuilder.New()
                .WithArmy("Iran")
                .WithWarrior("Javad")
                .WithAge(30)
                .WithWarrior("Mehdi")
                .WithAge(24)
                .WithArmy("America")
                .WithWarrior("David")
                .WithAge(23)
                .WithWarrior("Tom")
                .WithAge(34)
                .WithWarrior("Bob")
                .WithAge(25);

            var warUnitBuilder = (WarUnitBuilder) armyBuilder;

            foreach (var army in warUnitBuilder.Build().Cast<Army>())
            {
                Console.WriteLine($"army name is {army.Name}");

                foreach (var warrior in army.Members.Cast<Warrior>())
                {
                    Console.WriteLine($"warrior name is: {warrior.Name} he/she is {warrior.Age} years old.");
                }

                Console.WriteLine("------------");
            }
        }
    }
}