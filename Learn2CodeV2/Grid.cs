using MSO_P2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2CodeV2
{
    public class Grid : TxtToGrid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<Position> closedPosition;
        public Character character { get; set; }
        public Position Endpoint { get; set; }
        public bool isExercise;

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            closedPosition = new List<Position>();
            character = new Character(); // Character class handles initial position and direction
            
            Endpoint = null;
        }

        public bool IsValidPosition(Position position)
        {
            bool withinbounds = true; // position.x >= 0 && position.x < Width && position.y >= 0 && position.y < Height;
            bool isOpen = closedPosition.Contains(position);
            return withinbounds && isOpen;
        }

        public void Reset()
        {
            character = new Character(); // Create new character with default position/direction
            character.pathHistory.Clear();
            character.pathHistory.Add(character.position);
        }
    }
}

