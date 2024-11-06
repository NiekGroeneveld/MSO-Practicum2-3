
using System.Collections.Generic;


namespace Learn2CodeV2
{
    public class RepeatUntilCommand : ICommand
    {
        private readonly string _condition;

        private readonly List<ICommand> _commandList;

        private int _numberOfCommands;

        public RepeatUntilCommand(string condition, List<ICommand> commandList)
        {
            this._condition = condition;
            _commandList = commandList;
            _numberOfCommands = 0;
        }

        public void Execute(Grid grid)
        {
            int iterations = 0;

            while (iterations < 100)
            {
                foreach (ICommand command in _commandList)
                {
                    //Calculate new position
                    int newX = grid.Character.Position.X, newY = grid.Character.Position.Y;
                    int steps = 1;

                    if (command is MoveCommand moveCommand)
                    {
                        steps = moveCommand.Steps;
                    }

                    switch (grid.Character.Direction)
                    {
                        case Direction.North:
                            newY += steps;
                            break;
                        case Direction.East:
                            newX += steps;
                            break;
                        case Direction.South:
                            newY -= steps;
                            break;
                        case Direction.West:
                            newX -= steps;
                            break;
                    }

                    Position newPos = new Position(newX, newY);

                    if (_condition == "wall")
                    {
                        if (grid.ClosedPosition.Contains(newPos))
                        {
                            return;
                        }
                    }
                    else if (_condition == "edge")
                    {
                        if (newX > grid.Width - 1 || (newY * -1) > grid.Height - 1)
                        {
                            return;
                        }
                    }

                    command.Execute(grid);

                    iterations++;
                    _numberOfCommands++;
                }
            }
        }
        public override string ToString()
        {
            string result = $"REPEATED UNTIL {_condition.ToUpper()}: (";
            for (int i = 0; i < _commandList.Count - 1; i++)
                result += _commandList[i].ToString() + " + ";

            return result + _commandList[_commandList.Count - 1] + ")";
        }

        public int CountCommands()
        {
            return _numberOfCommands;
        }
    }
}
