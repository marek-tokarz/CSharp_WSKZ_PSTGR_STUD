using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    public class LinearFunction : Function
    {
        private int a = 0;
        private int b = 0;
        private int linearDerr = 0;
        public LinearFunction(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string AFactor 
        {
            get {         
                return Convert.ToString(this.a);
            }
        }

        public override string BFactor 
        {
            get {
                return Convert.ToString(this.b);
            }
        }

        public override string CFactor 
        {
            get
            {
                return "There is no CFactor. This is linear function";
            }
        }

        public override string DFactor 
        {
            get
            {
                return "There is no CFactor. This is linear function";
            }
        }

        public override string DerivativeLinearFunction
        {
            get 
            {
                linearDerr = this.a;
                return Convert.ToString(linearDerr);
            }
        }

        public override string DerivativeQuadraticFunction
        {
            get
            {
                return "There is no quadratic derivative. This is a linear function";
            }
        }

        public override string DerivativeCubeFunction
        {
            get
            {
                return "There is no cubic derivative. This is a linear function";
            }
        }

        public override string DerivativeRationalFunction
        {
            get
            {
                return "There is no rational derivative. This is a linear function";
            }
        }

        public override string Delta
        {
            get
            {
                return "There is no delta. This is a linear function";
            }
        }
    }
}
