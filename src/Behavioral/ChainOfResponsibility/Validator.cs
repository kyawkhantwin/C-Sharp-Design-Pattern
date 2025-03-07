using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility
{
    public class Validator
    {
        public void Validate(HttpRequest request){
            var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim whitespace
            request.ValideUserName = username.Trim();
            request.ValidePassword = password.Trim();
        }
    }
}