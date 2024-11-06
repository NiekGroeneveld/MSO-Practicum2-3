using Learn2CodeV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public class MoveCommand : ICommand
    {
        public int _steps {  get; private set; }

        public MoveCommand(int steps)
        {
            _steps = steps;
        }

        public void Execute(Grid grid)
        {
            int newX = 0, newY = 0;

            switch (grid.character.direction)
            {
                case Direction.North:
                    grid.character.position.y += _steps;
                    break;
                case Direction.East:
                    grid.character.position.x += _steps;
                    break;
                case Direction.South:
                    grid.character.position.y -= _steps;
                    break;
                case Direction.West:
                    grid.character.position.x -= _steps;
                    break;
            }

            Position newPos = new Position(grid.character.position.x, grid.character.position.y);

            if (grid.isExercise)
            {
                if (!grid.IsValidPosition(newPos))
                    throw new MoveException("Character is in an invalid position");

                if (grid.IsOutOfBounds(newPos))
                    throw new MoveException("Character is out of bounds");
            }

            //New line to add the position where the character has been.
            grid.character.pathHistory.Add(new Position(grid.character.position.x, grid.character.position.y));
          
            Console.Write($"Move {_steps}, ");
        }

        public int CountCommands()
        {
            return 1;
        }
    }
}
