using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathTest
{
    //4) Develop unit tests to verify the behavior of string manipulation methods such as concatenation,
    //substring extraction, and character replacement. Test for various scenarios including empty strings,
    //null inputs, and special characters.
    public class StringFormats
    {
        public string stringManipulation(string words)
        {
            string input = "my Name Is ";
            string val = words;
            string concat= (string)input.Concat(val);
            return concat;
        }
        public char SubString(string inputstring)
        {
            string str1 = "My Name Ramya";
            string str2 = inputstring;
            int index = str1.IndexOf(str2);
            return str1[index];
        }
        public string charecterReplacement(string charecter)
        {
            string str1 = "Develop unit tests to verify to the behavior of string manipulation";
            string str2 = charecter;
            var val = str1.Replace(str2, "Ramya");
            return val;
        }
    }
}
