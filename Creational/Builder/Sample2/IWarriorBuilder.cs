using System;

namespace Builder.Sample2
{
    public interface IWarriorBuilder
    {
        IArmyBuilder WithAge(short age);
    }
}