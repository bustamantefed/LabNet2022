using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresExtensionMethodsExceptionsUnittest
{
    public class Logic
    {
        public Logic()
        {

        }
        public Logic(string text, string text2)
        {

        }

        public int LogicDivision(int text, int text2)
        {
            int result = text / text2;
            return result;
        }

        public int LogicDivisionTwo(int text, int text2)
        {

                int result = (text / text2) / 0;
                return result;  
        }
    }
    public class twoCharException : Exception
    {
        public twoCharException(string message) : base(message)
        {

        }
    }
}