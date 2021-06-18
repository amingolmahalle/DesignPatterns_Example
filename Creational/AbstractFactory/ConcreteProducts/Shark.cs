using AbstractFactory.Concerns;

namespace AbstractFactory.ConcreteProducts
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}