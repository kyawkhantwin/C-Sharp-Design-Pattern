using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy.GoodSolution
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply(){
            Console.WriteLine("Applying black and white overlay");
        }
    }
}