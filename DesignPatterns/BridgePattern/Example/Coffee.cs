using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example
{
    public abstract class Coffee
    {
        private MakeCoffee _makeCoffee;
        public Coffee()
        {
            this._makeCoffee = MakeCoffeeSingleton.Instance();
        }

        public MakeCoffee MakeCoffee()
        {
            return this._makeCoffee;
        }

        public abstract void Make();
    }
}
