using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Example
{
    //加法
    public class Plus : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
