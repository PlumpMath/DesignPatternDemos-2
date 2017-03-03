using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    //访问者模式
    //很不常用
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("a")；
            Manager manager = new Manager("M");
            Chairman chairman = new Chairman("C");
            manager.Accept(new Salary());
            chairman.Accept(new Salary());
            Console.ReadKey();
        }
    }

    public abstract class Visitor
    {
        public abstract void Visit(Manager manager);
        public abstract void Visit(Chairman chairman);
    }

    public class Salary : Visitor
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("Manager salary is 10");
        }

        public override void Visit(Chairman chairman)
        {
            Console.WriteLine("Chairman salary is 100");
        }
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        protected Employee() { }
        public Employee(string name)
        {
            this.Name = name;
        }
        public abstract void Accept(Visitor visitor);
    }

    public class Manager : Employee
    {
        public Manager(string name)
        {
            this.Name = name; 
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Chairman : Employee
    {
        public Chairman(string name)
        {
            this.Name = name;
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
