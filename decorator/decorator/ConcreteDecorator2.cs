using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(Component comp) : base(comp)
        {
            
        }
        public override string Thing()
        {
            return "2";
        }
    }
}
