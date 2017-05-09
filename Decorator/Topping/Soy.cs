namespace Decorator.Topping
{
    public class Soy : CondimentDecorator
    {
        private Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}、豆乳";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .15;
        }
    }
}
