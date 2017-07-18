using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple
{
    public abstract class PizzaStoreBase
    {
        public IPizza OrderPizza(string pizzaType)
        {
            var pizza = this.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract IPizza CreatePizza(string pizzaType);

    }
}
