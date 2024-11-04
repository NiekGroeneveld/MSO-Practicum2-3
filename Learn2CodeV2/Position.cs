using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        //Added overrides below to make sure position can be found in a list using List.Contains(). Used for finding positions as forbidden.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Position other = (Position)obj;
            return x == other.x && y == other.y;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + x;
                hash = hash * 23 + y;
                return hash;
            }

        }
    }
}
