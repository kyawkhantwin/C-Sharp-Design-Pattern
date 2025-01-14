using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command.GoodSolution
{
    public class LightTrunOnCommand : ICommand
    {
     private Light _light;

     public LightTrunOnCommand(Light light)
     {
         _light = light;
     }

     public void Excute()
     {
         _light.TurnOn();
     }
    }
   
}