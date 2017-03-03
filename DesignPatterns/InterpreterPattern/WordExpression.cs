
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class WordExpression : IExpression
    {
        private string value;

        public WordExpression(string value)
        {
            this.value = value;
        }
        public void Interpret(StringBuilder sb)
        {
            sb.Append(ChineseEnglishDict.GetEnglish(value.ToLower()));
        }
    }
}
