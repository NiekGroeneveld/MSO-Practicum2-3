using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    internal class RepeatCommand : ICommand
    {
        public int _count;
        public List<ICommand> _commands;

        public RepeatCommand(int count, List<ICommand> commands)
        {
            _count = count;
            _commands = commands;
        }

        public void Execute(Character character)
        {
            for (int i = 0; i < _count; i++)
            {
                foreach (var command in _commands)
                {
                    command.Execute(character);
                }
            }
        }

        public override string ToString()
        {
            return $"REPEAT " + _count + " TIMES";
        }

        public int CountCommands()
        {
            int totalCommandCount = 0;
            foreach (var command in _commands)
            {
                totalCommandCount += command.CountCommands();
            }
            
            return totalCommandCount * _count;
        }
    }
}
