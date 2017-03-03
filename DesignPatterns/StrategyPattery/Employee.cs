using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Employee
    {
        private ISalary salary;

        public Employee() { }

        public void SetEmployee(ISalary salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary.CalculateSalary();
        }
    }
}
