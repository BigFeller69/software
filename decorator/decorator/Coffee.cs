using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Coffee : ICoffee
    {
        private double _price;
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public Coffee()
        {
            Price = 1.0;
        }
        public string GetCoffeeType()
        {
            return "coffee";
        }
    }
}
