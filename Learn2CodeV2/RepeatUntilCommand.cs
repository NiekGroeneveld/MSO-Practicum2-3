using Learn2CodeV2;
using MSO_P2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MSO_P2
{
    public class RepeatUntilCommand : ICommand
    {
        private string condition;

        private List<ICommand> CommandList;

        private int numberOfCommands;

        public RepeatUntilCommand(string condition, List<ICommand> commandList)
        {
            this.condition = condition;
            CommandList = commandList;
            numberOfCommands = 0;
        }

        public void Execute(Grid grid)
        {
            int iterations = 0;

            while (iterations < 100)
            {
                foreach (ICommand command in CommandList)
                {
                    //Calculate new position
                    int newX = grid.character.position.x, newY = grid.character.position.y;
                    int steps = 1;

                    if (command is MoveCommand moveCommand)
                    {
                        steps = moveCommand._steps;
                    }

                    switch (grid.character.direction)
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

                    if (condition == "wall")
                    {
                        if (grid.closedPosition.Contains(newPos))
                        {
                            return;
                        }
                    }
                    else if (condition == "edge")
                    {
                        if (newX > grid.Width - 1 || (newY * -1) > grid.Height - 1)
                        {
                            return;
                        }
                    }

                    command.Execute(grid);

                    iterations++;
                    numberOfCommands++;
                }
            }
        }

        public int CountCommands()
        {
            return numberOfCommands;
        }
    }
}
