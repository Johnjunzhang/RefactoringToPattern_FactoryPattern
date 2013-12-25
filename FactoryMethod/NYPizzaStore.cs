namespace FactoryMethod
{
    public class NYPizzaStore
    {
        private readonly NYPizzaFactory simplePizzaFacotry;

        public NYPizzaStore(NYPizzaFactory nyPizzaFactory)
        {
            simplePizzaFacotry = nyPizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = simplePizzaFacotry.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}