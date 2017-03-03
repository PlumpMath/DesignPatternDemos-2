using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    //经济套餐，包括鸡翅和可乐
    public class CheapPackageFactory : IKFCFactory
    {
        private KFCFood food = null;
        private KFCDrink drink = null;

        public CheapPackageFactory()
        {
            CreateFood();
            CreateDrink();
        }

        public void CreateFood()
        {
            if (food == null)
            {
                food = new Wings();
            }
        }

        public void CreateDrink()
        {
            if (drink == null)
            {
                drink = new Coke();
            }
        }


        public void Operation()
        {
            Console.WriteLine("Cheap Package:");
            Console.WriteLine(this.food.Display());
            Console.WriteLine(this.drink.Display());
            Console.WriteLine();
        }
    }
}
