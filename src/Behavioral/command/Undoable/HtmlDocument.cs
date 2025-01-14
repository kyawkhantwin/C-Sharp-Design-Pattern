using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command.Undoable
{
    public class HtmlDocument
    {
        public string Content { get; set; }
        public void MakeItalic(){
            Content = "<i>" + Content + "</i>";
        }
        
    }
}