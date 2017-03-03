using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Example
{
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new Plus();
                    break;
                case "-":
                    operation = new Minus();
                    break;
                case "*":
                    operation = new Multiply();
                    break;
                case "/":
                    operation = new Divide();
                    break;
            }
            return operation;
        }
    }
}
