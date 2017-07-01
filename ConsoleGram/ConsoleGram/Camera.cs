using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    class Camera
    {
       public CameraPlugin plugin;

        private string image = "原始圖片";


        public string GetImage()
        {
            if (plugin == null)
                return image;
            else
            {
                if (plugin is IFiler)
                {
                    IFiler filer = plugin as IFiler;
                    return filer.GetImage(image);

                }
                else
                    return image;
            }
        }
    }
}
