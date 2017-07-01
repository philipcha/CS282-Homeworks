using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPluginLibrary
{
    class Arms長劍 : PlayerArms
    {
        public override string GetPlugin(string Plugin)
        {
            return "拿著長劍的" + player;
         
        }
    }
}
