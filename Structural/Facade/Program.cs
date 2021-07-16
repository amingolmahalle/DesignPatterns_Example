using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MortgageFacade mortgageFacade = new MortgageFacade();

            Customer customer = new Customer("David Beckham");

            bool isEligible = mortgageFacade.IsEligible(customer, 3000000);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(isEligible ? "Eligible for a loan" : "Not Eligible for a loan");
        }
    }
}