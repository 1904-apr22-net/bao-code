using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up calculator
            Calculator calc = new Calculator();

            //user input
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            int num = int.Parse(number);

            calc.Calculate(num);


            /*for (int i = num; i > 0; i--)
            {
                if (calc.multipleOfThree(i))
                {
                    Console.WriteLine(i);
                }
            }*/
        }
    }
}
