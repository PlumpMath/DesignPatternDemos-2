using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorPattern
{
    //手动实现迭代器
    public class IterationSample : IEnumerable
    {
        //数据对象
        public Object[] values;
        //迭代的开始坐标
        public int startingPoint;

        public IterationSample(Object[] values, int startingPoint)
        {
            this.values = values;
            this.startingPoint = startingPoint;
        }

        //实现迭代
        public IEnumerator GetEnumerator()
        {
            return new IterationSampleEnumerator(this);
        }
    }
}
