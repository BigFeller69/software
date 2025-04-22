using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class CoffeeDecorator : ICoffee
    {
        private ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public virtual string GetCoffeeType()
        {
            return _coffee.GetCoffeeType();
        }
    }
}
