namespace Composite
{
    public abstract class WarUnit
    {
        public string Name { get; set; }
        
        protected WarUnit(string name)
        {
            Name = name;
        }

        public abstract void AssignCoins(long amount);

    }
}