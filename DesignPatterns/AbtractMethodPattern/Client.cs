using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private AbstractProductA _aA;
        private AbstractProductB _aB;

        public Client(AbstractFactory factory)
        {
            _aA = factory.CreateProductA();
            _aB = factory.CreateProductB();
        }

        public void Run()
        {
            _aB.Interact(_aA);
        }
    }
}
