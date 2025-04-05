using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class GeometricFigure
    {
        public int a = 0;
        public int b = 0;
        public double r = 0;

        virtual public void Area(int a, int b)
        {
            Console.WriteLine("This is some rectangle");
        }

        virtual public void Area(double r)
        {
            Console.WriteLine("This is some circle");
        }
    }
}
