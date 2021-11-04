using System;
using System.Collections.Generic;
using System.Text;

namespace InvalidFormatException
{
    public class InvalidFormatExceptions : Exception
    {
        public InvalidFormatExceptions(string message) : base(message)
        {

        }
    }
}
