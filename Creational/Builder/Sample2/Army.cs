using System.Collections.Generic;
using System.Linq;

namespace Builder.Sample2
{
    public class Army : WarUnit
    {
        public List<WarUnit> Members { get; }

        public Army(string name) : base(name)
        {
            Members = Members != null ? Members.ToList() : new List<WarUnit>();
        }

        public void AddWarrior(Warrior warrior)
        {
            Members.Add(warrior);
        }
        
        public Warrior GetLastWarrior()
        {
            return Members.Last() as Warrior;
        }
    }
}