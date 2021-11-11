using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace RegexPatternMaching
{
    class Pattern
    {
        public static string REJEX_Email = "^[a-zA-Z2]{3,8}([_|+|.|-]{0,1}[a-zA-Z0-9]{0,5}){0,1}[@][a-zA-Z0-9]{1,10}([.][a-z]{2,4}){1,2}$";
      // UC1 EJEX_PINCODE = "^[1-9]{1}[0-9]{2}[\\s]{0,1}[0-9]{3}$"
        public bool validatePinCode(string input)
        {
            return Regex.IsMatch(input, REJEX_Email);
        }
    }
}
 