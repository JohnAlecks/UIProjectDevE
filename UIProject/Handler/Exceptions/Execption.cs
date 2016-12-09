using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProject
{
    public class PasswordIsTooShort : Exception {
        public PasswordIsTooShort(string message) : base(message) {
        }
    }
}
