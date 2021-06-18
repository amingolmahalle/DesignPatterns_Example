using System;
using System.Collections.Generic;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.AddAnimal("Cow");
            animal.RemoveAnimal("Cat");

            Animal cloneOfAnimal = (Animal) animal.GetClone();

            List<string> cloneOfAnimalList = cloneOfAnimal.GetAnimals();

            cloneOfAnimalList.Add("Bird");

            cloneOfAnimalList.Remove("Bear");

            Console.WriteLine("Animals:");
            foreach (var item in animal.GetAnimals())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Clone Of Animals:");
            foreach (var item in cloneOfAnimalList)
            {
                Console.WriteLine(item);
            }
        }
    }
}