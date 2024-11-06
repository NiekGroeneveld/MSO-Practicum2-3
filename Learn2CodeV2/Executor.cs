
using System.Collections.Generic;

namespace Learn2CodeV2
{
    public class Executor
    {
        public Grid Grid;

        public List<ICommand> CommandList;

        public Executor(Grid grid, List<ICommand> commandList)
        {
            this.Grid = grid;
            this.CommandList = commandList;
        }

        public string Run()
        {
            if (!Grid.IsExercise)
            {
                foreach (ICommand command in CommandList)
                {
                    command.Execute(Grid);
                }
                return "Program finished succesfully";
            }
            else
            {
                try
                {
                    foreach (ICommand command in CommandList)
                    {
                        command.Execute(Grid);
                    }
                }
                catch (MoveException ex)
                {
                    return ex.Message;
                }

                if (Grid.Character.Position.X == Grid.Endpoint.Y && Grid.Character.Position.Y == Grid.Endpoint.Y)
                    return "Congratulations! The character made it to the end.";
                else
                    return "The character did not make it to the end. Please try again!";
            }
        }
    }
}
