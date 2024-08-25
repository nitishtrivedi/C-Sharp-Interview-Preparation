using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    public delegate int PerformCalculation(int x, int y);
    internal class DelegateExample2Class
    {
        public static void MainForDelegates()
        {
            //Implementation of delegate

            //Below, the delegate is referencing to two methods as below
            PerformCalculation addMethod = Add;
            PerformCalculation subtractMethod = Subtract;

            //Calling the methods
            addMethod(20, 10); //OUTPUT 30
            subtractMethod(20, 20); //OUTPUT 0


            //One delegate can contain reference to multiple delegates
            PerformCalculation allCalculations = addMethod + subtractMethod;
            allCalculations(30, 10); //This returns 40 and 20. Runs both methods and gives two outputs. Both references are invoked


        }


        private static int Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        private static int Subtract(int x, int y) 
        {
            Console.WriteLine(x - y);
            return x - y;
        }

    }
}
