using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace simpleChat
{
    public class validation
    {
        public static bool IsMatch(string str, string pattern)
        {
            Regex reg = new Regex(pattern);
            return reg.IsMatch(str);
        }
        public static bool LengthValidation(string str, int min, int max)
        {
            return (str.Length >= min && str.Length <= max);
        }

    }
}