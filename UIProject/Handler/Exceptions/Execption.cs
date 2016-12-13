using System;
using System.Collections.Generic;
using System.Linq;

namespace UIProject
{
    public class PasswordIsTooShort : Exception
    {
        public PasswordIsTooShort(string message)
            : base(message)
        {
        }
    }
}
