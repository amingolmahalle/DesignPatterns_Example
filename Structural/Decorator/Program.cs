using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);

            Console.WriteLine();

            ChickenPizzaDecorator chickenPizzaDecoratorObj = new ChickenPizzaDecorator(plainPizzaObj);
            string chickenPizzaDecorator = chickenPizzaDecoratorObj.MakePizza();
            Console.WriteLine(chickenPizzaDecorator);

            Console.WriteLine();

            VegetablePizzaDecorator vegetablePizzaDecoratorObj = new VegetablePizzaDecorator(plainPizzaObj);
            string vegetablePizzaDecorator = vegetablePizzaDecoratorObj.MakePizza();
            Console.WriteLine(vegetablePizzaDecorator);
        }
    }
}