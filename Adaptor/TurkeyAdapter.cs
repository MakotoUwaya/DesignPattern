namespace Adaptor
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            this.turkey.Gobble();
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                this.turkey.Fly();
            }
        }

    }
}
