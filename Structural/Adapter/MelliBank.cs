using System;

namespace Adapter
{
    public class MelliBank : IIranianBank
    {
        public void Payment(double price)
        {
            Console.WriteLine($"Paying {price:#,##} Rial via Melli Bank");
        }
    }
}