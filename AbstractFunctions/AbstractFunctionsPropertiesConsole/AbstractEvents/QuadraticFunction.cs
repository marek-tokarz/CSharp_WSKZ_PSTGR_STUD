using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEvents
{
    public class QuadraticFunction : Function
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private double _x = 0;

        public QuadraticFunction(int a, int b, int c, double x)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            _x = x;
            _value = Convert.ToDouble(this.a * Math.Pow(_x, 2) + this.b * _x + this.c);
        }

        public double Update(double x)
        {
            _x = x;
            _value = a * Math.Pow(_x, 2) + b * _x + c;
            OnFunValueChanged(new FunctionValueEventArgs(_value));
            return _value;
        }

        protected override void OnFunValueChanged(FunctionValueEventArgs e)
        {
            base.OnFunValueChanged(e);
        }
    }
}
