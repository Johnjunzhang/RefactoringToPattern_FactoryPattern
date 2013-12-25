using FactoryMethod;
using Xunit;

namespace FactoryMethodFacts
{
    public class FactoryMethodFact
    {
        [Fact]
        public void should_get_new_york_cheese_pizza_given_order_cheese_pizza_in_new_york_store()
        {
            var nyPizzaFactory = new NYPizzaFactory();
            var nyPizzaStore = new NYPizzaStore(nyPizzaFactory);
            var orderPizza = nyPizzaStore.OrderPizza("cheese");
            Assert.Equal(typeof(NYCheesePizza), orderPizza.GetType());
        }

        [Fact]
        public void should_get_chicago_cheese_pizza_given_order_cheese_pizza_in_chicago_store()
        {
            var chicagoPizzaFactory = new ChicagoPizzaFactory();
            var chicagoPizzaStore = new ChicagoPizzaStore(chicagoPizzaFactory);
            var orderPizza = chicagoPizzaStore.OrderPizza("cheese");
            Assert.Equal(typeof(ChicagoCheesePizza), orderPizza.GetType());
        }
    }
}
