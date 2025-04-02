using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    public class CubeFunction : Function
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int d = 0;
        private int cubep = 0;
        private int power = 0;

        public CubeFunction(int a, int b, int c, int d, int cubep, int power )
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.cubep = cubep;
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
                return Convert.ToString(this.d);
            }
        }

        public override string DerivativeLinearFunction
        {
            get
            {
                return "There is no linear derivative. This is cubic function";
            }
        }

        public override string DerivativeQuadraticFunction
        {
            get
            {
                return "There is no derivative. This is cubic function";
            }
        }

        public override string DerivativeCubeFunction
        {
            get
            {
                return Convert.ToString((this.cubep * this.a) + "x^2" + (this.power * this.b) + "x " + this.c);
            }
        }

        public override string DerivativeRationalFunction
        {
            get
            {
                return "There is no rational derivative. This is cubic function";
            }
        }

        public override string Delta
        {
            get
            {
                return "There is no delta. This is cube function";
            }
        }


    }
}
