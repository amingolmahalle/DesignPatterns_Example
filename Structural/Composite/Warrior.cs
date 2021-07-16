namespace Composite
{
    public class Warrior : WarUnit
    {
        public long Coins { get; private set; }

        public Warrior(string name) :base(name)
        {
        }

        public override void AssignCoins(long amount)
        {
            Coins = amount;
        }
    }
}