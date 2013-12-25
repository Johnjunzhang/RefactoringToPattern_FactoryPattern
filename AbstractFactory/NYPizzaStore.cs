namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
                pizza = new NYCheesePizza();
            else if (type.Equals("greek"))
                pizza = new NYGreekPizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            return pizza;
        }
    }
}