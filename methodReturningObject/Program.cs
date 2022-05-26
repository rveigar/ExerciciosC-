
// C# program to illustrate the concept
// of the method returning an object
using System;

namespace methodReturningObject
{
    class Program
    {
        static void Main()
        {
            // Declaring objects of Example
            Example o1 = new Example();
            Example o2 = new Example();
            // Initialize the values to the objects
            o1.setStr("O1 ");
            o2.setStr("O2 ") ;

             // Adding value of both objects
            // and the result will be
            // assigned into third object
            Example o3 = o1.RetObj(o2);

            // Display the data
            o1.Display();
            o2.Display();
            o3.Display();
            // Console.WriteLine("Hello World!");
        }
    }

    class Example
    {
        // Private data member
        private string str;
        // Method to set the value of str
        public void setStr(string str)
        {
            this.str=str;
        }
        // Method to display the value of str
        public void Display ()
        {
            System.Console.WriteLine($"valor de str= {str}");
        }
        // Method that return object
        public Example RetObj (Example ex)
        {
            // Creating object of Example
            Example obj = new Example();
            // Adding the value of passed 
            // an object in the current object
            // and adding the sum in another object
            //Example o3 = o1.RetObj(o2);

            obj.str = str + ex.str;
            // Returning the object
            return obj;
        }
    }

}
