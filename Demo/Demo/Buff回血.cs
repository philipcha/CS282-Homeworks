using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Buff回血 : PlayerBuff
    {
        public override string GetBuff(string Buff)
        {
            return "回血狀態" + player;
        }
    }
}
