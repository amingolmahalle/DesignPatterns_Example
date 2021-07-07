namespace Decorator
{
    /// <summary>
    /// Decorator Class
    /// </summary>
    public abstract class PlainPizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        protected PlainPizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string MakePizza()
        {
           return _pizza.MakePizza();
        }
    }
}