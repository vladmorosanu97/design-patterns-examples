﻿using System;

namespace Adapter.DuckSimulator.Models
{
    public class WildTurkey: ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}
