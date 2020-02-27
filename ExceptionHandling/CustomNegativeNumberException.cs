using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CustomNegativeNumberException : Exception
    {
        public CustomNegativeNumberException()
        {

        }

        public CustomNegativeNumberException(string message) : base(message)
        {

        }

        public CustomNegativeNumberException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
