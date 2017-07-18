namespace Decorator.Topping
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}、ホイップ";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .15;
        }
    }
}
