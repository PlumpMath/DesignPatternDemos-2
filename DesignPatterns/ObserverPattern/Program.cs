using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //观察者模式
    // 举个例子：猫叫了一声，惊醒了主人，吓跑了老鼠。这个例子就可以用观察者模式来实现。猫是被观察者，主人和老鼠是观察者。
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Master master = new Master();
            Mouse mouse = new Mouse();
            Cat.NotifyEventHandle notifyMouse = new Cat.NotifyEventHandle(mouse.Update);
            Cat.NotifyEventHandle notifyMaster = new Cat.NotifyEventHandle(master.Update);
            cat.NotifyEvent += notifyMouse;
            cat.NotifyEvent += notifyMaster;
            cat.Notify();
            Console.ReadKey();
        }
    }
}
