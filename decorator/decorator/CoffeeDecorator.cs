using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private double _cost;
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
        private ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public virtual string GetCoffee()
        {
            return _coffee.GetCoffee();
        }
        public override string ToString()
        {
            return $"{this.GetCoffee()} {Price}";
        }
    }
}
