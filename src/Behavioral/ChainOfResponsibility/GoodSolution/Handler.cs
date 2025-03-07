using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility.GoodSolution
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler setNextHandler(Handler handler){
            _nextHandler = handler;

            
            return handler;
        }
        public void Handle(HttpRequest request){
            if (DoHandle(request)){
                return;
            }
            if(_nextHandler != null){
                _nextHandler.Handle(request);
            }
        }
        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}