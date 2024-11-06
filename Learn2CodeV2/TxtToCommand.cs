using System;
using System.Collections.Generic;
using System.Linq;


namespace Learn2CodeV2
{
    public class TxtToCommand : ICommandListFactory
    {
        private Metrics _metrics;

        public List<ICommand> ToCommandList(string[] lines)
        {
            _metrics = new Metrics();
            var commandList = new List<ICommand>();
            Stack<(List<ICommand> commandList, string command)> commandStack = new Stack<(List<ICommand>, string)>();
            var currentIndentationLevel = 1;

            foreach (var line in lines)
            {
                var indentationLevel = line.TakeWhile(Char.IsWhiteSpace).Count() + 1;
                var command = line.Trim();

                if (command.StartsWith("Repeat"))
                {
                    //repeatCount = int.Parse(command.Split(' ')[1]);
                    commandStack.Push((commandList, command.Split(' ')[1]));
                    commandList = new List<ICommand>();
                    currentIndentationLevel = indentationLevel;

                    _metrics.RepeatAmount += 1;
                    if (currentIndentationLevel > _metrics.NestingLevel)
                    {
                        _metrics.NestingLevel = currentIndentationLevel;
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
                        var (parentCommands, stackRepeatInfo) = commandStack.Pop();

                        if (stackRepeatInfo == "wall" || stackRepeatInfo == "edge")
                        {
                            RepeatUntilCommand repeatCommand = new RepeatUntilCommand(stackRepeatInfo, commandList);
                            commandList = parentCommands;
                            commandList.Add(repeatCommand);
                        }
                        else
                        {
                            RepeatCommand repeatCommand = new RepeatCommand(int.Parse(stackRepeatInfo), commandList);
                            commandList = parentCommands;
                            commandList.Add(repeatCommand);
                        }
                    }

                    commandList.Add(ToCommand(command));
                }
            }

            while (commandStack.Count > 0)
            {
                var (parentCommands, stackRepeatInfo) = commandStack.Pop();

                if (stackRepeatInfo == "wall" || stackRepeatInfo == "edge")
                {
                    RepeatUntilCommand repeatCommand = new RepeatUntilCommand(stackRepeatInfo, commandList);
                    commandList = parentCommands;
                    commandList.Add(repeatCommand);
                }
                else
                {
                    RepeatCommand repeatCommand = new RepeatCommand(int.Parse(stackRepeatInfo), commandList);
                    commandList = parentCommands;
                    commandList.Add(repeatCommand);
                }
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

            _metrics.CommandsAmount = totalCommandCount;

            return _metrics;
        }
    }
}
