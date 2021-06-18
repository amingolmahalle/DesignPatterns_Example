using AbstractFactory.Concerns;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    /// <summary>
    /// Client
    /// </summary>
    public class AnimalClient
    {
        public static IAnimalFactory CreateAnimalFactory(string factoryType)
        {
            IAnimalFactory animalFactory = null;
            
            if (factoryType.Equals("Sea"))
                animalFactory = new SeaAnimalFactory();

            else if (factoryType.Equals("Land"))
                animalFactory = new LandAnimalFactory();

            return animalFactory;
        }
    }
}