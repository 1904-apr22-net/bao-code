using Shapes.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Rectangle : IShape
    {
        public double length { get; set; }

        //below was generated when typing: prop <tab><tab>
        public int width { get; set; }

        public int sides => 4;
        public double getPerimeter()
        {
            return 2 * length * 2 * width;
        }

        /*public double area
        {
            get
            {
                return length * width;
            }
        }*/
        //bottom is same as top but shorter
        public double Area => length * width;
    }
}
