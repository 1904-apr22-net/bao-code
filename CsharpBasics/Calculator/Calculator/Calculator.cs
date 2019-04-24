using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        
        public void Calculate(int num)
        {
            for (int i = num; i > 0; i--)
            {
                //if remainder  is 0, it is divisible by 3
                //and print the number that is divisible by 3
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /*public bool multipleOfThree(int num)
        {
            if (num % 3 == 0) {
                return true;
            }

            return false;
        }*/
    }
}
