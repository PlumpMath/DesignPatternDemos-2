using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //命令模式的目的是解除命令发出者和接收者之间的紧密耦合关系，使二者相对独立，有利于程序的并行开发和代码的维护。
    //命令模式的核心思想是将请求封装为一个对象，将其作为命令发起者和接收者的中介，而抽象出来的命令对象又使得能够对一系列请求进行操作，
    //如对请求进行排队，记录请求日志以及支持可撤销的操作等。
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            Console.ReadKey();
        }
    }

    //命令的接收者，知道如何实施与执行一个请求相关的操作
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }

    //命令抽象类，声明一个执行操作的接口Execute，该抽象类并不实现这个接口，所有的具体命令都继承自命令抽象类。
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver reveiver)
        {
            this.receiver = reveiver;
        }

        public abstract void Execute();
    }

    //定义一个接收者对象与动作之间的请求绑定
    //调用Receiver的操作，实现Execute方法
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
 
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }

    //命令的接收者，将命令请求传递给相应的命令对象，每个ConcreteCommand都是一个Invoker的成员
    public class Invoker
    {
        private Command _command;
        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
