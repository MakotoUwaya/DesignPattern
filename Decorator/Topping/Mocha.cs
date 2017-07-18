namespace Decorator.Topping
{
    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}、モカ";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .20;
        }
    }
}
