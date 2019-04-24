using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    //this is the JAVA way
    //default access for classes is "internal" 

    public class Circle
    {
        // field (most fundamental way to put data on a class)
        private double radius;

        //methods
        //getter
        public double getRadius()
        {
            return radius;
        }

        //setter
        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("not allowed");
            }
            else
            {
                this.radius = radius;
            }
        }
    }
}
