using AbstractFactory.ConcreteFactories;

namespace AbstractFactory.Concerns
{
    public interface IAnimalFactory
    {
        public IAnimal GetAnimal(string animalType);
    }
}