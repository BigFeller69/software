using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public interface ICoffee
    {
        double Price { get; set; }
        string GetCoffeeType();
    }
}
