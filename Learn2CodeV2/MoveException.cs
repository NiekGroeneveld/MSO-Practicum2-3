using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2CodeV2
{
    public class MoveException : Exception
    {
        public MoveException(string message) : base(message) { }
    }
}
