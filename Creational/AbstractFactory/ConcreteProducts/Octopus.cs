using AbstractFactory.Concerns;

namespace AbstractFactory.ConcreteProducts
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}