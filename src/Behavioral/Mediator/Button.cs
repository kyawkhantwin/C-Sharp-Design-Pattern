using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Mediator
{
    public class Button :UIControl
    {
        private bool _isEnabled;
        public Button(DialogBox owner): base(owner){

        }
        public bool isEnabled(){
            return _isEnabled;
        }
        public void setEnable(bool isEnabled){
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}