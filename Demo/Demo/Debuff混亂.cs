using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Debuff混亂 : PlayerDebuff
    {
        public override string GetDebuff(string Debuff)
        {
            return "混亂狀態" + player;
        }
    }
}
