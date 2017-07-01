using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class BeautifyFacePluginl : CameraPlugin, IFiler
    {
        public string GetImage(string image)
        {
            return "美顏的" + image;
        }
    }
}
