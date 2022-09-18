using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresExtensionMethodsExceptionsUnittest
{
    static class LogicExtensions
    {
        public static Boolean avanAndOdd(this int result)
        {
            if (result % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
