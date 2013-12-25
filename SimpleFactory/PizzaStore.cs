namespace SimpleFactory
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("greek"))
                pizza = new GreekPizza();
             else if (type.Equals("pepperoni"))
                 pizza = new PepperoniPizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}