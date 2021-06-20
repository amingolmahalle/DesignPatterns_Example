
namespace Proxy
{
   internal class Program
    {
        static void Main(string[] args)
        {
            IMoney onlinePayment = new OnlinePayment();
            
            onlinePayment.Pay(5000);
            onlinePayment.Pay(1000000);
        }
    }
}