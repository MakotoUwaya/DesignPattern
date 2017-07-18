using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple
{
    public class PizzaStore
    {
        private PizzaFactory factory;

        /// <summary>
        /// コンストラクタ
        /// ピザを生成するファクトリクラスを必要とする
        /// </summary>
        /// <param name="factory"></param>
        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string pizzaType)
        {          
            var pizza = this.factory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}
