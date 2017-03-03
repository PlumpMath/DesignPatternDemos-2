using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Example1;
using IteratorPattern.Example2;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //手动实现迭代器
            Object[] values = { "a", "b", "c", "d", "e" };
            IterationSample collection = new IterationSample(values, 3);
            foreach (var x in collection)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            //Example1
            Client1 client1 = new Client1();
            client1.Operation();
            Console.WriteLine();

            //Example2
            Client2 client2 = new Client2();
            client2.Operation();

            Console.ReadKey();
        }
    }
}
