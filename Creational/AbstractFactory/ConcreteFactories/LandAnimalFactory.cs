using AbstractFactory.Concerns;
using AbstractFactory.ConcreteProducts;

namespace AbstractFactory.ConcreteFactories
{
    public class LandAnimalFactory : IAnimalFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            IAnimal animalChoice = null;

            if (animalType.Equals("Dog"))
            {
                animalChoice = new Dog();
            }
            else if (animalType.Equals("Cat"))
            {
                animalChoice = new Cat();
            }

            else if (animalType.Equals("Lion"))
            {
                animalChoice = new Lion();
            }

            return animalChoice;
        }
    }
}