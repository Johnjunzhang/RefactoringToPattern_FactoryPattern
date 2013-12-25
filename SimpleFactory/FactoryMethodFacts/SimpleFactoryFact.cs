using SimpleFactory;
using Xunit;

namespace FactoryMethodFacts
{
    public class SimpleFactoryFact
    {
        [Fact]
        public void should_get_cheese_pizza_given_order_cheese_pizza()
        {
            var pizzaStore = new PizzaStore();
            var pizza = pizzaStore.OrderPizza("cheese");
            Assert.Equal(typeof(CheesePizza), pizza.GetType());
        }

        [Fact]
        public void should_get_greek_pizza_given_order_greek_pizza()
        {
            var pizzaStore = new PizzaStore();
            var pizza = pizzaStore.OrderPizza("greek");
            Assert.Equal(typeof(GreekPizza), pizza.GetType());
        }
    }
}