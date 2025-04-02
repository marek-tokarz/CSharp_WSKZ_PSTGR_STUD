using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEvents
{
    public class RationalFunction : Function
    {
        private int a = 0;
        private double _x = 0;
        public RationalFunction(int a, double x )
        {
            this.a = a;
            _x = x;
            _value = Convert.ToDouble(this.a / _x);
        }
        public double update(double x)
        {
            _x = x;
            _value = a / _x;
            OnFunValueChanged(new FunctionValueEventArgs(_value));
            return _value;
        }

        protected override void OnFunValueChanged(FunctionValueEventArgs e)
        {
            base.OnFunValueChanged(e);
        }
    }
}
