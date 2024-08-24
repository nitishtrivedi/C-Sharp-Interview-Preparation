using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    internal class ReadonlyAndConst
    {
        readonly int readInt; //No assignment of value is required
        const int constInt = 10; //Value needs to be assigned to a const at compile time itself
        public ReadonlyAndConst()
        {
            //Constructor
            readInt = 20; //Value to readonly can be changed at compile time in the constructor
            //constInt = 30; //This throws exception. As changing values at compile time is not allowed
        }

        public void Check()
        {
            Console.WriteLine($"ReadOnly: {readInt}");
            Console.WriteLine($"Const: {constInt}");
        }
    }
}
