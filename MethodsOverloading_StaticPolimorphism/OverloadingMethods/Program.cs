using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure geometricFigure = new Rectangle();
            geometricFigure.a = 4;
            geometricFigure.b = 5;

            geometricFigure.Area(geometricFigure.a, geometricFigure.b);

            GeometricFigure geometricCircle = new Circle();
            geometricCircle.r = 5;
            geometricCircle.Area(geometricCircle.r);
        }
    }
}
