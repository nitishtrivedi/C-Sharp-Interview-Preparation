// See https://aka.ms/new-console-template for more information


//.NET 8 Program.cs file. Everything is prepopulated

using InterviewPrep;
using System.Text;

#region Delegates Example
//Created an instance of the delegate and referred to a method inside the respective class

DelegateExample.MyDel myDelegate; //Create an object of type delegate

//Declare required integers
int x = 10;
int y = 5;

//Use the delegates to various methods
//Implemented ADD method
myDelegate = DelegateExample.Add;
//Console.WriteLine($"Add: {x} + {y} = {myDelegate(x, y)}"); //Returns Add: 10 + 5 = 15

//Implement subtract method
myDelegate = DelegateExample.Sub;
//Console.WriteLine($"Sub: {x} - {y} = {myDelegate(x, y)}"); //Returns Sub: 10 - 5 = 5

//Implement Multiply method
myDelegate = DelegateExample.Multiply;
//Console.WriteLine($"Multiply: {x} * {y} = {myDelegate(x, y)}"); //Returns Multiply: 10 * 5 = 50
#endregion


#region Boxing and Unboxing
//Boxing means converting value to type to reference type
int boxingNum = 10;
Object boxingObj = boxingNum; //implicit casting done
//Console.WriteLine(boxingObj); //Returns 10

//Unboxing means converting reference type to value type
Object unboxingObj = 10;
int unboxingNum = (int)unboxingObj; //Explicit Casting required
                                    //Console.WriteLine(unboxingNum); //Returns 10
#endregion


#region Enums Example
EnumsExample enums = new EnumsExample();
//enums.ShowDefaultEnumValues(); //Shows Default Enum Values
//enums.ShowChangedEnumValues(); //Shows Changed Enum Values
//Refer to the class for logic and explanation
#endregion


#region Continue and Break
//Break statement stops execution of a loop, while continue skips the part of condition and continues further action
//The condition must come first, with break/continue statement and then the actions to be performed
BreakAndContinue breakAndContinue = new BreakAndContinue();
//breakAndContinue.BreakExample(); // Demonstrates break example. Code stops when conddition is met and break is called
//breakAndContinue.ContinueExample(); //Demonstrates continue example. Code skips the block of code when condition is met, and continues afterwards
#endregion


#region Difference between const and readonly
//Readonly is a keyword whose value can be changed at runtime, and a new value can be assigned but only through a non static constructor
//Constant is used with keyword const, whose value cannot be changed at any time

//Refer to the below class for explanation
ReadonlyAndConst rc = new ReadonlyAndConst();
//rc.Check(); //This method shows values of readonly and const from the respective class
#endregion


#region Ref and Out Example
//Ref Example
//Here, we initialize number before referencing to the method, and then we can change the number. Example below:

//Initialize before ref

//int refNum = 10;

//Console.WriteLine($"Before using integer refNum as ref: {refNum}");
//RefAndOutExample.ModifyRef(ref refNum);
//Console.WriteLine($"After using integer refNum as ref: {refNum}\n");


/*
 OUTPUT:
Before using integer refNum as ref: 10
Inside ModifyRef number: 30
After using integer refNum as ref: 30
 */



//OUT Example:

//int outNum;

//Console.WriteLine($"Before using out: outNum is uninitialised and will throw an exception");
//RefAndOutExample.InitializeOut(out outNum);
//Console.WriteLine($"After using out: outNum = {outNum} ");

/*
 OUTPUT:

Before using out: outNum is uninitialised and will throw an exception
Inside InitializeOut number: 30
After using out: outNum = 30
 
 */

#endregion


#region Extension Method Example
//Below is the demonstration of extension method in C#
//Extension method is a static method used to extend the functionality of an existing type without modifying its original type or creating a new derived type
//implementation shown below:


//string originalStr = "Hello World";
//string reversedStr = originalStr.ReverseOriginalString(); //This method is NOT an inbuilt method of .NET, but an extension method created in ExtensionMethodExample class

//Console.WriteLine($"Original String: {originalStr}");
//Console.WriteLine($"Reversed String: {reversedStr}");


//OUTPUT
/*
Original String: Hello World
Reversed String: dlroW olleH 
*/

#endregion


#region Difference between String and StringBuilder
//String: It is an immutable type, and derived from System namespace. Once initialised, it cannot be modified or changed
//when changed, it will simply dispose old object and create and return new object instead.
//Example:

//string str = "Hello ";

////Here, a new string instance is created instead of modifying original one
//str += "My";
//str += " name is";
//str += " Nitish";

//Console.WriteLine(str); //Old object is disposed and new is created on runtime


//StringBuilder: A class which creates a mutable string object. This will hold the string value and return and modify the same object instead of creating a new one. Derived from System.Text namespace

////Example
//StringBuilder sb = new StringBuilder(""); //A blank string is initialised in the object
////To perform operations on the above object, below is the example:

//sb.Append("Hello ");
//sb.Append("my name is ");
//sb.Append("Nitish");

//Console.WriteLine(sb); //Same object sb is returned


//OUTPUT is same for both: Hello my name is Nitish

#endregion


//SEALED CLASS: USED TO PREVENT INHERITENCE BEHAVIOUR OF OOP. ONCE A CLASS IS MARKED AS SEALED, IT CANNOT BE INHERITED. STRUCT IS AN EXAMPLE OF SEALED CLASS.


#region Partial Classes Example
//Implementation of Partial class

//There are two partial classes with name Person, but they will be counted as one
//Person person = new Person()
//{
//    FirstName = "Nitish",
//    LastName = "Trivedi",
//    Age = 30,
//}; //Properties of both can be assigned together while instance of ALL the partial classes is combined and created

//person.DisplayFullName(); //FROM Partial Class 1
//person.DisplayAge(); //FROM Partial Class 2

/*
OUTPUT:

Full Name: Nitish Trivedi
Age: 30
 
*/
#endregion