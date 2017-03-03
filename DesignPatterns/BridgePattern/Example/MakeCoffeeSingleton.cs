using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example
{
    public sealed class MakeCoffeeSingleton
    {
        private static MakeCoffee instance;

        public MakeCoffeeSingleton( MakeCoffee makeCoffee)
        {
            instance = makeCoffee;
        }

        public static MakeCoffee Instance()
        {
            return instance;
        }
    }
}
