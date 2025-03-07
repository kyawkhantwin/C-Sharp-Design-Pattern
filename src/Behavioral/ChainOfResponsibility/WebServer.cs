using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility
{
    public class WebServer
    {
        public void Handle(HttpRequest request){
            var validator = new Validator();
            validator.Validate(request);

            var authenticator = new Authenticator();
            authenticator.Authenticate(request);

            var logger = new Logger();
            logger.Log(request);
        }
    }
}