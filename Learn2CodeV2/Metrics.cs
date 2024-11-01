using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class Metrics
    {
        public int commandsAmount;
        public int nestingLevel;
        public int repeatAmount;

        public Metrics()
        { 
            commandsAmount = 0;
            nestingLevel = 0;
            repeatAmount = 0;
        }

        public override string ToString()
        {
            return $" The number of commands is: {commandsAmount}\n" +
                   $" The maximum nesting level is: {nestingLevel}\n" +
                   $" The number of repeat commands is {repeatAmount}";
        }
    }
}
