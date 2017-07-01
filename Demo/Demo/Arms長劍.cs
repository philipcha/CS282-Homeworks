using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Arms長劍 : PlayerArms
    {
        public override string GetAtms(string Arms)
        {
            return "這是拿了長劍" + player;
        }
    }
}
