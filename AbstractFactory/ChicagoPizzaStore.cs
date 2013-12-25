namespace AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
                pizza = new ChicagoCheesePizza();
            else if (type.Equals("greek"))
                pizza = new ChicagoGreekPizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            return pizza;
        }
    }
}