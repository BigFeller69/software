﻿using System;
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
            
        }

        public override string GetCoffeeType()
        {
            string coffee = base.GetCoffeeType();
            coffee += "\nwith sugar";
            return coffee;
        }
    }
}
