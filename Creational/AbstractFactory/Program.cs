using System;
using AbstractFactory.Concerns;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAnimalFactory sea = new SeaAnimalFactory();
            var seaClient = sea.GetAnimal("Octopus");

            Console.WriteLine(seaClient.Speak());
            Console.WriteLine();
            
            
            IAnimalFactory land = new LandAnimalFactory();
            var landClient = land.GetAnimal("Dog");

            Console.WriteLine(landClient.Speak());
        }
    }
}