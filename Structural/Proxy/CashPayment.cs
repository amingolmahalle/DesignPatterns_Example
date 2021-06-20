using System;

namespace Proxy
{
    /// <summary>
    /// Real Subject Class
    /// </summary>
    public class CashPayment : IMoney
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"You payed {amount} ");
        }
    }
}