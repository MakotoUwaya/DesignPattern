using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Simple
{
    public interface IPizza
    {
        string Name { get; set; }
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
