using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Composite.Restaurants.Menus;

namespace Composite.Restaurants.Iterators
{
    public class NullIterator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public MenuComponent Current { get; } = null;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}