using System;

namespace Adapter
{
    public class SinaBank :IIranianBank
    {
        public void Payment(double price)
        {
            Console.WriteLine($"Paying {price:#,##} Rial via Sina Bank");
        }
    }
}