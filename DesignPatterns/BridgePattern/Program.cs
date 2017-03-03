using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Example;

namespace BridgePattern
{
    //桥接模式的用意是将抽象化(Abstraction)与实现化(Implementation)脱耦，使得二者可以独立地变化。
    class Program
    {
        static void Main(string[] args)
        {
            Abstrcation abstraction = new RefindedAbstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            //Example
            //以一杯咖啡为例，子类有四个：中杯加奶、大杯加奶、中杯不加奶、大杯不加奶。
            //这四个类实际是两个角色的组合：抽象和行为。其中抽象为中杯和大杯，行为为加奶和不加奶。
            //这种从分离抽象和行为的角度的方法称为桥接模式。
            MakeCoffeeSingleton wmcs = new MakeCoffeeSingleton(new WhiteCoffee());
            //中杯牛奶咖啡
            MediumCupCoffee wmcc = new MediumCupCoffee();
            wmcc.Make();
            //大杯牛奶咖啡
            LargeCupCoffee wlcc = new LargeCupCoffee();
            wlcc.Make();

            MakeCoffeeSingleton bmcs = new MakeCoffeeSingleton(new BlackCoffee());
            //中杯原味咖啡
            MediumCupCoffee bmcc = new MediumCupCoffee();
            bmcc.Make();
            //大杯原味咖啡
            LargeCupCoffee blcc = new LargeCupCoffee();
            blcc.Make();

            Console.ReadKey();
        }
    }

    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class Abstrcation
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }

    public class RefindedAbstraction : Abstrcation
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
