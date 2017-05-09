using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        protected string description = "不明な飲み物";
        public virtual string GetDescription()
        {
            return this.description;
        }

        public abstract double Cost();
    }
}
