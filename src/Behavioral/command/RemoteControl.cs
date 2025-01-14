using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.command
{
    // Invoker
    public class RemoteControl
    {
        private Light _light;

        private RemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if(turnOn)
                _light.TurnOn();
            else
                _light.TurnOff();
        }
    }
}