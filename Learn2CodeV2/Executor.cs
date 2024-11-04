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

        public void Run()
        {
            foreach (ICommand command in commandList)
            {
                command.Execute(grid.character);

            }

        }
    }
}
