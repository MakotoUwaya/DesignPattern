namespace Decorator.Drink
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "カフェイン抜き";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
