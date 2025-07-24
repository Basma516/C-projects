using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_Sharp
{
    public static class StringBuilderExtension
    {
        public static StringBuilder AddNewLine(this StringBuilder sb, string line)
        {
            sb.Append(line);
            return sb;
        }
    }
}
