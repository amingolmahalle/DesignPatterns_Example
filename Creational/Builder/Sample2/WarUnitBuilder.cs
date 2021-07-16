using System.Collections.Generic;
using System.Linq;

namespace Builder.Sample2
{
    public class WarUnitBuilder : IArmyBuilder, IWarriorBuilder
    {
        private readonly List<WarUnit> _warUnits;

        private WarUnitBuilder()
        {
            _warUnits = new List<WarUnit>
            {
                new Army("root")
            };
        }

        public static IArmyBuilder New()
        {
            return new WarUnitBuilder();
        }

        public IArmyBuilder WithArmy(string name)
        {
            _warUnits.Add(new Army(name));
            return this;
        }

        public IWarriorBuilder WithWarrior(string name)
        {
            var lastArmy = _warUnits.Last() as Army;
            
            lastArmy.AddWarrior(new Warrior(name));
            
            return this;
        }

        public IArmyBuilder WithAge(short age)
        {
            var lastArmy = _warUnits.Last() as Army;
            var lastWarrior = lastArmy.GetLastWarrior();
            lastWarrior.Age = age;
            
            return this;
        }

        public List<WarUnit> Build()
        {
            return _warUnits;
        }
    }
}