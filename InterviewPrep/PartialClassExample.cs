using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //Partial class. It allows you to split definition of a class in multiple various files, as long as all are under the same namespace.
    //Here, we assume that the below partial classes are split in multiple files, but the namespace demonstrated is the same i.e InterviewPrep

    //Class 1. Assume it is in a different file
    public partial class Person
    {
        //Properties in first partial class
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Methods in the first partial class
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }

    }

    //Class 2. Assume that this is in a different file than that of the above class. Same name as above, and no conflicts
    public partial class Person
    {
        //Properties in second partial class
        public int Age { get; set; }

        //Methods in the second partial class
        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }


    //IMPLEMENTATION OF THIS IS IN PROGRAM.CS CLASS

}
