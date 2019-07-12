using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.DuckSimulator.Models
{
    public interface IDuck
    {
        void Quack();
        void Fly();
    }
}
