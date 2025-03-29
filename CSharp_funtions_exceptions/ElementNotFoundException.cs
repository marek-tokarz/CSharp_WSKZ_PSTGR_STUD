using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_funtions_exceptions
{
    public class ElementNotFoundException : ApplicationException
    {
        public ElementNotFoundException() : base("Element has not been found")
        {

        }

        public ElementNotFoundException(String message) : base(message)
        {

        }
    }
}
