using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Exceptions
{
    class DomaisException : AccessViolationException
    {
        public DomaisException(string message) : base(message)
        {

        }
    }
}
