using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple
{
    public class PizzaFactory
    {
        public IPizza CreatePizza(string pizzaType)
        {
            IPizza pizza = null;

            switch (pizzaType)
            {
                case "チーズ":
                    pizza = new CheesePizza();
                    break;

                default:
                    break;
            }

            return pizza;
        }
    }
}
