using InterviewPrep.ConceptsAndExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    internal class RunEveryExample
    {
        public void DelegatesExample()
        {
            //Created an instance of the delegate and referred to a method inside the respective class

            DelegateExample.MyDel myDelegate; //Create an object of type delegate

            //Declare required integers
            int x = 10;
            int y = 5;

            //Use the delegates to various methods
            //Implemented ADD method
            myDelegate = DelegateExample.Add;
            Console.WriteLine($"Add: {x} + {y} = {myDelegate(x, y)}"); //Returns Add: 10 + 5 = 15

            //Implement subtract method
            myDelegate = DelegateExample.Sub;
            Console.WriteLine($"Sub: {x} - {y} = {myDelegate(x, y)}"); //Returns Sub: 10 - 5 = 5

            //Implement Multiply method
            myDelegate = DelegateExample.Multiply;
            Console.WriteLine($"Multiply: {x} * {y} = {myDelegate(x, y)}"); //Returns Multiply: 10 * 5 = 50
        }

        public void BoxingAndUnboxingExample()
        {
            //Boxing means converting value to type to reference type
            int boxingNum = 10;
            Object boxingObj = boxingNum; //implicit casting done
            Console.WriteLine(boxingObj); //Returns 10

            //Unboxing means converting reference type to value type
            Object unboxingObj = 10;
            int unboxingNum = (int)unboxingObj; //Explicit Casting required
            Console.WriteLine(unboxingNum); //Returns 10
        }

        public void EnumsExample()
        {
            EnumsExample enums = new EnumsExample();
            enums.ShowDefaultEnumValues(); //Shows Default Enum Values
            enums.ShowChangedEnumValues(); //Shows Changed Enum Values
            //Refer to the class for logic and explanation
        }

        public void BreakAndContinueExample()
        {
            //Break statement stops execution of a loop, while continue skips the part of condition and continues further action
            //The condition must come first, with break/continue statement and then the actions to be performed
            BreakAndContinue breakAndContinue = new BreakAndContinue();
            breakAndContinue.BreakExample(); // Demonstrates break example. Code stops when conddition is met and break is called
            breakAndContinue.ContinueExample(); //Demonstrates continue example. Code skips the block of code when condition is met, and continues afterwards
        }

        public void ConstReadOnlyExample()
        {
            //Readonly is a keyword whose value can be changed at runtime, and a new value can be assigned but only through a non static constructor
            //Constant is used with keyword const, whose value cannot be changed at any time

            //Refer to the below class for explanation
            ReadonlyAndConst rc = new ReadonlyAndConst();
            rc.Check(); //This method shows values of readonly and const from the respective class
        }

        public void RefOutExample()
        {
            //Ref Example
            //Here, we initialize number before referencing to the method, and then we can change the number. Example below:

            //Initialize before ref

            int refNum = 10;

            Console.WriteLine($"Before using integer refNum as ref: {refNum}");
            RefAndOutExample.ModifyRef(ref refNum);
            Console.WriteLine($"After using integer refNum as ref: {refNum}\n");


            /*
             OUTPUT:
            Before using integer refNum as ref: 10
            Inside ModifyRef number: 30
            After using integer refNum as ref: 30
             */



            //OUT Example:

            int outNum;

            Console.WriteLine($"Before using out: outNum is uninitialised and will throw an exception");
            RefAndOutExample.InitializeOut(out outNum);
            Console.WriteLine($"After using out: outNum = {outNum} ");

            /*
             OUTPUT:

            Before using out: outNum is uninitialised and will throw an exception
            Inside InitializeOut number: 30
            After using out: outNum = 30

             */
        }

        public void ExtensionMethodExample()
        {
            //Below is the demonstration of extension method in C#
            //Extension method is a static method used to extend the functionality of an existing type without modifying its original type or creating a new derived type
            //implementation shown below:


            string originalStr = "Hello World";
            string reversedStr = originalStr.ReverseOriginalString(); //This method is NOT an inbuilt method of .NET, but an extension method created in ExtensionMethodExample class

            Console.WriteLine($"Original String: {originalStr}");
            Console.WriteLine($"Reversed String: {reversedStr}");


            //OUTPUT
            /*
            Original String: Hello World
            Reversed String: dlroW olleH 
            */
        }

        public void StringAndStringBuilderExample()
        {
            //String: It is an immutable type, and derived from System namespace. Once initialised, it cannot be modified or changed
            //when changed, it will simply dispose old object and create and return new object instead.
            //Example:

            string str = "Hello ";

            //Here, a new string instance is created instead of modifying original one
            str += "My";
            str += " name is";
            str += " Nitish";

            Console.WriteLine(str); //Old object is disposed and new is created on runtime


            //StringBuilder: A class which creates a mutable string object. This will hold the string value and return and modify the same object instead of creating a new one. Derived from System.Text namespace

            ////Example
            StringBuilder sb = new StringBuilder(""); //A blank string is initialised in the object
            //To perform operations on the above object, below is the example:

            sb.Append("Hello ");
            sb.Append("my name is ");
            sb.Append("Nitish");

            Console.WriteLine(sb); //Same object sb is returned


            //OUTPUT is same for both: Hello my name is Nitish

        }

        public void PartialClassExample()
        {
            //Implementation of Partial class

            //There are two partial classes with name Person, but they will be counted as one
            Person person = new Person()
            {
                FirstName = "Nitish",
                LastName = "Trivedi",
                Age = 30,
            }; //Properties of both can be assigned together while instance of ALL the partial classes is combined and created

            person.DisplayFullName(); //FROM Partial Class 1
            person.DisplayAge(); //FROM Partial Class 2

            /*
            OUTPUT:

            Full Name: Nitish Trivedi
            Age: 30

            */
        }

        public void InterfacesExample()
        {
            //Description of interface is given in the file "InterfacesExample"
            // Created an implementation class inside the file above so output can be shown
            DemonstrateProductInterface.Demo();

            /*
            OUTPUT:
            Products in Repository:
            ID: 1, Name: Laptop, Price: ? 999.99
            ID: 2, Name: Car, Price: ? 3,999.99

            */
        }

        public void PolymorphismExample()
        {
            //Implement polymorphism here. Refer to PolymorphismExample.cs for classes derived
            //Polymorphism means multiple forms. One method can have different implementations, and one action can have different behaviours based on object type.
            //Base class is Animal and dervied classes are Dog and Cat. We call instance of each class first
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            //Using the same method, i.e. the method shown below, we can pass the objects created above and get variation of responses
            PolymorphismExampleClass.MakeAnimalSound(animal);
            PolymorphismExampleClass.MakeAnimalSound(dog);
            PolymorphismExampleClass.MakeAnimalSound(cat);

            /*
             
            OUTPUT:
            Generic Animal Sound
            BARK
            MEOW
             
             */

            /*
             
            SUMMARY: AS IN THE METHOD PolymorphismExampleClass.MakeAnimalSound(); METHOD, THE ARGUMENT IS A GENERIC ANIMAL, AS PER THE BASE CLASS. BUT THE SAME METHOD, DEFINES WHICH IMPLEMENTATION TO CALL BASED ON THE OBJECT TYPE THAT IS PASSED. 
            BASED ON THE OBJECT, THE VIRTUAL METHOD IS OVERRIDDEN BY THE METHOD PRESENT INSIDE THE CLASS OF THE OBJECT THAT IS PASSED.
             
             */

        }

        public void StructVsClassExample()
        {
            //Copy Ref vs whole object method
            //StructVsClass.CopyReferenceVsObject();

            //Assignment by ref vs value method
            StructVsClass.ReferenceVsValueForClass();
            StructVsClass.ReferenceVsValueForStruct();
        }

        public void DelegateExample2()
        {
            DelegateExample2Class.MainForDelegates();
        }

        public void MethodOverridingExample()
        {
            MethodOverloadingVsOverriding.MethodOverriding();
        }

        public void MethodOverloadingExample()
        {
            MethodOverloadingVsOverriding.MethodOverLoading();
        }

    }
}
