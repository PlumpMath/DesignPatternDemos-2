using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example1
{
    //第一个迭代器接口
    public interface Iterator
    {
        //迭代器定位到聚合的第一个元素
        void First();

        //遍历下一个
        void Next();

        //判断是否完成遍历
        bool IsDone();

        //获得当前遍历的项
        object CuttentItem();
    }
}
