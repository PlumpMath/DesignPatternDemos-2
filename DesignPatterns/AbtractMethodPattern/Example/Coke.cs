using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    public class Coke : KFCDrink
    {
        public override string Display()
        {
            return "Coke + 1";
        }
    }
}
