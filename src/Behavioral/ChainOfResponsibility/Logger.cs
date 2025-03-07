using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.ChainOfResponsibility
{
    public class Logger
    {
        public void Log(HttpRequest request){
            Console.WriteLine("Log");
        }
    }
}