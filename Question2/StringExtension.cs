using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question2
{
    public static class StringExtenstion
    {
        public static int CountWords(this StringBuilder sb)
        {
            return Regex.Replace(sb.ToString().Trim(), @"\s{2,}", " ").Split(null).Count();
        }
    }
}
