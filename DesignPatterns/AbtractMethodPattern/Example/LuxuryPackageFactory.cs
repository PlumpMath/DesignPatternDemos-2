using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Example
{
    //豪华套餐，包括鸡腿和咖啡
    public class LuxuryPackageFactory : IKFCFactory
    {
        private KFCFood food = null;
        private KFCDrink drink = null;

        public LuxuryPackageFactory()
        {
            CreateFood();
            CreateDrink();
        }

        public void CreateFood()
        {
            if (food == null)
            {
                food = new Chicken();
            }
        }

        public void CreateDrink()
        {
            if (drink == null)
            {
                drink = new Coffee();
            }
        }

        public void Operation()
        {
            Console.WriteLine("Luxury Package:");
            Console.WriteLine(this.food.Display());
            Console.WriteLine(this.drink.Display());
            Console.WriteLine();
        }
    }
}
