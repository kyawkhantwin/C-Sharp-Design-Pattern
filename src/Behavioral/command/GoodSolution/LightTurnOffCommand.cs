using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command.GoodSolution
{
    public class LightTurnOffCommand: ICommand
    {
        private Light _light;

        public LightTurnOffCommand(Light light)
        {
            _light = light;
        }
        public void Excute(){
            _light.TurnOff();
        }
    }
}