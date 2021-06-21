namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            IIranianBank melliBank = new MelliBank();
            shop.Purchase(melliBank, 5000);

            IIranianBank bitcoinPayment = new BitcoinAdapter();
            shop.Purchase(bitcoinPayment, 2000000);
        }
    }
}