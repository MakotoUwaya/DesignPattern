using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PizzaStoreBase
    {
        public PizzaBase OrderPizza(string pizzaType)
        {
            var pizza = this.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract PizzaBase CreatePizza(string pizzaType);

    }
}
