﻿using Adapter.DuckSimulator.Models;

namespace Adapter.DuckSimulator.Adapter
{
    public class TurkeyAdapter: IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            _turkey.Fly();
        }
    }
}
