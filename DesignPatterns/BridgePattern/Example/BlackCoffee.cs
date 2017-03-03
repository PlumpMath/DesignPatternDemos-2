using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example
{
    public class BlackCoffee : MakeCoffee
    {
        public override void Making()
        {
            Console.WriteLine("原味咖啡");
        }
    }
}
