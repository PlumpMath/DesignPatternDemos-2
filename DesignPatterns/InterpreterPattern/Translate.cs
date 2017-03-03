using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public static class Translate
    {
        public static string TranslateMethod(string sentense)
        {
            StringBuilder sb = new StringBuilder();
            List<IExpression> exps = new List<IExpression>();
            string[] eles = sentense.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var ele in eles)
            {
                string[] words = ele.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    exps.Add(new WordExpression(word));
                }
                exps.Add(new SymbolExpression("."));
            }
            foreach(IExpression exp in exps)
            {
                exp.Interpret(sb);
            }
            return sb.ToString();
        }
    }
}
