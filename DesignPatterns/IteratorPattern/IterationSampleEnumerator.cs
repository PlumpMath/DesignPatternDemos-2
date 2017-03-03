using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorPattern
{
    //手动实现迭代器细节
    public class IterationSampleEnumerator : IEnumerator
    {
        public IterationSample parent;//迭代的对象
        public int position;//当前游标的位置

        public IterationSampleEnumerator(IterationSample parent)
        {
            this.parent = parent;
            this.position = -1;//数组元素的下标从0开始，初始时默认游标位置为-1，即在第一个元素之前。
        }

        public bool MoveNext()
        {
            if (position != parent.values.Length)//判断当前位置是否为最后一个，不是position++
            {
                position++;
            }
            return position < parent.values.Length;
        }


        public object Current
        {
            get
            {
                if (position == -1 || position == parent.values.Length)//位置不对
                {
                    throw new InvalidOperationException();
                }
                var index = position + parent.startingPoint;//考虑自定义开始位置的情况。
                index = index % parent.values.Length;
                return parent.values[index];
            }
        }

        public void Reset()
        {
            position = -1;//游标设置-1
        }
    }
}
