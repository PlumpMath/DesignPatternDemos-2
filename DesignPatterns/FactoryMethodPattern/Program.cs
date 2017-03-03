using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{

    //工厂方法模式
    //定义了一个用于创建对象的接口，让其子类决定实例化哪一个对象。使一个对象的创建工作延迟到其子类。
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new BulbCreator();
            ILight light = creator.Factory();
            light.TurnOn();
            light.TurnOff();

            creator = new TubeCreator();
            light = creator.Factory();
            light.TurnOn();
            light.TurnOff();
            Console.ReadKey();
        }
    }

    //抽象产品
    public interface ILight
    {
        void TurnOn();
        void TurnOff();
    }

    //抽象工厂角色
    public interface ICreator
    {
        ILight Factory();
    }

    //具体产品TubeLight
    public class TubeLight : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine("TubeLight TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("TubeLight TurnOff");
        }
    }

    //具体产品BulbLight
    public class BulbLight : ILight
    {

        public void TurnOn()
        {
            Console.WriteLine("BulbLight TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("BulbLight TurnOff");
        }
    }

    //具体工厂BulbCreator
    public class BulbCreator : ICreator
    {
        public ILight Factory()
        {
            return new BulbLight();
        }
    }

    //具体工厂TubeCreator
    public class TubeCreator : ICreator
    {
        public ILight Factory()
        {
            return new TubeLight();
        }
    }
}
