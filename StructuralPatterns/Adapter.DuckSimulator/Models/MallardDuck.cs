using System;
using System.Collections.Generic;
using System.Text;

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
