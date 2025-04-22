using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            Price = coffee.Price + 0.5;
        }
        public override string GetCoffeeType()
        {
            string coffee = base.GetCoffeeType();
            coffee += "\nwith milk";
            return coffee;
        }
        
    }
}
