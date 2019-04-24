using System;

namespace CSharpBasics
{
    // a class called "Program"
    /in VS, comments: ctr+k, ctr+u uncomments
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //variables and types
            //(type) (new name) = (value);
            string str = "abc";
            str = "cbd";

            //declaration of variable
            string str2;
            //initialization of variable
            //giving it its initial value
            str2 = "a";

            //numeric types
            // integer types
            // int (4 byte) : used 99% of the time
            // short (2), long (8), byte (1)

            //decimal types
            //double (8 byte) : used most of the time
            //float (4)
            //..we can store more precision, about 15 decimal places

            //boolean
            bool b = true;
            b = false;

            //boolean operators
            b = true || true;
            b = true || false;
            b = false && true;

            // comparison operators
            b = (3 == 3); //equals
            b = (3 != 3); // not equals
            b = (3 < 3);
            b = (3 > 3);
            b = (3 <= 3);
            b = (3 >= 3);

            //control flow statements
            //conditional
            if (3 <= 4)
            {
                //run some code
            }
            else
            {
                //otherwise, run this code
            }

            //loops
            // a for loop, using loop variable "num" or "i", that run 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //while loops - keep running the loop until the condition becomes false
            while (b)
            {
                //this code runs many times as long as the condition is true
            }

            switch (str)
            {
                case "1":
                //do something
                case "abc":
                    //do something else
                default: //if no match, do something else
                    break;
            }

            //in C# we can put plenty of things in the switch statement
            //it will compate with ==

            //visual studio gives us tab-completion ( press tab to get fuctions)
            anotherMethod();
        }

        //(modifiers) (return type) (method name) (the parameters in parenthesis)
        static void anotherMethod()
        {
            //extract some code out to another reusable function
        }
    }
}
