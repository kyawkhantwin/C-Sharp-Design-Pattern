using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Mediator
{
    public  abstract class DialogBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}