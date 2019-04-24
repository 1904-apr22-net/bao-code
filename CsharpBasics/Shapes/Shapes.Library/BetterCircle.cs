using Shapes.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class BetterCircle : IShape
    {
        public int sides => 1;
        public double X { get; set; }
        public double Y { get; set; }

        protected double _radius; //this is a field
        public virtual double Radius
            //"virtual"
        {
            get
            {
                return _radius * 1.01;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public double getPerimeter() => Math.PI * 2 * Radius;
        public double Area => Math.PI * Math.Pow(Radius, 2);


        // "=>" is essentially a getter but cannot set
    }
}
