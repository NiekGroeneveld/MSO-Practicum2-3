
using System.Collections.Generic;


namespace Learn2CodeV2
{
    public interface ICommandListFactory
    {
        ICommand ToCommand(string command);
        List<ICommand> ToCommandList(string[] lines);
    }
}
