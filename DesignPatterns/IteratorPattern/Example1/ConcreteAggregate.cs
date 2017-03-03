using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example1
{
    //定义一个具体的聚合类
    public class ConcreteAggregate : Aggregate
    {
        //存储元素的集合
        private object[] objs = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Firday", "Saturday" };

        //获得元素个数
        public int Size()
        {
            return objs.Length;
        }

        //获取指定序号的元素
        public object GetElement(int index)
        {
            if (index < 0 || index > objs.Length)
            {
                return null;
            }

            return objs[index];
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
