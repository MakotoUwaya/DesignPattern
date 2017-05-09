namespace Decorator.Drink
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "ハウスブレンドコーヒー";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
