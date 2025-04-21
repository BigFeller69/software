using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    class Decorator : Component
    {
        protected Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public void SetComponent(Component component)
        {
            _component = component;
        }
        public override string Thing()
        {
            if (_component != null)
            {
                return _component.Thing();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
