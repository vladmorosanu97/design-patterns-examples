using System;
using System.Collections.Generic;
using Composite.Restaurants.Menus;

namespace Composite.Restaurants.Iterators
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private readonly Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeIterator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
        }
        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            IEnumerator<MenuComponent> iterator = stack.Peek();
          
            if (!iterator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }

            Current = iterator.Current;

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; private set; }

        MenuComponent IEnumerator<MenuComponent>.Current => Current as MenuComponent;


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}