using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //中国员工工资计算方法
    public class ChineseSalary : ISalary
    {
        //base salary
        private double BASE_SALARY = 2000;
        //bonus
        private double BONUS = 2000;

        public double CalculateSalary()
        {
            double totalSalary = BASE_SALARY + BONUS;
            double tax = totalSalary * 0.2;
            double salary = totalSalary - tax;
            return salary;
        }
    }
}
