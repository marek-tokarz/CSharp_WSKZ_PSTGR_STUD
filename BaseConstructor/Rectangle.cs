using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{
    internal class Rectangle
    {
        protected int a = 0;
        protected int b = 0;

        public Rectangle(int l, int w)
        {
            a = l;
            b = w;
        }

        public int MakeArea()
        {
            return a * b;
        }

        public void DisplayInfos()
        {
            Console.WriteLine("Length: {0}, width: {1}", this.a, this.b);
            Console.WriteLine("Area {0}", this.MakeArea());
        }
    }
}
