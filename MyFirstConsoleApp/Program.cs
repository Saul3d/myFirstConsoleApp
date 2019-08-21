using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStringVariable;
            myStringVariable = "Saul";

            int myIntVariable;
            myIntVariable = 1234;

            decimal myDecimalVariable;
            myDecimalVariable = 12345.6789m;

            var myDateTime = new DateTime();

            bool myBool = false;

            if(myBool)
            {
                Console.WriteLine("Yo what\'s up");
            }

            //Objects in C#
            var myObject = new { hairColor= "blonde" }; // this is read only

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"number is {i}");
            }

            //Lists (are C# version of arrays
            List<string> myStrings = new List<string>();
            myStrings.Add("blah");
            myStrings.Add("blah!!");
            myStrings.Insert(1, "blah!!!");  // inserts this line between line 28 & 29
            myStrings.RemoveAt(1);  // removes line 28;

            foreach(var myString in myStrings)

                Console.WriteLine("Hello " + myStringVariable);
        }
    }
}
