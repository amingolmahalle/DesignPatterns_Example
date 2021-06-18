using AbstractFactory.Concerns;

namespace AbstractFactory.ConcreteProducts
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark Bark";
        }
    }
}