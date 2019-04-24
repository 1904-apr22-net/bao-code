using Animals.Library;
using System;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.breed = "Lab";
            dog.name = "Jake";

            dog.bark();

            Console.WriteLine("Hello World!");
        }
    }
}
