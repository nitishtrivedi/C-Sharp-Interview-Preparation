using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    internal class BreakAndContinue
    {
        public void BreakExample()
        {
            Console.WriteLine("Break Example:");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
                //The condition must come first, with break/continue statement and then the actions to be performed
            }
        }

        public void ContinueExample()
        {
            Console.WriteLine("Continue Example:");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
                //The condition must come first, with break/continue statement and then the actions to be performed
            }
        }

    }
}
