namespace Decorator
{
    /// <summary>
    /// ConcreteComponent class
    /// </summary>
    public class PlainPizza : IPizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}