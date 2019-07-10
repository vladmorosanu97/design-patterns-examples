using System;
using AbstractFactory.PizzaStores.IngredientsFactories;
using AbstractFactory.PizzaStores.Stores;

namespace AbstractFactory.PizzaStores
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaIngredientFactory nyPizzaIngredientFactory = new NYPizzaIngredientFactory();
            IPizzaIngredientFactory chicagoPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

            PizzaStore nyPizzaStore = new NYPizzaStore(nyPizzaIngredientFactory);
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore(chicagoPizzaIngredientFactory);

            Pizza nyPizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine(
                $"Name: {nyPizza.Name}, Dough: {nyPizza.Dough}, Sauce: {nyPizza.Sauce}, Cheese: {nyPizza.Cheese}, Clams: {nyPizza.Clams}");

            Pizza chicagoPizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine(
                $"Name: {chicagoPizza.Name}, Dough: {chicagoPizza.Dough}, Sauce: {chicagoPizza.Sauce}, Cheese: {chicagoPizza.Cheese}, Clams: {chicagoPizza.Clams}");
        }
    }
}