using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleVeggiePizza : PizzaBase
    {
        public override string Name => "NYStyleVeggiePizza";

        public override string Dough => throw new NotImplementedException();

        public override string Sauce => throw new NotImplementedException();

        public override IEnumerable<string> Toppings => throw new NotImplementedException();
    }
}
