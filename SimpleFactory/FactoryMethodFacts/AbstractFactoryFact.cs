using AbstractFactory;
using Xunit;

namespace FactoryMethodFacts
{
    public class AbstractFactoryFact
    {
        [Fact]
        public void should_get_new_york_cheese_pizza_given_order_cheese_pizza_in_new_york_store()
        {
            var nyPizzaStore = new NYPizzaStore();
            var orderPizza = nyPizzaStore.OrderPizza("cheese");
            Assert.Equal(typeof(NYCheesePizza), orderPizza.GetType());
        }

        [Fact]
        public void should_get_chicago_cheese_pizza_given_order_cheese_pizza_in_chicago_store()
        {
            var chicagoPizzaStore = new ChicagoPizzaStore();
            var orderPizza = chicagoPizzaStore.OrderPizza("cheese");
            Assert.Equal(typeof(ChicagoCheesePizza), orderPizza.GetType());
        }
    }
}