namespace Decorator
{
    /// <summary>
    /// ConcreteDecorator class
    /// </summary>
    public class ChickenPizzaDecorator : PlainPizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return base.MakePizza() + AddChicken();
        }

        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
}