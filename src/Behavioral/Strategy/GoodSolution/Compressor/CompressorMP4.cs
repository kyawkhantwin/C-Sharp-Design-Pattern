using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy.GoodSolution
{
    public class CompressorMP4 : ICompressor
    {
         public void Compress(){
            Console.WriteLine("Compressing video using MP4");
        }

    }
}