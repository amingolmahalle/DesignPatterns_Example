using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Army : WarUnit
    {
        public List<WarUnit> Members { get; set; }

        public Army(string name,params WarUnit[] members) : base(name)
        {
            Members = members.ToList();
        }

        public override void AssignCoins(long amount)
        {
            var eachShare = amount / Members.Count;

            foreach (var warrior in Members)
            {
                warrior.AssignCoins(eachShare);
            }
        }
    }
}