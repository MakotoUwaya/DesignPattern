namespace Decorator.Drink
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "ダークロースト";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
