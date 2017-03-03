using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example1
{
    //外禀迭代器的迭代过程使用了集合中的元素，通过集合向外界提供了访问自身内部元素的机会。
    public class Client1
    {
        private Iterator _iterator;
        private Aggregate _aggregate = new ConcreteAggregate();

        public void Operation()
        {
            //获取迭代器
            _iterator = _aggregate.CreateIterator();
            while (!_iterator.IsDone())
            {
                Console.WriteLine(_iterator.CuttentItem());
                _iterator.Next();
            }
        }
    }
}
