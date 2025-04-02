using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEvents
{
    public class LinearFunction : Function
    {
        private int a = 0;
        private int b = 0;
        private double _x = 0;
        public LinearFunction (int a, int b, double x)
        {
            this.a = a;
            this.b = b;
            _x = x;
            _value = Convert.ToDouble(this.a * this._x + this.b);
        }

        public double Update(double x)
        {
            _x = x;
            _value = a * _x + b;
            OnFunValueChanged(new FunctionValueEventArgs(_value));
            return _value;
        }

        protected override void OnFunValueChanged(FunctionValueEventArgs e)
        {
            base.OnFunValueChanged(e);
        }
    }
}
