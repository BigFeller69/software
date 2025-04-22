using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace standard
{
    public class Coffee
    {

        private string _regularCoffee;
        public string RegularCoffee
        {
            get => _regularCoffee;
            set => _regularCoffee = value;
        }

        public Coffee()
        {
            RegularCoffee = "";
        }
    }
}
