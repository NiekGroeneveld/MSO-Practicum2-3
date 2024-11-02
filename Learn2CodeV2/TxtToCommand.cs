using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Input;

namespace MSO_P2
{
    public class TxtToCommand : ICommandListFactory
    {
        private Metrics _metrics;

        public List<ICommand> ToCommandList(string[] lines)
        {
            _metrics = new Metrics();
            List<ICommand> commandList = new List<ICommand>();
            Stack<(List<ICommand> commandList, int count)> commandStack = new Stack<(List<ICommand>, int)>();
            int currentIndentationLevel = 1;
            int repeatCount = 0;

            foreach (string line in lines)
            {
                int indentationLevel = line.TakeWhile(Char.IsWhiteSpace).Count() + 1;
                string command = line.Trim();

                if (command.StartsWith("Repeat"))
                {
                    repeatCount = int.Parse(command.Split(' ')[1]);
                    commandStack.Push((commandList, repeatCount));
                    commandList = new List<ICommand>();
                    currentIndentationLevel = indentationLevel;

                    _metrics.repeatAmount += 1;
                    if (currentIndentationLevel > _metrics.nestingLevel)
                    {
                        _metrics.nestingLevel = currentIndentationLevel;
                    }
                }
                else if (indentationLevel > currentIndentationLevel)
                {
                    commandList.Add(ToCommand(command));
                }
                else
                {
                    while (commandStack.Count > 0)
                    {
                        var (parentCommands, stackRepeatCount) = commandStack.Pop();

                        RepeatCommand repeatCommand = new RepeatCommand(stackRepeatCount, commandList);

                        commandList = parentCommands;
                        commandList.Add(repeatCommand);
                    }

                    commandList.Add(ToCommand(command));
                }
            }

            while (commandStack.Count > 0)
            {
                var (parentCommands, stackRepeatCount) = commandStack.Pop();

                RepeatCommand repeatCommand = new RepeatCommand(stackRepeatCount, commandList);

                commandList = parentCommands;
                commandList.Add(repeatCommand);
            }

            return commandList;
        }

        public ICommand ToCommand(string command)
        {
            command = command.ToLower();

            if (command.StartsWith("move"))
            {
                int steps = int.Parse(command.Split(' ')[1]);
                return new MoveCommand(steps);
            }
            else if (command.StartsWith("turn"))
            {
                string direction = command.Split(' ')[1];
                return new TurnCommand(direction);
            }

            throw new Exception();
        }

        public Metrics GetMetrics(List<ICommand> commands)
        {
            int totalCommandCount = 0;
            foreach (var command in commands)
            {
                totalCommandCount += command.CountCommands();
            }

            _metrics.commandsAmount = totalCommandCount;

            return _metrics;
        }
    }
}
