using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class PlayerBuff : PlayerPlugin, IBuff
    {
        public abstract string GetBuff(string Buff);
    }
}
