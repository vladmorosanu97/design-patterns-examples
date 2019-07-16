using System.Collections.Generic;
using Iterator.Restaurants.Menus;
using Iterator.Restaurants.Waitresses;

namespace Iterator.Restaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinnerMenu dinnerMenu = new DinnerMenu();

            Waitress waitress = new Waitress(new List<IMenu> {pancakeHouseMenu, dinnerMenu});
            waitress.PrintMenu();
        }
    }
}