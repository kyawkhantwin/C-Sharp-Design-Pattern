using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Mediator
{
    public class TextBox : UIControl
    {
        protected string _text ="";

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string GetText(){
            return _text;
        }
        public void SetText(string text)
        {
            _text = text;
            _owner.Changed(this);
        }
    }
}