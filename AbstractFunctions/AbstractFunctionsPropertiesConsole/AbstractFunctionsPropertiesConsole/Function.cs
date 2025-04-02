using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    public abstract class Function
    {
        public abstract string AFactor
        {
            get;
        }

        public abstract string BFactor
        {
            get;
        }

        public abstract string CFactor
        {
            get;
        }

        public abstract string DFactor
        {
            get;
        }

        public abstract string DerivativeLinearFunction
        {
            get;
        }

        public abstract string DerivativeQuadraticFunction
        {
            get;
        }

        public abstract string DerivativeCubeFunction
        {
            get;
        }

        public abstract string DerivativeRationalFunction
        {
            get;
        }

        public abstract string Delta
        {
            get;
        }
    }
}
