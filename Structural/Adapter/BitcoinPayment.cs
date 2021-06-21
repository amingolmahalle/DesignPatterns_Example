using System;

namespace Adapter
{
    /// <summary>
    /// Adaptee Class
    /// </summary>
    public class BitcoinPayment
    {
        protected void DoTransaction(double price)
        {
            Console.WriteLine($"Paying {price:#,##} Bitcoin");
        }
    }
}