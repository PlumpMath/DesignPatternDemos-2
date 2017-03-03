using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Example
{
    //减法
    public class Minus : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
