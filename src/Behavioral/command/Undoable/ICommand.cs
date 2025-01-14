using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command.Undoable
{
    public interface ICommand
    {
        void Execute();

    }
}