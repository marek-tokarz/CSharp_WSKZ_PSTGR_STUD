using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFieldAcces
{
    internal class FunctionOperations
    {
        protected int aFactor = 0;
        protected int bFactor = 0;
        protected int cFactor = 0;

        public void setA(int a) { this.aFactor = a; }

        public void setB(int b) { this.bFactor = b; }

        public void setC(int c) { this.cFactor = c; }
    }
}
