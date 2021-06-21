using System;

namespace Adapter
{
    public class SamanBank:IIranianBank
    {
        public void Payment(double price)
        {
            Console.WriteLine($"Paying {price:#,##} Rial via Saman Bank");
        }
    }
}