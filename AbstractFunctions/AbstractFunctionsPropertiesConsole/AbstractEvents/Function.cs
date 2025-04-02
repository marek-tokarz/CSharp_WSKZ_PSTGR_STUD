using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEvents
{
    public class FunctionValueEventArgs : EventArgs
    {
        public FunctionValueEventArgs(double value)
        {
            NewFunctionValue = value;
        }
        public double NewFunctionValue
        {
            get;
        }
    }
    public abstract class Function
    {
        protected double _value;
        public double FunValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        public event EventHandler<FunctionValueEventArgs> FunValueChanged;
        protected virtual void OnFunValueChanged(FunctionValueEventArgs e)
        {
            FunValueChanged?.Invoke(this,e);
        }
    }
}
