using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    class Program
    {
        private static void Main(string[] args)
        {
            Camera iphone7 = new Camera();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = new LomoFiler();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = new Fadefiler();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin =null;

            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = new BeautifyFacePluginl();
            Console.WriteLine(iphone7.GetImage());

        }
    }
}
