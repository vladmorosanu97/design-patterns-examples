using Adapter.DuckSimulator.Adapter;
using Adapter.DuckSimulator.Models;

namespace Adapter.DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            duck.Quack();
            duck.Fly();

            turkey.Gobble();
            turkey.Fly();

            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
