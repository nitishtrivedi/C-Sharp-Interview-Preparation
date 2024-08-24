using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //Example of Extension methods. The class itself and all the methods inside must be static
    internal static class ExtensionMethodExample
    {
        //Declare an extension method
        public static string ReverseOriginalString(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str; //Return the original string if the supplied string is null or empty

            //If not empty, reverse the string as below
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
