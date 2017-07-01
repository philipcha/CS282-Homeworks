using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPluginLibrary
{
    public class PlayerDebuff : PlayerPlugin, IPlugin
    {
        public string GetPluginP(string Plugin)
        {
            return "能力下降的" + player;
        }
        public string GetPluginM(string Plugin)
        {
            return "能力下降的" + master;
        }
    }
}
