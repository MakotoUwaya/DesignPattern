namespace Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static object lockObject = new object();

        /// <summary>
        ///　スタティック初期化子でインスタンスを初期化することで、スレッドセーフになる
        ///　デメリットは、一度も使用しない可能性があるオブジェクトを生成してしまうこと
        ///　作成処理や、作成後のメモリ使用が負担にならない場合はこちらの方法が確実な手段となる
        /// </summary>
        private static ChocolateBoiler instance;
        public static ChocolateBoiler Instance
        {
            get
            {
                // 同期化処理はコストが高いため、二重チェックで実行する
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        instance = new ChocolateBoiler();
                    }
                    
                }
                return instance;
            }
        }

        private ChocolateBoiler()
        {
            this.empty = true;
            this.boiled = false;
        }

        public void Fill()
        {
            if (!this.empty)
            {
                return;
            }

            this.empty = false;
            this.boiled = false;
        }

        public void Drain()
        {
            if (this.empty || !this.boiled)
            {
                return;
            }
            this.empty = true;
        }

        public void Boil()
        {
            if (this.empty || this.boiled)
            {
                return;
            }

            this.boiled = true;
        }

        public override string ToString()
        {
            return $"empty:{this.empty} boiled:{this.boiled}";
        }
    }
}
