namespace Builder.Sample2
{
    public interface IArmyBuilder
    {
        IWarriorBuilder WithWarrior(string name);
        
        IArmyBuilder WithArmy(string name);
    }
}