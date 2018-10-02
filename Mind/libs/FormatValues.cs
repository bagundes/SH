using System;
using System.Collections.Generic;
using System.Text;

namespace Mind.libs
{
    public class FormatValues
    {

        public static string GetNumbers(string val, int def = 0)
        {
            var foo = String.Join("", System.Text.RegularExpressions.Regex.Split(val, @"[^\d]"));
            if (string.IsNullOrEmpty(foo))
                return def.ToString();
            else
                return foo;
        }
    }
}
