﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public interface ICommandListFactory
    {
        ICommand ToCommand(string command);
        List<ICommand> ToCommandList(string[] lines);
    }
}
