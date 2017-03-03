using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //担任这个角色的类调用具体建造者以创建产品对象。指导者角色并没没用产品类的具体知识，真正拥有产品类的具体知识的是具体建造者对象。
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
