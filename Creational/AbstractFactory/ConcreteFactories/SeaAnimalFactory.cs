using AbstractFactory.Concerns;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories
{
    public class SeaAnimalFactory : IAnimalFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            IAnimal animalChoice = null;

            if (animalType.Equals("Shark"))
            {
                animalChoice = new Shark();
            }

            else if (animalType.Equals("Octopus"))
            {
                animalChoice = new Octopus();
            }

            return animalChoice;
        }
    }
}