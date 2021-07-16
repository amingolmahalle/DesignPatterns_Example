namespace Builder.Sample2
{
    public class Warrior : WarUnit
    {
        public short Age { get; set; }

        public Warrior(string name) : base(name)
        {
        }
    }
}