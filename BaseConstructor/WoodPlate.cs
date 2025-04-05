using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{
    internal class WoodPlate : Rectangle
    {
        public WoodPlate(int l, int w) : base(l, w)
        { }

        public int Costs()
        {
            int cost;
            cost = this.MakeArea() * 50;
            return cost;
        }

        public void DisplayInfos()
        {
            base.DisplayInfos();
            Console.WriteLine("Cost: {0}", this.Costs());
        }
    }
}
