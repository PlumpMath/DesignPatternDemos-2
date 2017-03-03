using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    public class Wings : KFCFood
    {
        public override string Display()
        {
            return "Wings + 1";
        }
    }
}
