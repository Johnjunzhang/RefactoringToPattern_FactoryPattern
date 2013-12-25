namespace AbstractFactory
{
    public class ChicagoCheesePizza : Pizza
    {
        public override void Prepare()
        {
            CreateDough();
            CreateSauce();
            CreateCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
    }
}