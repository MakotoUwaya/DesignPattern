using Factory.Model.PIzza.Chicago;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStoreBase
    {
        protected override PizzaBase CreatePizza(string pizzaType)
        {
            switch (pizzaType.ToLower())
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "pepperroni":
                    return new ChicagoStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
