using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunshyLauncherUtility
{
    public class ConfigHolders
    {
        public List<ConfigHolder> configHolders = new List<ConfigHolder>();
    }

    public class ConfigHolder
    {
        public string downloadURL { get; set; }
        public string versionURL { get; set; }
        public string executableName { get; set; }
    }
}
