using System.Collections.Generic;
using Factory.Model.Ingredient;

namespace Factory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISouce CreateSouce();
        ICheese CreateCheese();
        IEnumerable<IVeggies> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
