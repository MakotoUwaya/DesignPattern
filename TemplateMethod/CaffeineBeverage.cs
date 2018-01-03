using System;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            if (this.CustmerWantsCondiments)
            {
                this.AddCondiments();
            }
        }

        protected abstract　void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("お湯を沸かします");
        }

        private void PourInCup()
        {
            Console.WriteLine("カップに注ぎます");
        }

        public virtual bool CustmerWantsCondiments { get; protected set; } = true;
    }
}
