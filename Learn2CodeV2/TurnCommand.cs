
using System;


namespace Learn2CodeV2
{
    public class TurnCommand : ICommand
    {
        private readonly string _turnDirection;

        public TurnCommand(string turnDirection)
        {
            _turnDirection = turnDirection;
        }

        public void Execute(Grid grid)
        {
            if (_turnDirection == "left")
            {
                grid.Character.Direction = (Direction)(((int)grid.Character.Direction + 3) % 4);
            }
            else if (_turnDirection == "right")
            {
                grid.Character.Direction = (Direction)(((int)grid.Character.Direction + 1) % 4);
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
