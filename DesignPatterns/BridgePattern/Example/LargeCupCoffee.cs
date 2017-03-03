using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example
{
    public class LargeCupCoffee:Coffee
    {
        public override void Make()
        {
            MakeCoffee makeCoffee = this.MakeCoffee();
            Console.Write("大杯");
            makeCoffee.Making();
        }
    }
}
