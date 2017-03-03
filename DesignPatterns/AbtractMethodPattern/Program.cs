using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Example;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract factory #1
            AbstractFactory factory1 = new AbstractFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            //Abstract factory #2
            AbstractFactory factory2 = new AbstractFactory2();
            Client client2 = new Client(factory2);
            client2.Run();


            //Example
            IKFCFactory cheap = new CheapPackageFactory();
            cheap.Operation();

            IKFCFactory luxury = new LuxuryPackageFactory();
            luxury.Operation();

            Console.ReadKey();
        }
    }
}
