using System;
using System.Collections.Generic;

namespace Composite.Restaurants.Menus
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator<MenuComponent> CreateIterator();
    }
}
