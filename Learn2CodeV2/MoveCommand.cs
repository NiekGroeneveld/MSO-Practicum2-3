using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class MoveCommand : ICommand
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

            Console.Write($"Move {_steps}, ");
        }

        public int CountCommands()
        {
            return 1;
        }
    }
}
