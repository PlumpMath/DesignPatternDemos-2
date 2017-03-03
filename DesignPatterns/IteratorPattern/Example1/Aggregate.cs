using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example1
{
    //定义一个抽象的聚合类
    public abstract class Aggregate
    {
        //只有一个功能，创建迭代器
        public virtual Iterator CreateIterator()
        {
            return null;
        }
    }
}
