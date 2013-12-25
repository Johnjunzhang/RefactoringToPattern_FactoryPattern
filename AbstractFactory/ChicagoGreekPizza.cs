namespace AbstractFactory
{
    public class ChicagoGreekPizza : Pizza
    {
        public override void Prepare()
        {
            CreateSauce();
            CreateCheese();
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