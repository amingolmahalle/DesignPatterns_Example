using AbstractFactory.Concerns;

namespace AbstractFactory.ConcreteProducts
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}