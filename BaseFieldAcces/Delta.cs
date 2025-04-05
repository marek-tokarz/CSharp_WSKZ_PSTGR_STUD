using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFieldAcces
{
    internal class Delta : FunctionOperations
    {
        public double MakeDelta()
        {
            return Math.Pow((double)this.bFactor,2) - 4*this.aFactor*this.cFactor;
        }
    }
}
