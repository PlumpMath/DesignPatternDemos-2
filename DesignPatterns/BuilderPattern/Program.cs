using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //建造者模式就是将一个复杂对象的构造与它的表示分离，使同样的构建过程可以创建不同的表示。
    //实现要点：
        //1．建造者模式主要用于“分步骤构建一个复杂的对象”，在这其中“分步骤”是一个稳定的算法，而复杂对象的各个部分则经常变化。
        //2．产品不需要抽象类，特别是由于创建对象的算法复杂而导致使用此模式的情况下或此模式应用于产品的生成过程，其最终结果可能差异很大，不大可能提炼出一个抽象产品类。
        //3．创建者中的创建子部件的接口方法不是抽象方法而是空方法，不进行任何操作，具体的创建者只需要覆盖需要的方法就可以。
        //4．抽象工厂模式解决“系列对象”的需求变化，而Builder模式解决“对象部分”的需求变化，建造者模式常和组合模式(Compsite Pattern)结合使用。

    //效果
        //建造者模式的使用使得产品的内部表象可以独立的变化。使用建造者模式可以使客户端不必知道产品内部组成的细节。
        //每一个Builder都相对独立，而与其它的Builder无关。
        //可使对构造过程更加精细控制。
        //将构建代码和表示代码分开。
        //建造模式的缺点在于难于应付“分步骤构建算法”的需求变动。

    //适用性：
        //以下情况应当使用建造者模式：
        //需要生产的产品对象有复杂的内部结构
        //需要生产的产品对象的属性相互依赖，建造者模式可以强迫生成顺序
        //在对象创建过程中会使用到系统中的一些其它对象，这些对象在产品对象的创建过程中不容易得到。
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            IBuilder b1 = new ConcreteBuilder1();
            d.Construct(b1);
            Product p1 = b1.GetResult();
            p1.ShowResult();

            IBuilder b2 = new ConcreteBuilder2();
            d.Construct(b2);
            Product p2 = b2.GetResult();
            p2.ShowResult();

            Console.ReadKey();
        }
    }
}
