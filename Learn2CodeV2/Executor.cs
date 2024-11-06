using Learn2CodeV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public class Executor
    {
        public Grid grid;

        public List<ICommand> commandList;

        public Executor(Grid grid, List<ICommand> commandList)
        {
            this.grid = grid;
            this.commandList = commandList;
        }

        public string Run()
        {
            if (!grid.isExercise)
            {
                foreach (ICommand command in commandList)
                {
                    command.Execute(grid);
                }
                return "Program finished succesfully";
            }
            else
            {
                try
                {
                    foreach (ICommand command in commandList)
                    {
                        command.Execute(grid);
                    }
                }
                catch (MoveException ex)
                {
                    return ex.Message;
                }

                if (grid.character.position.x == grid.Endpoint.x && grid.character.position.y == grid.Endpoint.y)
                    return "Congratulations! The character made it to the end.";
                else
                    return "The character did not make it to the end. Please try again!";
            }
        }
    }
}
