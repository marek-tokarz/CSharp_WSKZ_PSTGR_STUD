using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class Circle : GeometricFigure
    {
        public double r = 0;
        public double circleArea = 0;

        public override void Area(double r)
        {
            circleArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area of a circle is: {0}", circleArea);
        }

    }
}
