﻿using System;
using System.Collections.Generic;

namespace Factory.Simple
{
    public class CheesePizza : PizzaBase
    {
        public override string Name => "CheesePizza";

        public override string Dough => throw new NotImplementedException();

        public override string Sauce => throw new NotImplementedException();

        public override IEnumerable<string> Toppings => throw new NotImplementedException();
    }
}
