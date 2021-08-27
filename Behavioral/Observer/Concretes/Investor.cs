using System;
using Observer.Abstractions;

namespace Observer.Concretes
{
    /// <summary> The 'ConcreteObserver' class </summary>
    public class Investor : IInvestor
    {
        public Stock Stock { get; set; }

        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
        }
    }
}