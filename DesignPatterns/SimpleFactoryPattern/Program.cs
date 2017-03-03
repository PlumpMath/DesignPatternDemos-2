using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryPattern.Example;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple factory
            IProduct product = Factory.Create();
            product.Display();

            //Example as below
            Operation operation = OperationFactory.CreateOperate("+");
            operation.NumberA = 10;
            operation.NumberB = 5;
            Console.WriteLine(operation.GetResult());
            Console.ReadKey();
        }
    }

    //产品接口
    public interface IProduct
    {
        void Display();
    }
    
    //抽象product
    public class Product:IProduct
    {

        public void Display()
        {
            Console.WriteLine("DesignPatterns.SimpleFactoryPattern.Product");
        }
    }

    //工厂
    public class Factory
    {
        public static IProduct Create()
        {
            return new Product();
        }
    }
}
