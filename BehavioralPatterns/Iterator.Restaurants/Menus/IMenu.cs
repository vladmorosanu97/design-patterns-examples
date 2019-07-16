using Iterator.Restaurants.Iterators;

namespace Iterator.Restaurants.Menus
{
    public interface IMenu
    {
        IIterator CreateIterator();
    }
}
