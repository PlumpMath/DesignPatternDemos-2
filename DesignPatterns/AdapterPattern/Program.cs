using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //适配器模式
    //将一个类的接口转换成客户希望的另外一个接口。Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
    //假设我们在软件开发中要记录日志，包括数据库记录日志DatabaseLog和文本文件记录日志WriteLog
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //改动之前
    public abstract class Log
    {
        public abstract void WriteLog();
    }

    public class DatabaseLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("Called database log!");
        }
    }

    public class FileLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("Called File log!");
        }
    }

    //改动需求:但是开发过程需要引入一个新的日志接口，但新的日志接口和以前的不一样，该接口如下
    public interface ILog
    {
        void Write();
    }

    public class DatabaseLogAdapter : DatabaseLog, ILog
    {

        public void Write()
        {
            this.WriteLog();
        }
    }

    public class FileLogAdapter : FileLog, ILog
    {
        public void Write()
        {
            this.WriteLog();
        }
    }

    //对象适配器
    public class LogAdapter : ILog
    {
        private Log log;
        public LogAdapter(Log log)
        {
            this.log = log;
        }

        public void Write()
        {
            log.WriteLog();
        }
    }
}
