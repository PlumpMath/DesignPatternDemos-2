using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example2
{
    //内禀迭代器实现的关键是在集合的内部定义一个私有的具体迭代子类，由它来负责迭代器的所有功能。
    //因为它是集合的私有类，所以它的对象可以遍历集合的内部元素，实现迭代器定义的所有接口，
    //而集合本身并未向外界提供访问自己内部元素的接口。
    public class Client2
    {
        private Iterator _iterator;
        private Aggregate _aggregate = new ConcreteAggregate();
        public void Operation()
        {
            _iterator = _aggregate.CreateIterator();
            while (!_iterator.IsDone())
            {
                Console.WriteLine(_iterator.CurrentItem());
                _iterator.Next();
            }
        }
    }
}
