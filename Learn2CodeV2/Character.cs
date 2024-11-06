
using System.Collections.Generic;


namespace Learn2CodeV2
{
    public class Character
    {
        public Position Position;

        public Direction Direction;

        public List<Position> PathHistory = new List<Position>();   

        public Character()
        {
            Position = new Position(0, 0);
            Direction = Direction.East;
            PathHistory.Add(new Position(0,0));
        }


        public Position GetPosition()
        {
            return Position;
        }

        public override string ToString()
        {
            return $"End state ({Position.X},{Position.Y}) facing {Direction}.";
        }
    }
}
