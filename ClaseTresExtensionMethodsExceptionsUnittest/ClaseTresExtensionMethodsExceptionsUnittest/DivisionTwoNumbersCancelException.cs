using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresExtensionMethodsExceptionsUnittest
{
    public class DivisionTwoNumbersCancelException : Exception
    {
        public DivisionTwoNumbersCancelException(string message) : base(message)
        {
        }
    }
}
