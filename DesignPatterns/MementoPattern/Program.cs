using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //备忘录模式在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
    //这样以后就可以将该对象恢复到原先保存的状态。
    //不常用
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            if (!o.State.ToUpper().Equals(c.Memento.State.ToUpper()))
            {
                o.SetMemento(c.Memento);
            }

            Console.WriteLine("Originator's state = " + o.State);

            Console.ReadKey();
        }
    }

    //为创建对象的各个部件指定抽象接口
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            this._state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }

    //创建一个备忘录，记录当前时刻的内部状态
    //使用备忘录恢复内部状态。
    public class Originator
    {
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    // 负责保存备忘录
    //不能对备忘录的内容进行操作或检查
    public class Caretaker
    {
        private Memento _memento;
        public Memento Memento
        {
            get
            {
                return _memento;
            }
            set
            {
                _memento = value;
            }
        }
    }
}
