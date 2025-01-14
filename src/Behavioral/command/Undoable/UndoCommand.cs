using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace DesginPattern.src.Behavioral.command.Undoable
{
    public class UndoCommand : ICommand
    {
        private History _history;
        public  UndoCommand(History history)
        {
           _history = history;
        }
        public void Execute()
        {
           var lastCommand = _history.Pop();
            lastCommand.Unexecute();
        }
    }
}