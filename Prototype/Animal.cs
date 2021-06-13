using System.Collections.Generic;

namespace Prototype
{
    public class Animal : ICloneable
    {
        private List<string> _animalList;

        public Animal()
        {
            _animalList = LoadDataFromDatabase();
        }

        public ICloneable GetClone()
        {
            return new Animal();
        }

        public void AddAnimal(string title)
        {
            _animalList.Add(title);
        }

        public void RemoveAnimal(string title)
        {
            _animalList.Remove(title);
        }

        public List<string> GetAnimals()
        {
            return _animalList;
        }

        private List<string> LoadDataFromDatabase()
        {
            _animalList = new List<string>
            {
                "Cat",
                "Dog",
                "Rabbit",
                "Snake",
                "Bear"
            };

            return _animalList;
        }
    }
}