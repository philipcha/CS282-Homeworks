using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class PlayerArms : PlayerPlugin, IPlugin
    {
        public abstract string GetAtms(string Arms);
    }
}
