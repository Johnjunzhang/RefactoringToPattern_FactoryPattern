namespace FactoryMethod
{
    public class ChicagoPizzaStore
    {
        private readonly ChicagoPizzaFactory pizzaFactory;

        public ChicagoPizzaStore(ChicagoPizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}