using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    /*
     Explanation:
        * ref Keyword: The variable passed as a ref parameter must be initialized before it is passed to the method. The method can then modify the value of the variable.
        * out Keyword: The variable passed as an out parameter does not need to be initialized before it is passed to the method. The method must assign a value to it before the method returns.
     
     */
    internal class RefAndOutExample
    {
        public static void ModifyRef(ref int number) //Warning shows if not used static as it does not access instance data
        {
            number += 20;
            Console.WriteLine($"Inside ModifyRef number: {number}");
        }

        public static void InitializeOut(out int number)
        {
            number = 30; //Initialization is compulsory, else exception is thrown
            Console.WriteLine($"Inside InitializeOut number: {number}");

        }
    }
}
