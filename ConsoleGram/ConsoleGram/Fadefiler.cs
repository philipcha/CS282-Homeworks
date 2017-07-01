using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class Fadefiler : CameraFiler
    {
        public override string GetImage(string image)
        {
            return "fade風格" + image;
        }
    }
}
