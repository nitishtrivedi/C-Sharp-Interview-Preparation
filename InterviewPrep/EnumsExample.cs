using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //Enums or Enumerations Example
    /*
    Enums is a special datatype in C# that allows you to define a set of named constants.
    Each constant inside an enum has a default value of 0, and incrementing from 0 onwards
     */

    //Declare and Enum
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    internal class EnumsExample
    {
        //Methods to show default and changed values of enums
        public void ShowDefaultEnumValues()
        {
            Console.WriteLine("Default Enum Values:");
            foreach(OrderStatus status in  Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine($"Status: {status}, Value: {(int)status}");
            }
        }

        public void ShowChangedEnumValues()
        {
            Console.WriteLine("Changed Enum Values:");
            foreach(OrderStatus status in Enum.GetValues(typeof(OrderStatus))) //First loop through all initial values
            {
                //For each current value, explicit casting is done and 2 is added to its value
                int newValue = ((int)status + 2);

                //Reassign values to the original Enum
                OrderStatus newStatus = (OrderStatus)newValue;
                Console.WriteLine($"Status: {newStatus}, Changed Value: {newValue}");
            }
        }
    }
}
