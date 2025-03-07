using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string _username;
        private string _password;
        public string ValideUserName {get;set;}
        public string ValidePassword {get;set;}
        public HttpRequest(string username, string password){
            _username = username;
            _password = password;
        }
        public string GetUsername(){
            return _username;
        }
        public string GetPassword(){
            return _password;
        }
    }
}