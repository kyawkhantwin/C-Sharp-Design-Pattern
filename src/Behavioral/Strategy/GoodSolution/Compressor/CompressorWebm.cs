using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy.GoodSolution
{
    public class CompressorWebm : ICompressor
    {
           public void Compress(){
            Console.WriteLine("Compressing video using Webm");
        }
    }
}