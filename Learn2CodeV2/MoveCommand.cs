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
        private int _steps;

        public MoveCommand(int steps)
        {
            _steps = steps;
        }

        public void Execute(Character character)
        {
            int newX = 0, newY = 0;

            switch (character.direction)
            {
                case Direction.North:
                    character.position.y += _steps;
                    break;
                case Direction.East:
                    character.position.x += _steps;
                    break;
                case Direction.South:
                    character.position.y -= _steps;
                    break;
                case Direction.West:
                    character.position.x -= _steps;
                    break;
            }
            
            //New line to add the position where the character has been.
            character.pathHistory.Add(new Position(character.position.x, character.position.y));
          
            Console.Write($"Move {_steps}, ");
        }

        public int CountCommands()
        {
            return 1;
        }
    }
}
