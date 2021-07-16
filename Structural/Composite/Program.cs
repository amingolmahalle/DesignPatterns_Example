
namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var javad = new Warrior("javad");
            var mehdi = new Warrior("Mehdi");

            var iran = new Army("Iran", javad, mehdi);

            var david = new Warrior("David");
            var bob = new Warrior("Bob");
            var tom = new Warrior("Tom");

            var america = new Army("America", david, bob, tom);

            var root = new Army("Root", iran, america);

            root.AssignCoins(600);
        }
    }
}