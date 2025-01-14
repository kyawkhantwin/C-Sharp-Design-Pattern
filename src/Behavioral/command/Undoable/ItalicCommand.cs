using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command.Undoable
{
    public class ItalicCommand : IUndoableCommand
    {
        private  HtmlDocument _htmlDocument;
        private string _previousContent;
        private History _history;

        public ItalicCommand(HtmlDocument htmlDocument,History history)
        {
            _htmlDocument = htmlDocument;
            _history = history;
        }

        public void Execute()
        {
            _previousContent = _htmlDocument.Content;
            _htmlDocument.MakeItalic();
            _history.Push(this);
        }
        public void Unexecute()
        {
             _htmlDocument.Content = _previousContent;
           
        }
    }
}