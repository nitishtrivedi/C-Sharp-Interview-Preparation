using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{

    /*
    STRUCT VS CLASS : STRUCT IS A VALUE TYPE, WHEREAS CLASS IS A REFERENCE TYPE
    * CLASS ARE STORED IN HEAP, WHEREAS STRUCT IS STORED IN STACK
    * HEAP IS USED FOR STORING LARGE DATA, AND DOES NOT HAVE INSTANT ACCESS. WHEREAS STRUCT IS STORED IN STACK, WHICH HAS INSTANT ACCESS
    * CLASS OBJECTS ARE DEALLOCATED BY GC, WHEREAS STRUCTS ARE DEALLOCATED WHEN STACK IS CLEANED
    * CLASS OBJECT ASSIGNMENT COPIES THE REFERENCE, WHEREAS STRUCT OBJECT ASSIGNMENT COPIES ENTIRE OBJECT

    */

    //First, lets create a CLASS
    public class PersonClass
    {
        public string Name { get; set; }
        public PersonClass(string name)
        {
            Name = name; //Name is assigned when the object is initialised
        }
    }

    //Then, create a STRUCT
    public struct PersonStruct
    {
        public string Name { get; set; }
        public PersonStruct(string name)
        {
            Name = name; //Name is assigned when the object is initialised
        }
    }


    internal class StructVsClass
    {
        //First, lets understand difference between copy the reference of the object vs copy the value of the object

        public static void CopyReferenceVsObject()
        {
            var personClass = new PersonClass("Mike"); //initialise the class and pass in the name Mike in the constructor
            var personStruct = new PersonStruct("John"); //same for struct

            var newPerson = personClass; // Created new variable and assigned personClass - both object has SAME REFERENCE

            //Now, we will change the name
            newPerson.Name = "Mike's name is changed"; //Changing the newPerson name has also changed the original person, because they both have same reference. This assignment did NOT make copy of person, but copied the reference of the object


            Console.WriteLine($"Class: {personClass.Name}"); // OUTPUT is "Mike's name is changed"


            //Now, for struct
            var newPerson2 = personStruct; //Here, I am assigning a COPY of the struct object
            //Hence, when I change the name of newPerson2 object, it will only change the value of newPerson2, and not of the original struct
            newPerson2.Name = "John's name is changed";

            Console.WriteLine($"Struct: {personStruct.Name}");

            //FINAL OUTPUT
            //Class: Mike's name is changed
            //Struct: John

        }

        //Now lets check difference between "Assignment by reference" vs "Assignment by value"
        //Add a new static method called ModifyName which takes in PersonClass object

        private static void ModifyName(PersonClass person)
        {
            person.Name = "Class Name Changed";
        }
        
        private static void ModifyName(PersonStruct personS)
        {
            personS.Name = "Class Name Changed";
        }

        public static void ReferenceVsValueForClass()
        {
            var personClass = new PersonClass("Mike");
            var personStruct = new PersonStruct("John");

            //invoke the above method for class
            ModifyName(personClass); //Reference type are passed by reference. Here, we referred personClass reference to the method

            Console.WriteLine(personClass.Name); //OUTPUT IS Class Name Changed
        }
        public static void ReferenceVsValueForStruct()
        {
            var personClass = new PersonClass("Mike");
            var personStruct = new PersonStruct("John");

            //invoke the above method for struct
            ModifyName(personStruct); //Value type are passed by Value. 

            Console.WriteLine(personStruct.Name); //OUTPUT IS John - The original value

        }
    }

    /*
    WHEN TO USE STRUCTS?
    * When the object is small
    * The object is immutable
    * Object has no reference type fields
     
    */
}
