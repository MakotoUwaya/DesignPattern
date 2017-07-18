namespace Decorator.Topping
{
    public class Milk : CondimentDecorator
    {
        private Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}、ミルク";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .10;
        }
    }
}
