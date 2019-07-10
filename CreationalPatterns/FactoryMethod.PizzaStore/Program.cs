using System;
using FactoryMethod.PizzaStores.Store;

namespace FactoryMethod.PizzaStores
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            var pizza =  pizzaStore.OrderPizza("cheese");
            Console.WriteLine( "Name: " + pizza.Name + " Dough: " + pizza.Dough + " Sauce" + pizza.Sauce);

            PizzaStore pizzaStore2 = new ChicagoPizzaStore();
            var pizza2 = pizzaStore2.OrderPizza("cheese");
            Console.WriteLine("Name: " + pizza2.Name + " Dough: " + pizza2.Dough + " Sauce" + pizza2.Sauce);
        }
    }
}
