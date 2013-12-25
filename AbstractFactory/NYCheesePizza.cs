namespace AbstractFactory
{
    public class NYCheesePizza : Pizza
    {
        public override void Prepare()
        {
            CreateDough();
            CreateSauce();
            CreateCheese();
        }

        public Dough CreateDough()
        {
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            return new Cheese();
        }
    }
}