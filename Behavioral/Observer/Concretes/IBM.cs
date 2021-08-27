using Observer.Abstractions;

namespace Observer.Concretes
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}