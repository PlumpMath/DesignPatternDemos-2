using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //给出一个抽象接口，以规范产品对象的各个组成部分的建造
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }
}
