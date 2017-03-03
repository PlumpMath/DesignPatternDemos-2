using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //美国员工工资计算方法
    public class AmericanSalary : ISalary
    {
        //base salary
        private double BASE_SALARY = 8000;
        //bonus
        private double BONUS = 8000;

        public double CalculateSalary()
        {
            double totalSalary = BASE_SALARY + BONUS;
            double tax = totalSalary * 0.4;
            double salary = totalSalary - tax;
            return salary;
        }
    }
}
