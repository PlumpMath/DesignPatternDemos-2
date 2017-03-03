using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Example
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
