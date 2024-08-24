using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //Delegates Example
    
    public class DelegateExample
    {
        //Declare a delegate
        public delegate int MyDel(int x, int y);

        /*Methods under the class DelegateExample.
         * All the methods have same signature, similar to that of the delegate
         * 
        */
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y) { return x - y; }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    
    }
}
