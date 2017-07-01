using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Arms短劍 : PlayerArms
    {
        public override string GetAtms(string Arms)
        {
            return "這是拿了短劍" + player;
        }
    }
}
