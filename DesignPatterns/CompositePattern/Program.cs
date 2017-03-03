using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //组合模式
    //什么是组合模式呢？简单来说组合模式就是将对象合成树形结构以表示“部分整体”的层次结构，组合模式使用户对单个对象和组合对象使用具有一致性。
    //组合模式（Composite Pattern）有时候又叫部分-整体模式，它使我们在树型结构的问题中，模糊了简单元素和负责元素的概念，客户程序可以向处理简单元素一样处理负责元素，从而使得客户程序与复杂元素的的内部结构解耦。
    //组合模式让你可以优化处理递归或分级数据结构。关于分级数据结构的一个经典例子就是电脑中的文件系统。文件系统由目录和文件组成，没有目录都可以有子目录和文件。实际上文件系统就是按照递归来组织的，那么就可以组合模式来描述这种结构。
    //适用性
    //以下情况下适用Composite模式：
    //想表示对象的部分—整体层次结构
    //希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。
        //组合模式解耦了客户程序与复杂元素内部结构，从而使客户程序可以向处理简单元素一样来处理复杂元素。如果你想要创建层次结构，并可以在其中以相同的方式对待所有元素，那么组合模式就是最理想的选择。
        //组成模式的实现根据实现接口的区别分为两种形式，分别称为安全模式和透明模式。合成模式可以不提供父对象的管理方法，但合成模式必须在合适的地方提供子对象的管理方法（如：add,remove,getchild等）。
    //透明方式：
        //作为第一种选择，在Component里面声明所有的用来管理子对象的方法，包括Add(),Remove(),以及GetChild()方法。这样做的好处是所有的构件类都有相同的接口，在客户端看来，树叶类对象与合成类对象的区别起码在接口层次上消失了，客户端可以等同的对待所有对象，这就是透明形式的合成模式。
        //这个选择的缺点是不够安全，因为树叶类对象和合成类对象在本质上是有区别的。树叶类对象不可能有下一个层次的对象，因此Add(),Remove(),GetChild()方法没有意义，是在编译时期不会出错，而只会在运行时期出错。
    //安全方式
        //安全方式是在Composite类里面声明所有的用来管理子对象的方法，这样的做法是安全的做法，因为树叶类型的对象根本就没有管理子对象的方法，因此，如果客户端对树叶类对象使用这些方法，程序会在编译时期出错。 这个方式的缺点是不够透明，因为树叶类和合成类将具有不同的接口。
 
    //  组合模式参与者：
    //◊ Component
    //  ° 声明组合中对象的接口；
    //  ° 实现全部类中公共接口的默认行为；
    //  ° 声明访问和管理子类的接口；
    //  ° （可选择）定义接口提供在递归结构中访问父类。
    //◊ Leaf
    //  ° 表示在组合对象中叶子节点对象，没有子节点；
    //  ° 定义组合对象中的初始行为。
    //◊ Composite
    //  ° 定义Component子类的行为；
    //  ° 保存Component子类；
    //  ° 实现Component接口的子类关联操作。
    //◊ Client
    //  ° 通过Component接口组合多个对象。
    
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite com = new Composite("Composite X");
            com.Add(new Leaf("Leaf XA"));
            com.Add(new Leaf("Leaf XB"));
            root.Add(com);
            root.Display(1);
            Console.ReadKey();
        }
    }

    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);

        public abstract void Remove(Component c);
        public abstract void Display(int index);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int index)
        {
            Console.WriteLine(new String('-', index) + name);
        }
    }

    public class Composite : Component
    {
        public Composite(string name) : base(name) { }
        

        IList<Component> list = new List<Component>();
        public override void Add(Component c)
        {
            list.Add(c);
        }

        public override void Remove(Component c)
        {
            list.Remove(c);
        }

        public override void Display(int index)
        {
            Console.WriteLine(new String('-', index) + name);
            foreach (var c in list)
            {
                c.Display(index + 2);
            }
        }
    }
}
