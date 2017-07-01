using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     class Debuff中毒 : PlayerDebuff
    {
        public override string GetDebuff(string Debuff)
        {
            return "中毒狀態" + player;
        }
    }
}
