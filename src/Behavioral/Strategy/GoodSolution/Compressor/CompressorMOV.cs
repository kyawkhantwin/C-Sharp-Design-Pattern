using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy.GoodSolution
{
    public class CompressorMOV : ICompressor
    {
        public void Compress(){
            Console.WriteLine("Compressing video using MOV");
        }
    }
}