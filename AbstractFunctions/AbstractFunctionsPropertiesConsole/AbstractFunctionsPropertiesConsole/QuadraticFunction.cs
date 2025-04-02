using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    public class QuadraticFunction : Function
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int power = 0;
        private double delta = 0;
        public QuadraticFunction(int a, int b, int c, int power )
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.power = power;
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
                return Convert.ToString(this.b);
            }
        }

        public override string CFactor
        {
            get
            {
                return Convert.ToString(this.c);
            }
        }

        public override string DFactor
        {
            get
            {
                return "There is no DFactor. This is quadratic function";
            }
        }

        public override string DerivativeLinearFunction
        {
            get
            {
                return "There is no linear derivative. This is quadratic function";
            }
        }

        public override string DerivativeQuadraticFunction
        {
            get
            {
                return Convert.ToString(2 * this.a) + "x + " + Convert.ToString(this.b);
            }
        }

        public override string DerivativeCubeFunction
        {
            get
            {
                return "There is no cube derivative. This is quadratic function";
            }
        }

        public override string DerivativeRationalFunction
        {
            get
            {
                return "There is no rational derivative. This is quadratic function";
            }
        }

        public override string Delta
        {
            get
            {
                return Convert.ToString(Math.Pow(this.b, 2) - 4 * this.a * this.c);
            }
        }
    }
}
