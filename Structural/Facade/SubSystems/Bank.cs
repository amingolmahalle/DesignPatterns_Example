using System;

namespace Facade.SubSystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine("Check bank for " + customer.Name);
            
            return true;
        }
    }
}