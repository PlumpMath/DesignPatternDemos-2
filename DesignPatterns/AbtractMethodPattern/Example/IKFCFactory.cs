using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    //抽象工厂，生产套餐
    public interface IKFCFactory
    {
        //生产Food
        void CreateFood();

        //生产Drink
        void CreateDrink();

        //操作
        void Operation();
    }
}
