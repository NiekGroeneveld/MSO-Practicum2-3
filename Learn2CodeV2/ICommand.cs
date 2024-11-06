using Learn2CodeV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSO_P2
{
    public interface ICommand
    {
        void Execute(Grid grid);
        int CountCommands();
    }
}


