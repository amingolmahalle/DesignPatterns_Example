namespace Decorator
{
    /// <summary>
    /// ConcreteDecorator class
    /// </summary>
    public class VegetablePizzaDecorator : PlainPizzaDecorator
    {
        public VegetablePizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return base.MakePizza() + AddVegetables();
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}