using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //策略模式
    // 举个例子：假设我们现在要为联想公司做个计算公司员工工资的计算器，我们知道联想是个国际化公司，在中国和美国都有员工，
    //由于两个劳动力成本是不一样的，因此美国员工的工资和中国员工的工资工资计算方式是不一样的。
    //我们可以把计算中国员工工资和计算美国员工工资视作两个独立的部分
    class Program
    {
        static void Main(string[] args)
        {
            ISalary salary = null;
            Employee emplopee = new Employee();
            string country = string.Empty;
            while (true)
            {
                string type = Console.ReadLine();

                switch (type)
                {
                    case "c":
                        salary = new ChineseSalary();
                        country = "Chinese";
                        break;
                    case "a":
                        salary = new AmericanSalary();
                        country = "American";
                        break;
                    default:
                        Console.WriteLine("Please key in 'a' or 'c'!");
                        country = string.Empty;
                        break;
                }
                if (!string.IsNullOrEmpty(country))
                {
                    emplopee.SetEmployee(salary);
                    Console.WriteLine(country + "'s salary: " + emplopee.GetSalary());
                    country = string.Empty;
                }
            }
        }
    }
}
