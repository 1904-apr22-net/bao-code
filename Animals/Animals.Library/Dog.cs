using System;

namespace Animals.Library
{
    public class Dog
    {
        public string breed { get; set; }
        public string name { get; set; }
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
