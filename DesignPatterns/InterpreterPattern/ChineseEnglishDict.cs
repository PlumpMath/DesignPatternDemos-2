using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public static class ChineseEnglishDict
    {
        private static Dictionary<string, string> dict = new Dictionary<string, string>();

        static ChineseEnglishDict()
        {
            dict.Add("this", "这");
            dict.Add("is", "是");
            dict.Add("an", "一个");
            dict.Add("apple", "苹果");
        }

        public static string GetEnglish(string value)
        {
            return dict[value];
        }
    }
}
