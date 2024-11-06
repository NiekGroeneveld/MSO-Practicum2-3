
using System.Collections.Generic;


namespace Learn2CodeV2
{
    public class RepeatCommand : ICommand
    {
        public int Count;
        public List<ICommand> Commands;

        public RepeatCommand(int count, List<ICommand> commands)
        {
            Count = count;
            Commands = commands;
        }

        public void Execute(Grid grid)
        {
            for (int i = 0; i < Count; i++)
            {
                foreach (var command in Commands)
                {
                    command.Execute(grid);
                }
            }
        }

        public override string ToString()
        {
            string result = $"REPEATED {Count} TIMES: (";
            for (int i = 0; i < Commands.Count - 1; i++)
                result += Commands[i].ToString() + " + ";

            return result + Commands[Commands.Count - 1] + ")";
        }

        public int CountCommands()
        {
            int totalCommandCount = 0;
            foreach (var command in Commands)
            {
                totalCommandCount += command.CountCommands();
            }
            
            return totalCommandCount * Count;
        }
    }
}
