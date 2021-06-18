using AbstractFactory.Concerns;

namespace AbstractFactory.ConcreteProducts
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
             return "Meow Meow Meow";
        }
    }
}