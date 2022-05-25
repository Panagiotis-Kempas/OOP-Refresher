using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class StringExtension
    {
        public static string FirstLetterToUpperCase(this string word)
        {
            return string.Concat(word.Select((x, i) => i == 0 ? x.ToString().ToUpper() : x.ToString()));
        }
    }
}
