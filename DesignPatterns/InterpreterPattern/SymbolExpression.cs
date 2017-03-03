using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class SymbolExpression : IExpression
    {
        private string value;
        public SymbolExpression(string value)
        {
            this.value = value;
        }
        public void Interpret(StringBuilder sb)
        {
            switch (value)
            {
                case ".":
                    sb.Append("。");
                    break;
            }
        }
    }
}
