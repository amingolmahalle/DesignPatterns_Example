using System;
using Facade.SubSystems;

namespace Facade
{
    public class MortgageFacade
    {
        readonly Bank _bank = new();
        readonly Loan _loan = new();
        readonly Credit _credit = new();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

            bool eligible = true;

            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}