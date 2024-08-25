using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ConceptsAndExamples
{
    /*
    
    POLYMORPHISM - ONE ENTITY CAN HAVE MULTIPLE FORMS
    1 method => Different Implementations
    1 Action => Different behaviour - Based on object Type
     
    */
    internal class PolymorphismExampleClass
    {
        //Implementation of Polymorphism
        public static void MakeAnimalSound(Animal animal)
        {
            animal.MakeSound();
        }
    }

    public class Animal //Base class
    {
        public virtual void MakeSound() //Made the method virtual as we will be overriding the behaviour of this method
        {
            Console.WriteLine("Generic Animal Sound");
        }
    }


    public class Dog : Animal //Derived Class 1
    {
        public override void MakeSound() //Override behaviour in derived class 1
        {
            Console.WriteLine("BARK");
        }
    }

    public class Cat : Animal //Derived Class 2
    {
        public override void MakeSound() //Override behaviour in derived class 2
        {
            Console.WriteLine("MEOW");
        }
    }



}
