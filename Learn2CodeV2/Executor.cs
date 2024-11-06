
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

        public void Run(ConsoleTextBox console)
        {
            try
            {
                foreach (ICommand command in CommandList)
                {
                    command.Execute(Grid);
                    console.AppendText(command.ToString() + ", ");
                }
            }
            catch (MoveException ex) when (Grid.IsExercise)
            {
                console.WriteLine(ex.Message);
            }

            if (Grid.IsExercise)
            {
                if (Grid.Character.Position.X == Grid.Endpoint.Y && Grid.Character.Position.Y == Grid.Endpoint.Y)
                    console.WriteLine("Congratulations! The character made it to the end.");
                else
                    console.WriteLine("The character did not make it to the end. Please try again!");
            }
        }  
    }
}
