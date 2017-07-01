using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class LomoFiler :CameraFiler
    
    {
        public override string GetImage(string image)
        {
            return "這是Lomo模式" + image;
        }
    }
}
