using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class Executor
    {
        public Character character;

        public List<ICommand> commandList;

        public Executor(Character character, List<ICommand> commandList)
        {
            this.character = character;
            this.commandList = commandList;
        }

        public void Run()
        {
            foreach (ICommand command in commandList)
            {
                command.Execute(character);
            }
        }
    }
}
