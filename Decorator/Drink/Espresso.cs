namespace Decorator.Drink
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "エスプレッソ";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
