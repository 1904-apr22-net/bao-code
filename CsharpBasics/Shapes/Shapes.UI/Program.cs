using Shapes.Library;
using System;

//private means only the current class can see the item

namespace Shapes.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();

            //not allowed because "radius is private"
            //double r = cir.radius;

            //use the getter method instead
            double r = cir.getRadius();

            cir.SetRadius(-4);


            BetterCircle bc = new BetterCircle();
            //uses the "set" property of the Radius method in BetterCircle
            bc.Radius = 5;

            //uses the "get" property of the Radius method in BetterCircle
            Console.WriteLine(bc.Radius);

            Console.WriteLine("Hello World!");

            ShapeWork();

            ColorCircle blueCircle = new ColorCircle();

        }

        static void ShapeWork()
        {
            Rectangle r = new Rectangle();

            r.length = 4;
            r.width = 3;

            Console.WriteLine(r.getPerimeter());
            Console.WriteLine(r.Area);
        }
    }
}
