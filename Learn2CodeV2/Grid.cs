
using System.Collections.Generic;

namespace Learn2CodeV2
{
    public class Grid : TxtToGrid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<Position> ClosedPosition;
        public Character Character { get; set; }
        public Position Endpoint { get; set; }
        public bool IsExercise;

        public Grid(int width, int height, bool isExercise)
        {
            Width = width;
            Height = height;
            ClosedPosition = new List<Position>();
            Character = new Character(); // Character class handles initial position and direction
            this.IsExercise = isExercise;
            
            Endpoint = null;
        }

        public bool IsValidPosition(Position position)
        {
            return !ClosedPosition.Contains(position);
        }

        public bool IsOutOfBounds(Position position)
        {
            return position.X >= 0 && position.Y < Width && position.Y <= 0 && position.Y > Height;
        }

    }
}

