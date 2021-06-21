namespace Adapter
{
    /// <summary>
    /// Client
    /// </summary>
    public class Shop
    {
        public void Purchase(IIranianBank bank, double price)
        {
            bank.Payment(price);
        }
    }
}