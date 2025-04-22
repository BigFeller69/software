using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
            Cost = 0.2;
            Price = coffee.Price + Cost;
        }

        public override string GetCoffee()
        {
            string coffee = base.GetCoffee();
            coffee += "\nwith sugar";
            return coffee;
        }
    }
}
