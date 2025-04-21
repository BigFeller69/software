using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class ConcreteComponent : Component
    {
        public override string Thing()
        {
            return "0 ";
        }
    }
}
