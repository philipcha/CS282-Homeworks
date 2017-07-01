using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Buff再生 : PlayerBuff
    {
        public override string GetBuff(string Buff)
        {
            return "再生狀態" + player;
        }
    }
}
