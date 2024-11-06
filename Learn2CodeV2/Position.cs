

namespace Learn2CodeV2
{
    public class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        //Added overrides below to make sure position can be found in a list using List.Contains(). Used for finding positions as forbidden.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Position other = (Position)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + X;
                hash = hash * 23 + Y;
                return hash;
            }

        }
    }
}
