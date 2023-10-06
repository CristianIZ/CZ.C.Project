using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction.Exceptions
{
    public class ColumnModificationException : Exception
    {
        public ColumnModificationException(string message) : base(message)
        {
        }
    }
}
