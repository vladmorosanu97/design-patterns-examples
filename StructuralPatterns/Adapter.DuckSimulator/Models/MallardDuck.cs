using System;

namespace Adapter.DuckSimulator.Models
{
    public class MallardDuck: IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
