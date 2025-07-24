using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_Sharp
{
    public static class StringExtensions
    {
        public static string Reverse(this string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
           string r=string.Join("",chars);
            return r;
        }
        public static int WordCount(this string s)
        {
            return s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
           
        }
    }
}
