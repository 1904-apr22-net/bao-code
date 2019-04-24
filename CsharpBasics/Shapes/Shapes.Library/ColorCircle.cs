using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class ColorCircle : BetterCircle
    {
        //instead of copy and paste from circle class, i can inherit all of its behavior and properties

        public String Color { get; set; }
        // add one property to the calss, on top of what it already has from BetterCircle
    }
}
