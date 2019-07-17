using System;
using Composite.Restaurants.Menus;
using Composite.Restaurants.Waitresses;

namespace Composite.Restaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            MenuComponent dinnerMenu = new Menu("Dinner Menu", "Lunch");

            MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent dessertMenu = new Menu("Dessert menu", "Dessert");

            MenuComponent allMenus = new Menu("All Menus", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinnerMenu);
            allMenus.Add(cafeMenu);

            dinnerMenu.Add(new MenuItem("Pasta", "Spaghetti", true, 3.90));
            dinnerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with flakey", true, 1.60));

            Waitress waitress = new Waitress(allMenus);
            //waitress.Print();

            waitress.PrintVegetarianMenu();
        }
    }
}
