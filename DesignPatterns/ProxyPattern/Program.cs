using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern.Example;

namespace ProxyPattern
{
    //　代理模式提供了一个中介控制对某个对象的访问。现实生活中，我们可能会用支票在市场交易中用来代替现金，支票就是账户中资金的代理。
    //  代理模式参与者：

  //◊ Proxy
  //  ° 维持一个引用，使得代理可以访问Subject。
  //  ° 提供一个与Subject的接口相同的接口，这样代理就可以替代Subject。
  //  ° 控制对Subject的访问，并可能负责对Subject的创建和删除。
  //◊ Subject：定义ConcreteSubject与Proxy的共用接口，从而在任何使用ConcreteSubject的地方都可以使用Proxy。
  //◊ ConcreteSubject：定义Proxy所代表的Subject。
  //◊ Client：维持一个对Subject的引用
    //在代理模式中，由于Proxy与ConcreteSubject继承同一接口，所以Client调用ConcreteSubject可以转化为Client调用Proxy在调用ConcreteSubject，类Proxy为中间代理。
    class Program
    {
        static void Main(string[] args)
        {
            //proxy
            Proxy proxy = new Proxy();
            proxy.Request();

            //Example as below
            MathProxy mathProxy = new MathProxy();
            Console.WriteLine("4 + 2 = " + mathProxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + mathProxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + mathProxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + mathProxy.Div(4, 2));
            Console.ReadKey();
        }
    }

    public abstract class Subject
    {
        public abstract void Request();
    }

    public class ConcreteSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called concreteSubject.Request()");
        }
    }

    public class Proxy : Subject
    {
        private ConcreteSubject concreteSubject;
        public override void Request()
        {
            //Use lazy initialization
            if (concreteSubject == null)
            {
                concreteSubject = new ConcreteSubject();
            }
            concreteSubject.Request();
        }
    }
}
