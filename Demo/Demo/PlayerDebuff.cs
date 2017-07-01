using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     public abstract class PlayerDebuff:PlayerPlugin,IDebuff
    {
    public abstract string GetDebuff(string Debuff);
    }
}
