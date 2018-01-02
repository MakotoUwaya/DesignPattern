using Factory.Model.PIzza.Chicago;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStoreBase
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public ChicagoStylePizzaStore(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        protected override PizzaBase CreatePizza(string pizzaType)
        {
            switch (pizzaType.ToLower())
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza(this.pizzaIngredientFactory);
                case "veggie":
                    return new ChicagoStyleVeggiePizza(this.pizzaIngredientFactory);
                case "clam":
                    return new ChicagoStyleClamPizza(this.pizzaIngredientFactory);
                case "pepperroni":
                    return new ChicagoStylePepperoniPizza(this.pizzaIngredientFactory);
                default:
                    return null;
            }
        }
    }
}
