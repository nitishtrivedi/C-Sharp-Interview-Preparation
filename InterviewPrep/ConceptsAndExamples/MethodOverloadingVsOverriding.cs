using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    internal class MethodOverloadingVsOverriding
    {
        
        public static void MethodOverriding()
        {
            EmployeeDerived employee = new EmployeeDerived();
            employee.DisplayType();
        }

        public static void MethodOverLoading()
        {
            EmployeeDerived employee = new EmployeeDerived();
            employee.DisplayType();
            employee.DisplayType("Additional Text");
        }
    }

    //Method overriding is a situation when we have a method we have in base class, and we want to override the base class method inside the derived class

    //Base Class
    public class PersonBase
    {
        //Method inside base class
        public virtual void DisplayType() //virtual means there will be an implementation inside base, but this will be overridden inside derived class
        {
            Console.WriteLine(typeof(PersonBase));
        }
    }

    //Derived Class
    public class EmployeeDerived : PersonBase
    {
        public override void DisplayType() //override keyword means this implementation will override the implementation of the method in the base class
        {
            Console.WriteLine(typeof(EmployeeDerived)); //instead of displaying name of PersonBase, it will display name of EmployeeDerived

            //To reach the implementation of base class, use below
            base.DisplayType();

            //OUTPUT
            //InterviewPrep.ConceptsAndExamples.EmployeeDerived
            //InterviewPrep.ConceptsAndExamples.PersonBase
        }

        //FOR METHOD OVERLOADING, AS WE CAN SEE THE ABOVE METHOD TAKES IN NO ARGUMENTS, BUT THE BELOW METHOD HAS SAME SIGNATURE BUT TAKES IN A STRING PARAM.
        public void DisplayType(string additionalText) //Same method signature, but different parameters
        {
            Console.WriteLine(typeof(EmployeeDerived) + " " + additionalText);
        }

        /*
        METHOD OVERLOADING OUTPUT:

        //First method output
        InterviewPrep.ConceptsAndExamples.EmployeeDerived
        InterviewPrep.ConceptsAndExamples.PersonBase

        //Second method output
        InterviewPrep.ConceptsAndExamples.EmployeeDerived Additional Text
         
        */
    }
}
