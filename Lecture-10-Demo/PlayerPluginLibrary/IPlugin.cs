using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPluginLibrary
{
    public interface IPlugin
    {
        string GetPluginP(string Plugin);
        string GetPluginM(string Plugin);
    }
}
