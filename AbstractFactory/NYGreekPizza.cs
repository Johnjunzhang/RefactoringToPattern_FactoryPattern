namespace AbstractFactory
{
    public class NYGreekPizza : Pizza
    {
        public override void Prepare()
        {
            CreateDough();
            CreateSauce();
        }

        public Dough CreateDough()
        {
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            return new Sauce();
        }
    }
}