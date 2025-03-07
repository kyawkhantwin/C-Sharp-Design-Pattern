using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility.GoodSolution
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
                  var username = request.GetUsername();
            var password = request.GetPassword();

            // Trim whitespace
            request.ValideUserName = username.Trim();
            request.ValidePassword = password.Trim();
        }
    }
}