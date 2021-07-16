using System;

namespace Facade.SubSystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Check credit for " + customer.Name);
            
            return true;
        }
    }
}