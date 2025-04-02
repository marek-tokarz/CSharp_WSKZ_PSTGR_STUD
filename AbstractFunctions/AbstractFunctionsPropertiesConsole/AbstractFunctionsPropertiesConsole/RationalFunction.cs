using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    public class RationalFunction : Function
    {
        private int a = 0;
        public RationalFunction(int a)
        {
            this.a = a;
        }

        public override string AFactor
        {
            get
            {
                return Convert.ToString(this.a);
            }
        }

        public override string BFactor
        {
            get
            {
                return "There is no BFactor. This is rational function";
            }
        }

        public override string CFactor
        {
            get
            {
                return "There is no CFactor. This is rational function";
            }
        }

        public override string DFactor
        {
            get
            {
                return "There is no CFactor. This is rational function";
            }
        }

        public override string DerivativeLinearFunction
        {
            get
            {
                return "There is no linear derivative. This is rational function";
            }
        }

        public override string DerivativeQuadraticFunction
        {
            get
            {
                return "There is no quadratic derivative. This is rational function";
            }
        }

        public override string DerivativeCubeFunction
        {
            get
            {
                return "There is no cubic derivative. This is rational function";
            }
        }

        public override string DerivativeRationalFunction
        {
            get
            {
                return Convert.ToString(-(this.a) + "/x^2");
            }
        }

        public override string Delta
        {
            get
            {
                return "There is no delta. This is rational function";
            }
        }

    }
}
