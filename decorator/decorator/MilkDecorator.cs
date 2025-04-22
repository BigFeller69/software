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
            Cost = 0.5;
            Price = coffee.Price + Cost;
        }
        public override string GetCoffee()
        {
            string coffee = base.GetCoffee();
            coffee += "\nwith milk";
            return coffee;
        }
        
    }
}
