using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class Client
    {
        public void ClientCode(Component comp)
        {
            Console.WriteLine(comp.Thing());
        }
    }
}
