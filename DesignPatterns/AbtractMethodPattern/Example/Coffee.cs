using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    public class Coffee : KFCDrink
    {
        public override string Display()
        {
            return "Coffee + 1";
        }
    }
}
