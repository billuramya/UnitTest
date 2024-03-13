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
    class stringFormats
    {
        public void stringManipulation(string words)
        {
            string input = "my Name Is ";

            Console.WriteLine(input.Concat(words));
        }
    }
}
