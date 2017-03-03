using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example1
{
    //定义具体的迭代器类
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int index = 0;
        private int size = 0;

        //根据不同的聚合进行初始化
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            this.size = aggregate.Size();
            this.index = 0;
        }
        public void First()
        {
            index = 0;
        }

        public void Next()
        {
            if (index < size)
                index++;
        }

        public bool IsDone()
        {
            return index >= size;
        }

        public object CuttentItem()
        {
            return aggregate.GetElement(index);
        }
    }
}
