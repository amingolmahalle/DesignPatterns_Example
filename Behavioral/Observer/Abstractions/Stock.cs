using System;
using System.Collections.Generic;

namespace Observer.Abstractions
{
    /// <summary> The 'Subject' abstract class </summary>
    public abstract class Stock
    {
        private double _price;
        private readonly List<IInvestor> _investors = new();
        // Constructor
        protected Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }
        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }
        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }
        protected void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("------------");
        }
        
        // Gets or sets the price
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
        // Gets the symbol
        public string Symbol { get; }
    }
}