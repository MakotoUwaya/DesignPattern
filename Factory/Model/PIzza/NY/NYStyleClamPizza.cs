using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleClamPizza : PizzaBase
    {
        public override string Name => "NYStyleClamPizza";

        public override string Dough => throw new NotImplementedException();

        public override string Sauce => throw new NotImplementedException();

        public override IEnumerable<string> Toppings => throw new NotImplementedException();
    }
}
