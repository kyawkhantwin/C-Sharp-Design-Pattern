using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesginPattern.src.Behavioral.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;

        private Overlay _overlay;

        public VideoStorage(Compressors compressor, Overlay overlay = Overlay.None){
            _compressor = compressor;
            _overlay = overlay;
        }
        public void SetCompressor(Compressors compressor){
            _compressor = compressor;
        }
        public void SetOverlay(Overlay overlay){
            _overlay = overlay;
        }
        public void Store (string fileName){
            if(_compressor == Compressors.MOV){
                System.Console.WriteLine("Comprssing using MOV");
            } else if (_compressor == Compressors.MP4){
                  System.Console.WriteLine("Comprssing using MP$");
            } else if (_compressor == Compressors.WEBM){
                  System.Console.WriteLine("Comprssing using WEBM");
            } else{
                  System.Console.WriteLine("Cannot compress with this method");
            }

            if(_overlay == Overlay.BlackAndWhite){
                System.Console.WriteLine("Applying black and white overlay");
            } else if (_overlay == Overlay.Blur){
                System.Console.WriteLine("Applying blur overlay");
            } else if (_overlay == Overlay.Blur){
                System.Console.WriteLine("Applying blur overlay");
            } else if (_overlay == Overlay.None){
                System.Console.WriteLine("Applying blur overlay");
            } 
                System.Console.WriteLine("Stroing video to " + fileName + "." +_compressor);
        }
    }
}