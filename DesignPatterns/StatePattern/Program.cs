using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Example;

namespace StatePattern
{
    //状态模式参与者：
    //◊ Context：状态管理器
    //  ° 定义对Client感兴趣的接口
    //  ° 维持一个ConcreteState子类的实例，这个实例定义当前状态
    //◊ State：状态，定义一个接口以封装与Context的一个特定状态相关的行为。
    //◊ ConcreteState：具体状态子类，每一子类实现的一个与Context的一个状态相关的行为。
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            //Example
            Work work = new Work();
            work.State = new PendingState();
            work.Start();
            work.Cancel();
            Console.ReadKey();
        }
    }

    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public class Context
    {
        private State _state;

        public Context(State state)
        {
            this._state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
