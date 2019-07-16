using System;

namespace Iterator.Restaurants.Iterators
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
