using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example2
{
    public class ConcreteAggregate : Aggregate
    {
        private static object[] objs = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        private class ConcreteIterator : Iterator
        {
            private int _index = 0;
            public void First()
            {
                _index = 0;
            }

            public void Next()
            {
                if (_index < objs.Length)
                    _index++;
            }

            public bool IsDone()
            {
                return _index == objs.Length;
            }

            public object CurrentItem()
            {
                return objs[_index];
            }
        }

        public int Size()
        {
            return objs.Length;
        }

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
            return new ConcreteIterator();
        }
    }
}
