namespace Adapter
{
    /// <summary>
    /// Adapter Class
    /// </summary>
    public class BitcoinAdapter : BitcoinPayment, IIranianBank
    {
        public void Payment(double price)
        {
            var convertedPrice = price / 1000;

            DoTransaction(convertedPrice);
        }
    }
}