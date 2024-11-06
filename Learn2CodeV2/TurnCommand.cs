using Learn2CodeV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public class TurnCommand : ICommand
    {
        private string _turnDirection;

        public TurnCommand(string turnDirection)
        {
            _turnDirection = turnDirection;
        }

        public void Execute(Grid grid)
        {
            if (_turnDirection == "left")
            {
                grid.character.direction = (Direction)(((int)grid.character.direction + 3) % 4);
            }
            else if (_turnDirection == "right")
            {
                grid.character.direction = (Direction)(((int)grid.character.direction + 1) % 4);
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
