using System;

namespace Proxy
{
    /// <summary>
    /// Proxy Class
    /// </summary>
    public class OnlinePayment : IMoney
    {
        private IMoney _money;

        public void Pay(int amount)
        {
            if (CanPay(amount))
            {
                _money ??= new CashPayment();

                _money.Pay(amount);
            }
            else
            {
                Console.WriteLine("You can't pay more that 1,000,000");
            }
        }

        private bool CanPay(int amount)
        {
            return amount < 1000000;
        }
    }
}