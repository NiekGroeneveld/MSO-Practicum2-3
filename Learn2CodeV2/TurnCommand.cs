using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class TurnCommand : ICommand
    {
        private string _turnDirection;

        public TurnCommand(string turnDirection)
        {
            _turnDirection = turnDirection;
        }

        public void Execute(Character character)
        {
            if (_turnDirection == "left")
            {
                character.direction = (Direction)(((int)character.direction + 3) % 4);
            }
            else if (_turnDirection == "right")
            {
                character.direction = (Direction)(((int)character.direction + 1) % 4);
            }
            Console.Write($"Turn {_turnDirection}, ");
        }

        public override string ToString()
        {
            return $"TURN  " + _turnDirection.ToUpper();
        }

        public int CountCommands()
        {
            return 1;
        }
    }
}
