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

        public void Execute(Character character)
        {
            while (true)
            {
                foreach (ICommand command in CommandList)
                {
                    //Calculate new position
                    int newX = character.position.x, newY = character.position.y;

                    switch (character.direction)
                    {
                        case Direction.North:
                            newY += 1;
                            break;
                        case Direction.East:
                            newX += 1;
                            break;
                        case Direction.South:
                            newY -= 1;
                            break;
                        case Direction.West:
                            newX -= 1;
                            break;
                    }

                    if (condition == "wall")
                    {
                        //Check if next position is wall
                        //Check if next position is in invalid positions
                        return;
                    }
                    else if (condition == "edge")
                    {
                        //Check if next position is out of bounds
                        return;
                    }

                    command.Execute(character);
                }
            }
        }

        public int CountCommands()
        {
            return 0;
        }
    }
}
