using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPluginLibrary
{
    class Arms短劍 : PlayerArms
    {
        public override string GetAtms(string Arms)
        {
            return "拿著短劍的" + player;
        }
    }
}
