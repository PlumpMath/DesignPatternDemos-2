using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //单例模式的几种经典实现方式：
    //1:
    //这是最简单的实现方式 ，但该实现对线程来说是不安全的，当有两个或多个线程同时判断instance==null并且得到结果都为true,
    //就会创建多个实例,这就违背了单例模式的原则。实际上在上述代码中，有可能在计算出表达式的值之前，对象实例已经被创建，但是内存模型并不能保证对象实例在第二个线程创建之前被发现。
    //该实现方式直到要求产生一个实例才执行实例化，这种方法称为“惰性实例化”，惰性实例化避免了在应用程序启动时实例化不必要的singleton.
    public sealed class Singleton1
    {
        public static Singleton1 instance1 = null;

        public Singleton1() { }

        public static Singleton1 Instance1
        {
            get
            {
                if (instance1 == null)
                {
                    instance1 = new Singleton1();
                }
                return instance1;
            }
        }
    }

    //2:
    //这种实现方式对线程来说是安全的，但是这种实现方式增加了额外的开销，损失了性能。
    public sealed class Singleton2
    {
        private static Singleton2 instance2 = null;

        public static readonly object padlock = new object();

        public Singleton2() { }

        public static Singleton2 Instance2
        {
            get
            {
                lock (padlock)
                {
                    if (instance2 == null)
                    {
                        instance2 = new Singleton2();
                    }
                }
                return instance2;
            }
        }
    }


    //3:
    //这种实现方式对线程来说是安全的，同时线程不是每次都加锁，只有判断对象实例没有创建时它才加锁。解决了线程并发的问题，但是无法实现延迟初始化。

    public sealed class Singleton3
    {
        public static Singleton3 instance3 = null;

        public static readonly object padlock = new object();

        public Singleton3() { }

        public static Singleton3 Instance3
        {
            get
            {
                if (instance3 == null)
                {
                    lock (padlock)
                    {
                        if (instance3 == null)
                        {
                            instance3 = new Singleton3();
                        }
                    }
                }
                return instance3;
            }
        }
    }

    //4:
    //该实现方式在第一次引用类的成员时创建实例。公共语言运行库负责处理变量初始化。该方法的缺点是：对实例化机制的控制权较少。
    //在大多数情况下，静态初始化是在.NET中实现Singleton的首选方法。
    public sealed class Singleton4
    {
        public static readonly Singleton4 instance4 = new Singleton4();

        public Singleton4() { }

        public static Singleton4 Instance4
        {
            get
            {
                return instance4;
            }
        }
    }

    //5:
    //该实现方式的初始化工作由Nested类的一个静态成员来完成，这样就实现了延迟初始化。是值得推荐的一种实现方式。
    public sealed class Singleton5
    {
        public Singleton5() { }

        public static Singleton5 instance5
        {
            get
            {
                return Nested.instance5;
            }
        }

        public class Nested
        {
            //Explicit static constructor to tell C# compiler
            //not to mark type as beforefieldinit
            static Nested() { }

            internal static readonly Singleton5 instance5 = new Singleton5();
        }
    }
}
