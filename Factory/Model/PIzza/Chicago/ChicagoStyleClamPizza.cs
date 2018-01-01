using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStyleClamPizza : PizzaBase
    {
        public override string Name => "ChicagoStyleClamPizza";

        public override string Dough => throw new NotImplementedException();

        public override string Sauce => throw new NotImplementedException();

        public override IEnumerable<string> Toppings => throw new NotImplementedException();
    }
}
