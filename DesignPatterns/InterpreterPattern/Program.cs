using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string english = "This is an apple.";
            string chinses = Translate.TranslateMethod(english);
            Console.WriteLine(chinses);
            Console.ReadKey();
        }
    }
}
