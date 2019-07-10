using AbstractFactory.PizzaStores.Stores;
using AbstractFactory.PizzaStores.IngredientsFactories;

namespace AbstractFactory.PizzaStores.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public NYPizzaStore(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new CheesePizza(_pizzaIngredientFactory);
            }

            if (type.Equals("clam"))
            {
                return new ClamPizza(_pizzaIngredientFactory);
            }

            return null;
        }
    }
}