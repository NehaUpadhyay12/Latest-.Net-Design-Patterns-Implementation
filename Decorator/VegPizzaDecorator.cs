using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return base.MakePizza() + " with vegtables";
        }
    }
}
