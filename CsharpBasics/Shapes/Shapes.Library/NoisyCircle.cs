using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class NoisyCircle : BetterCircle
    {
        //override what a parent class does and put in a lot of WriteLine to print
        // what is happening to this object

        //in C#, by default, you cannot ovveride, you can add new properties/method/etc.

        //we opt-in to the possibility of override in the parent class using "virtual" modifier

        private double Radius
        {
            get
            {
                Console.WriteLine("Getting radius");
                return _radius;
            }
            set
            {
                Console.WriteLine("Setting radius");
                _radius = value;
            }
        }

        /*public override getPerimeter()
        {
            Console.WriteLine("getting perimeter");

            return base.getPerimeter;
        }*/

    }
}
