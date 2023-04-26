using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Exceptions
{
    public class RowModificationException : Exception
    {
        public RowModificationException(string message) : base(message)
        {
        }
    }
}
