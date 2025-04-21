using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(Component comp) : base(comp)
        {

        }

        public override string Thing()
        {
            return "1";
        }
    }
}
