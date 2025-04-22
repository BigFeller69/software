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
        private double _cost = 1.0;
        public double Cost
        {
            get => _cost;
            set => _cost = value;
        }
        private double _price;
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public Coffee()
        {
            Price = Cost;
        }
        public string GetCoffee()
        {
            return "coffee";
        }
        public override string ToString()
        {
            return $"{this.GetCoffee()}  {Price}";
        }
    }
}
