namespace FactoryMethod
{
    public class NYPizzaFactory : SimplePizzaFacotry
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
                pizza = new NYCheesePizza();
            else if (type.Equals("greek"))
                pizza = new GreekPizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            return pizza;
        }
    }
}