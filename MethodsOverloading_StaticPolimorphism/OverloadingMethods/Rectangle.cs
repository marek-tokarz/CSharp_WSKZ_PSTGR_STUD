using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class Rectangle : GeometricFigure
    {
        public int a = 0;
        public int b = 0;
        public int area = 0;

        public override void Area(int a, int b)
        {
            area = a * b;
            Console.WriteLine("This is an area of a rectangle: {0}", area);
        }
    }
}
