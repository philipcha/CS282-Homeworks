using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public abstract class CameraFiler :CameraPlugin, IFiler
    {
        public abstract string GetImage(string image);
    }
}
