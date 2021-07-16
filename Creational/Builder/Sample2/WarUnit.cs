namespace Builder.Sample2
{
    public abstract class WarUnit
    {
        public string Name { get; }

        protected WarUnit(string name)
        {
            Name = name;
        }
    }
}