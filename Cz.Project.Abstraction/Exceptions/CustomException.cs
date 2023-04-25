using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
